namespace AnimeManager
{
    partial class SettingMenu
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
            this.textBoxDefaultPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenFileDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxDefaultPath
            // 
            this.textBoxDefaultPath.Location = new System.Drawing.Point(111, 47);
            this.textBoxDefaultPath.Name = "textBoxDefaultPath";
            this.textBoxDefaultPath.Size = new System.Drawing.Size(104, 20);
            this.textBoxDefaultPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "General Setting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Default Directory";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonOpenFileDialog
            // 
            this.buttonOpenFileDialog.Location = new System.Drawing.Point(221, 47);
            this.buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            this.buttonOpenFileDialog.Size = new System.Drawing.Size(29, 20);
            this.buttonOpenFileDialog.TabIndex = 3;
            this.buttonOpenFileDialog.Text = "...";
            this.buttonOpenFileDialog.UseVisualStyleBackColor = true;
            this.buttonOpenFileDialog.Click += new System.EventHandler(this.buttonOpenFileDialog_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // SettingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenFileDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDefaultPath);
            this.Name = "SettingMenu";
            this.Text = "SettingMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDefaultPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}