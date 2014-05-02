#region Using directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TricornFieldEditor.Properties;

#endregion

namespace TricornFieldEditor
{
    public partial class MainForm : Form
    {
        private string _connectionString;
        private readonly List<string> _currentValues = new List<string>();
        private Regex _currentRegex;

        public MainForm()
        {
            InitializeComponent();

            Icon = Resources.AppIcon;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            casingComboBox.SelectedIndex = 0;
            acronymsTextBox.Text = Settings.Default.SavedAcronyms;
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            tableComboBox.Items.Clear();
            columnComboBox.Items.Clear();

            editorGroupBox.Enabled = false;
            testRunButton.Enabled = false;
            updateTricornButton.Enabled = false;

            _connectionString = string.Format("Server={0};Initial Catalog={1};Integrated Security=true",
                serverTextBox.Text, databaseTextBox.Text);

            using (var connection = new SqlConnection(_connectionString)) {
                try {
                    Cursor.Current = Cursors.WaitCursor;
                    connection.Open();

                    foreach (DataRow row in connection.GetSchema("Tables").Rows) {
                        var tablename = (string) row[2];
                        tableComboBox.Items.Add(tablename);
                    }

                    if (tableComboBox.Items.Count == 0) {
                        return;
                    }

                    tableComboBox.Sorted = true;
                    tableComboBox.SelectedIndex = 0;

                    editorGroupBox.Enabled = true;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    if (connection.State != ConnectionState.Closed) {
                        connection.Close();
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            columnComboBox.Items.Clear();

            var _connectionString = string.Format("Server={0};Initial Catalog={1};Integrated Security=true",
                serverTextBox.Text, databaseTextBox.Text);

            var tableName = tableComboBox.Text;

            using (var connection = new SqlConnection(_connectionString)) {
                try {
                    Cursor.Current = Cursors.WaitCursor;
                    string[] restrictions = {null, null, tableName, null};
                    connection.Open();
                    var columnNames = connection.GetSchema("Columns", restrictions)
                        .AsEnumerable()
                        .Select(s => s.Field<String>("Column_Name"))
                        .ToArray();

                    columnComboBox.Items.AddRange(columnNames);

                    if (columnComboBox.Items.Count == 0) {
                        return;
                    }

                    columnComboBox.Sorted = true;

                    applyFilterButton.Enabled = true;
                    testRunButton.Enabled = true;
                    updateTricornButton.Enabled = false;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    if (connection.State != ConnectionState.Closed) {
                        connection.Close();
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void columnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesEnhancedListView.Items.Clear();

            findTextBox.Enabled = false;
            _currentValues.Clear();

            const string queryFormat = "SELECT DISTINCT {0} FROM {1} ORDER BY {0} ASC";

            using (var connection = new SqlConnection(_connectionString)) {
                try {
                    Cursor.Current = Cursors.WaitCursor;
                    connection.Open();

                    string tableName = null, columnName = null;

                    Invoke((MethodInvoker) delegate {
                        tableName = tableComboBox.Text;
                        columnName = columnComboBox.Text;
                    });

                    var query = string.Format(queryFormat, columnName, tableName);

                    var cmd = new SqlCommand(query, connection);

                    using (var reader = cmd.ExecuteReader()) {
                        var type = reader.GetFieldType(0);

                        if (Type.GetTypeCode(type) != TypeCode.String) {
                            MessageBox.Show("The selected column must be a text field!");
                        }
                        else {
                            while (reader.Read()) {
                                var value = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);

                                if (string.IsNullOrWhiteSpace(value)) {
                                    continue;
                                }

                                _currentValues.Add(value);
                            }
                        }
                    }

                    findTextBox.Enabled = true;
                    dataGroupBox.Enabled = true;
                    valuesEnhancedListView.Enabled = true;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    if (connection.State != ConnectionState.Closed) {
                        connection.Close();
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRegex = null;
            testRunButton.Enabled = false;

            replaceWithTextBox.Enabled = findTextBox.Text.Length > 0;
        }

        private void applyFilterButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            IEnumerable<string> filteredValues = null;

            _currentRegex = null;

            var filterValue = findTextBox.Text.Replace(".", "\\.").Replace("(", "\\(").Replace(")", "\\)");

            // match case only
            if (matchCaseCheckBox.Checked & !matchWholeWordComboBox.Checked) {
                _currentRegex = new Regex("(?-i)" + filterValue);
            }
                // match whole words only
            else if (!matchCaseCheckBox.Checked & matchWholeWordComboBox.Checked) {
                _currentRegex = new Regex("\\b(?i)" + filterValue + "\\b");
            }
                // match both case and whole words
            else if (matchCaseCheckBox.Checked && matchWholeWordComboBox.Checked) {
                _currentRegex = new Regex("\\b(?-i)" + filterValue + "\\b");
            }
                // no conditions
            else {
                _currentRegex = new Regex("(?i)" + filterValue);
            }

            filteredValues = _currentValues.Where(v => _currentRegex.IsMatch(v));

            valuesEnhancedListView.BeginUpdate();
            valuesEnhancedListView.Items.Clear();
            foreach (var value in filteredValues) {
                valuesEnhancedListView.Items.Add(value);
            }
            valuesEnhancedListView.EndUpdate();

            Cursor.Current = Cursors.Default;

            testRunButton.Enabled = true;
        }

        private void testRunButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in valuesEnhancedListView.Items) {
                if (item.Checked) {
                    continue;
                }

                if (item.SubItems.Count > 1) {
                    item.SubItems.RemoveAt(1);
                }

                var originalValue = item.Text;

                var newValue = originalValue;

                if (findTextBox.Text.Length > 0) {
                    var match = _currentRegex.Match(originalValue);
                    var sb = new StringBuilder(originalValue);
                    sb.Remove(match.Index, match.Length);
                    sb.Insert(match.Index, replaceWithTextBox.Text);
                    newValue = sb.ToString();
                }

                switch (casingComboBox.Text) {
                    case "Title Case":
                        newValue = newValue.ToLower();
                        var acronyms = acronymsTextBox.Text.Split(new[] {"|"}, StringSplitOptions.None);
                        if (acronyms.Length > 0)
                        {
                            foreach (var acronym in acronyms) {
                                var regex = new Regex("\\b(?-i)" + acronym.ToLower() + "\\b");

                                if (regex.IsMatch(newValue)) {
                                    var m = regex.Match(newValue);
                                    newValue = newValue.Remove(m.Index, m.Length);
                                    newValue = newValue.Insert(m.Index, acronym.ToUpper());
                                }
                            }
                        }
                        // convert value to lower case first as ToTitleCase treats all 
                        // UPPERCASE words as acronyms
                        var textInfo = CultureInfo.CurrentCulture.TextInfo;
                        newValue = textInfo.ToTitleCase(newValue);
                        newValue = newValue.Replace("Mm", "mm");
                        break;
                    case "UPPER CASE":
                        newValue = newValue.ToUpper();
                        break;
                    case "lower case":
                        newValue = newValue.ToLower();
                        break;
                }

                item.SubItems.Add(newValue);
            }

            updateTricornButton.Enabled = true;
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            testRunButton.Enabled = false;
        }

        private void acronymsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            saveAcronymsButton.Enabled = true;
        }

        private void saveAcronymsButton_Click(object sender, EventArgs e)
        {
            Settings.Default.SavedAcronyms = acronymsTextBox.Text;
            Settings.Default.Save();

            saveAcronymsButton.Enabled = false;
        }

        private void valuesEnhancedListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked) {
                e.Item.Font = new Font(e.Item.Font, FontStyle.Strikeout);
                e.Item.ForeColor = Color.Gray;
            }
            else {
                e.Item.Font = new Font(e.Item.Font, FontStyle.Regular);
                e.Item.ForeColor = valuesEnhancedListView.ForeColor;
            }
        }

        private void UpdateTricorn()
        {
            const string updateCommandFormat = "UPDATE {0} SET {1}=@newValue WHERE {1}=@oldValue";

            using (var connection = new SqlConnection(_connectionString)) {
                connection.Open();
                var trans = connection.BeginTransaction();

                var cmdText = string.Format(updateCommandFormat, tableComboBox.Text, columnComboBox.Text);

                var cmd = new SqlCommand(cmdText, connection, trans);
                cmd.Prepare();

                try {
                    Cursor.Current = Cursors.WaitCursor;

                    foreach (ListViewItem item in valuesEnhancedListView.Items) {
                        if (item.Checked) {
                            continue;
                        }

                        var oldValue = item.Text;
                        var newValue = item.SubItems[1].Text;

                        if (oldValue.Equals(newValue, StringComparison.Ordinal)) {
                            continue;
                        }

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@oldValue", oldValue);
                        cmd.Parameters.AddWithValue("@newValue", newValue);

                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();

                    _currentValues.Clear();

                    foreach (ListViewItem item in valuesEnhancedListView.Items)
                    {
                        if (item.Checked)
                        {
                            continue;
                        }
                        item.Text = item.SubItems[1].Text;
                        item.SubItems.RemoveAt(1);
                        _currentValues.Add(item.Text);
                    }

                    MessageBox.Show("All values were updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    trans.Rollback();
                    MessageBox.Show("An error occurred. All changes have been rolled back!\n\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void updateTricornButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "This will irreversibly alter the data in Tricorn!\n\nAre you sure you want to proceed?\n\nTHIS MAY TAKE A LONG TIME!",
                "Confirm update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
                    return;
            }

            UpdateTricorn();
        }

        private void valuesEnhancedListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            manualEditTextBox.Text = string.Empty;

            manualEditTextBox.Enabled = valuesEnhancedListView.SelectionCount == 1;

            if (manualEditTextBox.Enabled) {
                if (valuesEnhancedListView.SelectedItems[0].SubItems.Count == 0) {
                    manualEditTextBox.Enabled = false;
                }
                else {
                    if (valuesEnhancedListView.SelectedItems[0].SubItems.Count == 1) {
                        manualEditTextBox.Enabled = false;
                    }
                    else {
                        manualEditTextBox.Text = valuesEnhancedListView.SelectedItems[0].SubItems[1].Text;
                    }
                }
            }
        }

        private void manualEditTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            valuesEnhancedListView.SelectedItems[0].SubItems[1].Text = manualEditTextBox.Text;
        }

        private void valuesEnhancedListView_ItemsRemoved(object sender, EventArgs e)
        {
            manualEditTextBox.Text = string.Empty;
            manualEditTextBox.Enabled = false;
        }
    }
}