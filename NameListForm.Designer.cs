namespace Project2
{
    partial class NameListForm
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
            this.components = new System.ComponentModel.Container();
            this.List = new System.Windows.Forms.ListBox();
            this.OriginalName = new System.Windows.Forms.TextBox();
            this.RestOfName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Suffix = new System.Windows.Forms.TextBox();
            this.LastNameFirstButton = new System.Windows.Forms.Button();
            this.SuffixLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.RestOfNameLabel = new System.Windows.Forms.Label();
            this.OriginalNameLabel = new System.Windows.Forms.Label();
            this.FileEditHelp = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANameToTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeANameFromTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsForUsingThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AmountOfNamesInList = new System.Windows.Forms.ToolStripStatusLabel();
            this.NamesInListAndCurrentTime = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.FileEditHelp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.NamesInListAndCurrentTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.BackColor = System.Drawing.SystemColors.Info;
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(0, 28);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(350, 342);
            this.List.Sorted = true;
            this.List.TabIndex = 0;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // OriginalName
            // 
            this.OriginalName.Location = new System.Drawing.Point(138, 37);
            this.OriginalName.Name = "OriginalName";
            this.OriginalName.Size = new System.Drawing.Size(249, 20);
            this.OriginalName.TabIndex = 1;
            this.OriginalName.Enter += new System.EventHandler(this.OriginalName_Enter);
            this.OriginalName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OriginalName_KeyPress);
            // 
            // RestOfName
            // 
            this.RestOfName.Location = new System.Drawing.Point(138, 112);
            this.RestOfName.Name = "RestOfName";
            this.RestOfName.ReadOnly = true;
            this.RestOfName.Size = new System.Drawing.Size(249, 20);
            this.RestOfName.TabIndex = 2;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(138, 193);
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Size = new System.Drawing.Size(249, 20);
            this.LastName.TabIndex = 3;
            // 
            // Suffix
            // 
            this.Suffix.Location = new System.Drawing.Point(138, 275);
            this.Suffix.Name = "Suffix";
            this.Suffix.ReadOnly = true;
            this.Suffix.Size = new System.Drawing.Size(249, 20);
            this.Suffix.TabIndex = 4;
            // 
            // LastNameFirstButton
            // 
            this.LastNameFirstButton.Location = new System.Drawing.Point(95, 376);
            this.LastNameFirstButton.Name = "LastNameFirstButton";
            this.LastNameFirstButton.Size = new System.Drawing.Size(145, 42);
            this.LastNameFirstButton.TabIndex = 5;
            this.LastNameFirstButton.Text = "Switch to Last Name First";
            this.LastNameFirstButton.UseVisualStyleBackColor = true;
            this.LastNameFirstButton.Click += new System.EventHandler(this.LastNameFirstButton_Click);
            // 
            // SuffixLabel
            // 
            this.SuffixLabel.AutoSize = true;
            this.SuffixLabel.Location = new System.Drawing.Point(11, 282);
            this.SuffixLabel.Name = "SuffixLabel";
            this.SuffixLabel.Size = new System.Drawing.Size(33, 13);
            this.SuffixLabel.TabIndex = 6;
            this.SuffixLabel.Text = "Suffix";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(11, 200);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name";
            // 
            // RestOfNameLabel
            // 
            this.RestOfNameLabel.AutoSize = true;
            this.RestOfNameLabel.Location = new System.Drawing.Point(11, 119);
            this.RestOfNameLabel.Name = "RestOfNameLabel";
            this.RestOfNameLabel.Size = new System.Drawing.Size(72, 13);
            this.RestOfNameLabel.TabIndex = 8;
            this.RestOfNameLabel.Text = "Rest of Name";
            // 
            // OriginalNameLabel
            // 
            this.OriginalNameLabel.AutoSize = true;
            this.OriginalNameLabel.Location = new System.Drawing.Point(11, 37);
            this.OriginalNameLabel.Name = "OriginalNameLabel";
            this.OriginalNameLabel.Size = new System.Drawing.Size(73, 13);
            this.OriginalNameLabel.TabIndex = 9;
            this.OriginalNameLabel.Text = "Original Name";
            // 
            // FileEditHelp
            // 
            this.FileEditHelp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.FileEditHelp.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.FileEditHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.FileEditHelp.Location = new System.Drawing.Point(0, 0);
            this.FileEditHelp.Name = "FileEditHelp";
            this.FileEditHelp.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.FileEditHelp.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.FileEditHelp.Size = new System.Drawing.Size(800, 30);
            this.FileEditHelp.TabIndex = 11;
            this.FileEditHelp.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromAFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.File.Image = global::Project2.NameListResources.FileCabinetIcon;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(61, 28);
            this.File.Text = "File";
            // 
            // importFromAFileToolStripMenuItem
            // 
            this.importFromAFileToolStripMenuItem.Image = global::Project2.NameListResources.ImportFileIcon;
            this.importFromAFileToolStripMenuItem.Name = "importFromAFileToolStripMenuItem";
            this.importFromAFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.importFromAFileToolStripMenuItem.Text = "Import from a file";
            this.importFromAFileToolStripMenuItem.Click += new System.EventHandler(this.importFromAFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Image = global::Project2.NameListResources.SaveIcon;
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANameToTheListToolStripMenuItem,
            this.removeANameFromTheListToolStripMenuItem});
            this.editToolStripMenuItem.Image = global::Project2.NameListResources.EditIcon;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(63, 28);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addANameToTheListToolStripMenuItem
            // 
            this.addANameToTheListToolStripMenuItem.Image = global::Project2.NameListResources.AddIcon;
            this.addANameToTheListToolStripMenuItem.Name = "addANameToTheListToolStripMenuItem";
            this.addANameToTheListToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addANameToTheListToolStripMenuItem.Text = "Add a Name to the List";
            this.addANameToTheListToolStripMenuItem.Click += new System.EventHandler(this.addANameToTheListToolStripMenuItem_Click);
            // 
            // removeANameFromTheListToolStripMenuItem
            // 
            this.removeANameFromTheListToolStripMenuItem.Image = global::Project2.NameListResources.RemoveIcon;
            this.removeANameFromTheListToolStripMenuItem.Name = "removeANameFromTheListToolStripMenuItem";
            this.removeANameFromTheListToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.removeANameFromTheListToolStripMenuItem.Text = "Remove a Name from the List";
            this.removeANameFromTheListToolStripMenuItem.Click += new System.EventHandler(this.removeANameFromTheListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsForUsingThisProgramToolStripMenuItem,
            this.aboutThisProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::Project2.NameListResources.HelpIcon;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsForUsingThisProgramToolStripMenuItem
            // 
            this.instructionsForUsingThisProgramToolStripMenuItem.Image = global::Project2.NameListResources.AboutIcon;
            this.instructionsForUsingThisProgramToolStripMenuItem.Name = "instructionsForUsingThisProgramToolStripMenuItem";
            this.instructionsForUsingThisProgramToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.instructionsForUsingThisProgramToolStripMenuItem.Text = "Instructions for using this program";
            this.instructionsForUsingThisProgramToolStripMenuItem.Click += new System.EventHandler(this.instructionsForUsingThisProgramToolStripMenuItem_Click);
            // 
            // aboutThisProgramToolStripMenuItem
            // 
            this.aboutThisProgramToolStripMenuItem.Image = global::Project2.NameListResources.InfoIcon;
            this.aboutThisProgramToolStripMenuItem.Name = "aboutThisProgramToolStripMenuItem";
            this.aboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.aboutThisProgramToolStripMenuItem.Text = "About this program";
            this.aboutThisProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutThisProgramToolStripMenuItem_Click);
            // 
            // SelectedNameLabel
            // 
            this.SelectedNameLabel.AutoSize = true;
            this.SelectedNameLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedNameLabel.Name = "SelectedNameLabel";
            this.SelectedNameLabel.Size = new System.Drawing.Size(80, 13);
            this.SelectedNameLabel.TabIndex = 12;
            this.SelectedNameLabel.Text = "Selected Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.SelectedNameLabel);
            this.panel1.Controls.Add(this.SuffixLabel);
            this.panel1.Controls.Add(this.Suffix);
            this.panel1.Controls.Add(this.LastNameLabel);
            this.panel1.Controls.Add(this.RestOfNameLabel);
            this.panel1.Controls.Add(this.OriginalNameLabel);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.OriginalName);
            this.panel1.Controls.Add(this.RestOfName);
            this.panel1.Location = new System.Drawing.Point(381, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 342);
            this.panel1.TabIndex = 13;
            // 
            // AmountOfNamesInList
            // 
            this.AmountOfNamesInList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AmountOfNamesInList.Name = "AmountOfNamesInList";
            this.AmountOfNamesInList.Size = new System.Drawing.Size(81, 17);
            this.AmountOfNamesInList.Text = "Names in List:";
            // 
            // NamesInListAndCurrentTime
            // 
            this.NamesInListAndCurrentTime.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NamesInListAndCurrentTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AmountOfNamesInList,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.CurrentTime});
            this.NamesInListAndCurrentTime.Location = new System.Drawing.Point(0, 428);
            this.NamesInListAndCurrentTime.Name = "NamesInListAndCurrentTime";
            this.NamesInListAndCurrentTime.Size = new System.Drawing.Size(800, 22);
            this.NamesInListAndCurrentTime.TabIndex = 16;
            this.NamesInListAndCurrentTime.Text = "statusStrip1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 17);
            // 
            // CurrentTime
            // 
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(673, 17);
            this.CurrentTime.Spring = true;
            this.CurrentTime.Text = "Current Time";
            this.CurrentTime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // NameListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NamesInListAndCurrentTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LastNameFirstButton);
            this.Controls.Add(this.List);
            this.Controls.Add(this.FileEditHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.FileEditHelp;
            this.Name = "NameListForm";
            this.Text = "NameListManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NameListForm_FormClosing);
            this.Load += new System.EventHandler(this.NameListForm_Load);
            this.FileEditHelp.ResumeLayout(false);
            this.FileEditHelp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NamesInListAndCurrentTime.ResumeLayout(false);
            this.NamesInListAndCurrentTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.TextBox OriginalName;
        private System.Windows.Forms.TextBox RestOfName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Suffix;
        private System.Windows.Forms.Button LastNameFirstButton;
        private System.Windows.Forms.Label SuffixLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label RestOfNameLabel;
        private System.Windows.Forms.Label OriginalNameLabel;
        private System.Windows.Forms.MenuStrip FileEditHelp;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem importFromAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANameToTheListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeANameFromTheListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsForUsingThisProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisProgramToolStripMenuItem;
        private System.Windows.Forms.Label SelectedNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel AmountOfNamesInList;
        private System.Windows.Forms.StatusStrip NamesInListAndCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel CurrentTime;
        private System.Windows.Forms.Timer Timer;
    }
}

