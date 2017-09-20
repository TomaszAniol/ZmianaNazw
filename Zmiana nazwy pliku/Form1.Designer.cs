namespace Zmiana_nazwy_pliku
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
            this.openButton = new System.Windows.Forms.Button();
            this.changFileButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.changeProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 64);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(154, 65);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Otwórz folder";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // changFileButton
            // 
            this.changFileButton.Location = new System.Drawing.Point(171, 64);
            this.changFileButton.Name = "changFileButton";
            this.changFileButton.Size = new System.Drawing.Size(154, 65);
            this.changFileButton.TabIndex = 1;
            this.changFileButton.Text = "Stwórz nazwy";
            this.changFileButton.UseVisualStyleBackColor = true;
            this.changFileButton.Click += new System.EventHandler(this.changFileButton_Click);
            // 
            // changeProgress
            // 
            this.changeProgress.Location = new System.Drawing.Point(12, 35);
            this.changeProgress.Name = "changeProgress";
            this.changeProgress.Size = new System.Drawing.Size(313, 23);
            this.changeProgress.Step = 1;
            this.changeProgress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Progres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeProgress);
            this.Controls.Add(this.changFileButton);
            this.Controls.Add(this.openButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zmiana nazwy pliku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button changFileButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar changeProgress;
        private System.Windows.Forms.Label label1;
    }
}

