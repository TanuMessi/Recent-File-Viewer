namespace RecentFileViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButton_Zip = new System.Windows.Forms.RadioButton();
            this.radioButton_Recent = new System.Windows.Forms.RadioButton();
            this.button_Action = new System.Windows.Forms.Button();
            this.dataGridView_Recent = new System.Windows.Forms.DataGridView();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Zip = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Zip = new System.Windows.Forms.Button();
            this.textBox_Browse = new System.Windows.Forms.TextBox();
            this.button_Browse = new System.Windows.Forms.Button();
            this.button_Refresh_Grid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recent)).BeginInit();
            this.groupBox_Zip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_Zip
            // 
            this.radioButton_Zip.AutoSize = true;
            this.radioButton_Zip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Zip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_Zip.Image = ((System.Drawing.Image)(resources.GetObject("radioButton_Zip.Image")));
            this.radioButton_Zip.Location = new System.Drawing.Point(50, 39);
            this.radioButton_Zip.Name = "radioButton_Zip";
            this.radioButton_Zip.Size = new System.Drawing.Size(142, 128);
            this.radioButton_Zip.TabIndex = 0;
            this.radioButton_Zip.TabStop = true;
            this.radioButton_Zip.UseVisualStyleBackColor = true;
            this.radioButton_Zip.CheckedChanged += new System.EventHandler(this.radioButton_Zip_CheckedChanged);
            // 
            // radioButton_Recent
            // 
            this.radioButton_Recent.AutoSize = true;
            this.radioButton_Recent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Recent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_Recent.Image = ((System.Drawing.Image)(resources.GetObject("radioButton_Recent.Image")));
            this.radioButton_Recent.Location = new System.Drawing.Point(40, 234);
            this.radioButton_Recent.Name = "radioButton_Recent";
            this.radioButton_Recent.Size = new System.Drawing.Size(142, 128);
            this.radioButton_Recent.TabIndex = 1;
            this.radioButton_Recent.TabStop = true;
            this.radioButton_Recent.UseVisualStyleBackColor = true;
            this.radioButton_Recent.CheckedChanged += new System.EventHandler(this.radioButton_Recent_CheckedChanged);
            // 
            // button_Action
            // 
            this.button_Action.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Action.BackColor = System.Drawing.Color.Snow;
            this.button_Action.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Action.Location = new System.Drawing.Point(623, 365);
            this.button_Action.Name = "button_Action";
            this.button_Action.Size = new System.Drawing.Size(172, 38);
            this.button_Action.TabIndex = 2;
            this.button_Action.Text = "Go to Action";
            this.button_Action.UseVisualStyleBackColor = false;
            this.button_Action.Visible = false;
            this.button_Action.Click += new System.EventHandler(this.button_Action_Click);
            // 
            // dataGridView_Recent
            // 
            this.dataGridView_Recent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Recent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Recent.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView_Recent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Recent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Name,
            this.Column_Date,
            this.Column_Type,
            this.Column_Size});
            this.dataGridView_Recent.Location = new System.Drawing.Point(268, 58);
            this.dataGridView_Recent.Name = "dataGridView_Recent";
            this.dataGridView_Recent.Size = new System.Drawing.Size(527, 283);
            this.dataGridView_Recent.TabIndex = 3;
            this.dataGridView_Recent.Visible = false;
            this.dataGridView_Recent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Recent_CellContentClick);
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_Date
            // 
            this.Column_Date.HeaderText = "Date modified";
            this.Column_Date.Name = "Column_Date";
            // 
            // Column_Type
            // 
            this.Column_Type.HeaderText = "Type";
            this.Column_Type.Name = "Column_Type";
            // 
            // Column_Size
            // 
            this.Column_Size.HeaderText = "Size";
            this.Column_Size.Name = "Column_Size";
            // 
            // groupBox_Zip
            // 
            this.groupBox_Zip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Zip.BackColor = System.Drawing.Color.Linen;
            this.groupBox_Zip.Controls.Add(this.pictureBox1);
            this.groupBox_Zip.Controls.Add(this.button_Refresh);
            this.groupBox_Zip.Controls.Add(this.button_Zip);
            this.groupBox_Zip.Controls.Add(this.textBox_Browse);
            this.groupBox_Zip.Controls.Add(this.button_Browse);
            this.groupBox_Zip.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Zip.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox_Zip.Location = new System.Drawing.Point(268, 58);
            this.groupBox_Zip.Name = "groupBox_Zip";
            this.groupBox_Zip.Size = new System.Drawing.Size(527, 283);
            this.groupBox_Zip.TabIndex = 4;
            this.groupBox_Zip.TabStop = false;
            this.groupBox_Zip.Text = "Zip";
            this.groupBox_Zip.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 140);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Refresh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_Refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Refresh.Location = new System.Drawing.Point(400, 227);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(103, 32);
            this.button_Refresh.TabIndex = 3;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Zip
            // 
            this.button_Zip.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Zip.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_Zip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Zip.Location = new System.Drawing.Point(294, 227);
            this.button_Zip.Name = "button_Zip";
            this.button_Zip.Size = new System.Drawing.Size(83, 32);
            this.button_Zip.TabIndex = 2;
            this.button_Zip.Text = "Zip";
            this.button_Zip.UseVisualStyleBackColor = false;
            // 
            // textBox_Browse
            // 
            this.textBox_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Browse.Location = new System.Drawing.Point(24, 158);
            this.textBox_Browse.Name = "textBox_Browse";
            this.textBox_Browse.Size = new System.Drawing.Size(353, 29);
            this.textBox_Browse.TabIndex = 1;
            // 
            // button_Browse
            // 
            this.button_Browse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Browse.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Browse.Location = new System.Drawing.Point(400, 158);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(103, 29);
            this.button_Browse.TabIndex = 0;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = false;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // button_Refresh_Grid
            // 
            this.button_Refresh_Grid.BackColor = System.Drawing.Color.Snow;
            this.button_Refresh_Grid.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh_Grid.Location = new System.Drawing.Point(453, 365);
            this.button_Refresh_Grid.Name = "button_Refresh_Grid";
            this.button_Refresh_Grid.Size = new System.Drawing.Size(130, 38);
            this.button_Refresh_Grid.TabIndex = 5;
            this.button_Refresh_Grid.Text = "Refresh";
            this.button_Refresh_Grid.UseVisualStyleBackColor = false;
            this.button_Refresh_Grid.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(838, 467);
            this.Controls.Add(this.button_Refresh_Grid);
            this.Controls.Add(this.groupBox_Zip);
            this.Controls.Add(this.dataGridView_Recent);
            this.Controls.Add(this.button_Action);
            this.Controls.Add(this.radioButton_Recent);
            this.Controls.Add(this.radioButton_Zip);
            this.Name = "Form1";
            this.Text = "RFVZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Recent)).EndInit();
            this.groupBox_Zip.ResumeLayout(false);
            this.groupBox_Zip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Zip;
        private System.Windows.Forms.RadioButton radioButton_Recent;
        private System.Windows.Forms.Button button_Action;
        private System.Windows.Forms.DataGridView dataGridView_Recent;
        private System.Windows.Forms.GroupBox groupBox_Zip;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Zip;
        private System.Windows.Forms.TextBox textBox_Browse;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Size;
        private System.Windows.Forms.Button button_Refresh_Grid;
    }
}

