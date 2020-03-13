namespace CaesarCypherCracker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbEncryptedFilePath = new System.Windows.Forms.TextBox();
            this.btnChooseEncryptedFile = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnStartDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypted File Location:";
            // 
            // tbEncryptedFilePath
            // 
            this.tbEncryptedFilePath.Enabled = false;
            this.tbEncryptedFilePath.Location = new System.Drawing.Point(148, 23);
            this.tbEncryptedFilePath.Name = "tbEncryptedFilePath";
            this.tbEncryptedFilePath.Size = new System.Drawing.Size(240, 20);
            this.tbEncryptedFilePath.TabIndex = 1;
            // 
            // btnChooseEncryptedFile
            // 
            this.btnChooseEncryptedFile.Location = new System.Drawing.Point(394, 23);
            this.btnChooseEncryptedFile.Name = "btnChooseEncryptedFile";
            this.btnChooseEncryptedFile.Size = new System.Drawing.Size(30, 20);
            this.btnChooseEncryptedFile.TabIndex = 2;
            this.btnChooseEncryptedFile.Text = "...";
            this.btnChooseEncryptedFile.UseVisualStyleBackColor = true;
            this.btnChooseEncryptedFile.Click += new System.EventHandler(this.BtnChooseEncryptedFile_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(24, 68);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(570, 240);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // btnStartDecrypt
            // 
            this.btnStartDecrypt.Location = new System.Drawing.Point(279, 343);
            this.btnStartDecrypt.Name = "btnStartDecrypt";
            this.btnStartDecrypt.Size = new System.Drawing.Size(85, 25);
            this.btnStartDecrypt.TabIndex = 4;
            this.btnStartDecrypt.Text = "Start Cracking";
            this.btnStartDecrypt.UseVisualStyleBackColor = true;
            this.btnStartDecrypt.Click += new System.EventHandler(this.BtnStartDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.btnStartDecrypt);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnChooseEncryptedFile);
            this.Controls.Add(this.tbEncryptedFilePath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEncryptedFilePath;
        private System.Windows.Forms.Button btnChooseEncryptedFile;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnStartDecrypt;
    }
}

