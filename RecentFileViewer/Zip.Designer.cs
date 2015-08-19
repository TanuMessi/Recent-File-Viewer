namespace RecentFileViewer
{
    partial class Zip
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
            this.button_Zip = new System.Windows.Forms.Button();
            this.label_Archive = new System.Windows.Forms.Label();
            this.textBox_Archive = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Zip
            // 
            this.button_Zip.Location = new System.Drawing.Point(288, 165);
            this.button_Zip.Name = "button_Zip";
            this.button_Zip.Size = new System.Drawing.Size(107, 37);
            this.button_Zip.TabIndex = 0;
            this.button_Zip.Text = "Zip";
            this.button_Zip.UseVisualStyleBackColor = true;
            // 
            // label_Archive
            // 
            this.label_Archive.AutoSize = true;
            this.label_Archive.Location = new System.Drawing.Point(97, 49);
            this.label_Archive.Name = "label_Archive";
            this.label_Archive.Size = new System.Drawing.Size(74, 13);
            this.label_Archive.TabIndex = 1;
            this.label_Archive.Text = "Archive Name";
            // 
            // textBox_Archive
            // 
            this.textBox_Archive.Location = new System.Drawing.Point(100, 102);
            this.textBox_Archive.Name = "textBox_Archive";
            this.textBox_Archive.Size = new System.Drawing.Size(295, 20);
            this.textBox_Archive.TabIndex = 2;
            // 
            // Zip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 261);
            this.Controls.Add(this.textBox_Archive);
            this.Controls.Add(this.label_Archive);
            this.Controls.Add(this.button_Zip);
            this.Name = "Zip";
            this.Text = "Zip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Zip;
        private System.Windows.Forms.Label label_Archive;
        private System.Windows.Forms.TextBox textBox_Archive;
    }
}