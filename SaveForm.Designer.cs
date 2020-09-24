namespace Project2
{
    partial class SaveForm
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
            this.SaveLabel = new System.Windows.Forms.Label();
            this.YesSaveButton = new System.Windows.Forms.Button();
            this.NoSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLabel.Location = new System.Drawing.Point(27, 69);
            this.SaveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(472, 20);
            this.SaveLabel.TabIndex = 0;
            this.SaveLabel.Text = "You Have unsaved changes would you like to save before exiting?";
            this.SaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YesSaveButton
            // 
            this.YesSaveButton.Location = new System.Drawing.Point(95, 118);
            this.YesSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YesSaveButton.Name = "YesSaveButton";
            this.YesSaveButton.Size = new System.Drawing.Size(50, 24);
            this.YesSaveButton.TabIndex = 1;
            this.YesSaveButton.Text = "YES";
            this.YesSaveButton.UseVisualStyleBackColor = true;
            this.YesSaveButton.Click += new System.EventHandler(this.YesSaveButton_Click);
            // 
            // NoSaveButton
            // 
            this.NoSaveButton.Location = new System.Drawing.Point(352, 118);
            this.NoSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoSaveButton.Name = "NoSaveButton";
            this.NoSaveButton.Size = new System.Drawing.Size(50, 24);
            this.NoSaveButton.TabIndex = 2;
            this.NoSaveButton.Text = "NO";
            this.NoSaveButton.UseVisualStyleBackColor = true;
            this.NoSaveButton.Click += new System.EventHandler(this.NoSaveButton_Click);
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 155);
            this.Controls.Add(this.NoSaveButton);
            this.Controls.Add(this.YesSaveButton);
            this.Controls.Add(this.SaveLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SaveForm";
            this.Text = "Do you want to save?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Button YesSaveButton;
        private System.Windows.Forms.Button NoSaveButton;
    }
}