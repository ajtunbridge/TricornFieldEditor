namespace TricornFieldEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.testRunButton = new System.Windows.Forms.Button();
            this.updateTricornButton = new System.Windows.Forms.Button();
            this.editorGroupBox = new System.Windows.Forms.GroupBox();
            this.matchWholeWordComboBox = new System.Windows.Forms.CheckBox();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.casingComboBox = new System.Windows.Forms.ComboBox();
            this.replaceWithTextBox = new System.Windows.Forms.TextBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.columnComboBox = new System.Windows.Forms.ComboBox();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.acronymsTextBox = new System.Windows.Forms.TextBox();
            this.saveAcronymsButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.manualEditTextBox = new System.Windows.Forms.TextBox();
            this.valuesEnhancedListView = new nGenLibrary.Controls.EnhancedListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.configurationGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.editorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.databaseTextBox);
            this.configurationGroupBox.Controls.Add(this.serverTextBox);
            this.configurationGroupBox.Controls.Add(this.label7);
            this.configurationGroupBox.Controls.Add(this.testConnectionButton);
            this.configurationGroupBox.Controls.Add(this.label6);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(277, 164);
            this.configurationGroupBox.TabIndex = 0;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Configuration";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Location = new System.Drawing.Point(6, 89);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(265, 25);
            this.databaseTextBox.TabIndex = 1;
            this.databaseTextBox.Text = "Production";
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(6, 41);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(265, 25);
            this.serverTextBox.TabIndex = 0;
            this.serverTextBox.Text = ".\\SQLEXPRESS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Database";
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(6, 120);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(265, 35);
            this.testConnectionButton.TabIndex = 2;
            this.testConnectionButton.Text = "Connect to Tricorn";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Server";
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.manualEditTextBox);
            this.dataGroupBox.Controls.Add(this.label9);
            this.dataGroupBox.Controls.Add(this.valuesEnhancedListView);
            this.dataGroupBox.Enabled = false;
            this.dataGroupBox.Location = new System.Drawing.Point(295, 12);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(658, 591);
            this.dataGroupBox.TabIndex = 5;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // testRunButton
            // 
            this.testRunButton.Enabled = false;
            this.testRunButton.Location = new System.Drawing.Point(528, 609);
            this.testRunButton.Name = "testRunButton";
            this.testRunButton.Size = new System.Drawing.Size(246, 46);
            this.testRunButton.TabIndex = 2;
            this.testRunButton.Text = "Test run";
            this.testRunButton.UseVisualStyleBackColor = true;
            this.testRunButton.Click += new System.EventHandler(this.testRunButton_Click);
            // 
            // updateTricornButton
            // 
            this.updateTricornButton.Enabled = false;
            this.updateTricornButton.Location = new System.Drawing.Point(780, 609);
            this.updateTricornButton.Name = "updateTricornButton";
            this.updateTricornButton.Size = new System.Drawing.Size(173, 46);
            this.updateTricornButton.TabIndex = 3;
            this.updateTricornButton.Text = "Update Tricorn";
            this.updateTricornButton.UseVisualStyleBackColor = true;
            this.updateTricornButton.Click += new System.EventHandler(this.updateTricornButton_Click);
            // 
            // editorGroupBox
            // 
            this.editorGroupBox.Controls.Add(this.saveAcronymsButton);
            this.editorGroupBox.Controls.Add(this.acronymsTextBox);
            this.editorGroupBox.Controls.Add(this.matchWholeWordComboBox);
            this.editorGroupBox.Controls.Add(this.matchCaseCheckBox);
            this.editorGroupBox.Controls.Add(this.label3);
            this.editorGroupBox.Controls.Add(this.casingComboBox);
            this.editorGroupBox.Controls.Add(this.replaceWithTextBox);
            this.editorGroupBox.Controls.Add(this.findTextBox);
            this.editorGroupBox.Controls.Add(this.columnComboBox);
            this.editorGroupBox.Controls.Add(this.tableComboBox);
            this.editorGroupBox.Controls.Add(this.label8);
            this.editorGroupBox.Controls.Add(this.label5);
            this.editorGroupBox.Controls.Add(this.label4);
            this.editorGroupBox.Controls.Add(this.label2);
            this.editorGroupBox.Controls.Add(this.label1);
            this.editorGroupBox.Enabled = false;
            this.editorGroupBox.Location = new System.Drawing.Point(12, 182);
            this.editorGroupBox.Name = "editorGroupBox";
            this.editorGroupBox.Size = new System.Drawing.Size(277, 473);
            this.editorGroupBox.TabIndex = 1;
            this.editorGroupBox.TabStop = false;
            this.editorGroupBox.Text = "Editor";
            // 
            // matchWholeWordComboBox
            // 
            this.matchWholeWordComboBox.AutoSize = true;
            this.matchWholeWordComboBox.Location = new System.Drawing.Point(9, 195);
            this.matchWholeWordComboBox.Name = "matchWholeWordComboBox";
            this.matchWholeWordComboBox.Size = new System.Drawing.Size(169, 21);
            this.matchWholeWordComboBox.TabIndex = 8;
            this.matchWholeWordComboBox.Text = "Match whole word only?";
            this.matchWholeWordComboBox.UseVisualStyleBackColor = true;
            this.matchWholeWordComboBox.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Checked = true;
            this.matchCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(9, 168);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(99, 21);
            this.matchCaseCheckBox.TabIndex = 8;
            this.matchCaseCheckBox.Text = "Match case?";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            this.matchCaseCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxes_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Change casing to";
            // 
            // casingComboBox
            // 
            this.casingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.casingComboBox.FormattingEnabled = true;
            this.casingComboBox.Items.AddRange(new object[] {
            "Do not change",
            "Title Case",
            "UPPER CASE",
            "lower case"});
            this.casingComboBox.Location = new System.Drawing.Point(9, 289);
            this.casingComboBox.Name = "casingComboBox";
            this.casingComboBox.Size = new System.Drawing.Size(262, 25);
            this.casingComboBox.TabIndex = 4;
            // 
            // replaceWithTextBox
            // 
            this.replaceWithTextBox.Enabled = false;
            this.replaceWithTextBox.Location = new System.Drawing.Point(9, 241);
            this.replaceWithTextBox.Name = "replaceWithTextBox";
            this.replaceWithTextBox.Size = new System.Drawing.Size(262, 25);
            this.replaceWithTextBox.TabIndex = 3;
            // 
            // findTextBox
            // 
            this.findTextBox.Enabled = false;
            this.findTextBox.Location = new System.Drawing.Point(9, 137);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(262, 25);
            this.findTextBox.TabIndex = 2;
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // columnComboBox
            // 
            this.columnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox.FormattingEnabled = true;
            this.columnComboBox.Location = new System.Drawing.Point(9, 89);
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.Size = new System.Drawing.Size(262, 25);
            this.columnComboBox.TabIndex = 1;
            this.columnComboBox.SelectedIndexChanged += new System.EventHandler(this.columnComboBox_SelectedIndexChanged);
            // 
            // tableComboBox
            // 
            this.tableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Location = new System.Drawing.Point(9, 41);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(262, 25);
            this.tableComboBox.TabIndex = 0;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Replace with";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Column";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Table";
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Enabled = false;
            this.applyFilterButton.Location = new System.Drawing.Point(295, 609);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(227, 46);
            this.applyFilterButton.TabIndex = 2;
            this.applyFilterButton.Text = "Apply filter";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Acronyms (pipe separated)";
            // 
            // acronymsTextBox
            // 
            this.acronymsTextBox.Location = new System.Drawing.Point(9, 337);
            this.acronymsTextBox.Multiline = true;
            this.acronymsTextBox.Name = "acronymsTextBox";
            this.acronymsTextBox.Size = new System.Drawing.Size(262, 96);
            this.acronymsTextBox.TabIndex = 9;
            this.acronymsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acronymsTextBox_KeyPress);
            // 
            // saveAcronymsButton
            // 
            this.saveAcronymsButton.Location = new System.Drawing.Point(9, 439);
            this.saveAcronymsButton.Name = "saveAcronymsButton";
            this.saveAcronymsButton.Size = new System.Drawing.Size(262, 28);
            this.saveAcronymsButton.TabIndex = 10;
            this.saveAcronymsButton.Text = "Save acronyms";
            this.saveAcronymsButton.UseVisualStyleBackColor = true;
            this.saveAcronymsButton.Click += new System.EventHandler(this.saveAcronymsButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Manual edit";
            // 
            // manualEditTextBox
            // 
            this.manualEditTextBox.Enabled = false;
            this.manualEditTextBox.Location = new System.Drawing.Point(6, 560);
            this.manualEditTextBox.Name = "manualEditTextBox";
            this.manualEditTextBox.Size = new System.Drawing.Size(646, 25);
            this.manualEditTextBox.TabIndex = 2;
            this.manualEditTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.manualEditTextBox_KeyUp);
            // 
            // valuesEnhancedListView
            // 
            this.valuesEnhancedListView.AlternateBackColor = System.Drawing.Color.LightYellow;
            this.valuesEnhancedListView.CheckBoxes = true;
            this.valuesEnhancedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.valuesEnhancedListView.EnsureSelection = false;
            this.valuesEnhancedListView.FullRowSelect = true;
            this.valuesEnhancedListView.IndexOfColumnToResize = 0;
            this.valuesEnhancedListView.ItemContextMenuStrip = null;
            this.valuesEnhancedListView.Location = new System.Drawing.Point(4, 21);
            this.valuesEnhancedListView.Name = "valuesEnhancedListView";
            this.valuesEnhancedListView.ResizeColumnToFill = true;
            this.valuesEnhancedListView.ShowItemToolTips = true;
            this.valuesEnhancedListView.Size = new System.Drawing.Size(648, 516);
            this.valuesEnhancedListView.TabIndex = 0;
            this.valuesEnhancedListView.TabStop = false;
            this.valuesEnhancedListView.UseAlternatingBackColor = true;
            this.valuesEnhancedListView.UseCompatibleStateImageBehavior = false;
            this.valuesEnhancedListView.View = System.Windows.Forms.View.Details;
            this.valuesEnhancedListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.valuesEnhancedListView_ItemChecked);
            this.valuesEnhancedListView.SelectedIndexChanged += new System.EventHandler(this.valuesEnhancedListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Original value";
            this.columnHeader1.Width = 316;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "New value";
            this.columnHeader2.Width = 325;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 663);
            this.Controls.Add(this.editorGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.updateTricornButton);
            this.Controls.Add(this.configurationGroupBox);
            this.Controls.Add(this.applyFilterButton);
            this.Controls.Add(this.testRunButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tricorn Field Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.editorGroupBox.ResumeLayout(false);
            this.editorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.Button testRunButton;
        private System.Windows.Forms.Button updateTricornButton;
        private nGenLibrary.Controls.EnhancedListView valuesEnhancedListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox databaseTextBox;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.GroupBox editorGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox casingComboBox;
        private System.Windows.Forms.TextBox replaceWithTextBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.ComboBox columnComboBox;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox matchWholeWordComboBox;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.TextBox acronymsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveAcronymsButton;
        private System.Windows.Forms.TextBox manualEditTextBox;
        private System.Windows.Forms.Label label9;
    }
}

