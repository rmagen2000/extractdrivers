namespace ExtractDrivers
{
    partial class FrmMain
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
            this.fldBro = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(12, 20);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(185, 25);
            this.btnSelDir.TabIndex = 0;
            this.btnSelDir.Text = "Select directory to store drivers";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path.ForeColor = System.Drawing.Color.Red;
            this.path.Location = new System.Drawing.Point(20, 57);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(279, 20);
            this.path.TabIndex = 1;
            this.path.Text = "No directory for saving drivers selected";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(203, 20);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 25);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Go";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 92);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(583, 312);
            this.output.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 416);
            this.Controls.Add(this.output);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.path);
            this.Controls.Add(this.btnSelDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows drivers Backup - Extractor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fldBro;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox output;
    }
}

