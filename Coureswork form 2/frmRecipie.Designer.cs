namespace Coureswork_form_2
{
    partial class frmRecipie
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
            panel1 = new Panel();
            lblRecipieName = new Label();
            lblServingSize = new Label();
            lblCookTime = new Label();
            lbIngriedients = new ListBox();
            pbRecipieImage = new PictureBox();
            txtSteps = new TextBox();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRecipieImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 58, 64);
            panel1.Controls.Add(lblRecipieName);
            panel1.Controls.Add(lblServingSize);
            panel1.Controls.Add(lblCookTime);
            panel1.Controls.Add(lbIngriedients);
            panel1.Controls.Add(pbRecipieImage);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(50, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25, 25, 0, 0);
            panel1.Size = new Size(421, 553);
            panel1.TabIndex = 5;
            // 
            // lblRecipieName
            // 
            lblRecipieName.AutoSize = true;
            lblRecipieName.ForeColor = Color.FromArgb(217, 168, 126);
            lblRecipieName.Location = new Point(194, 25);
            lblRecipieName.Name = "lblRecipieName";
            lblRecipieName.Size = new Size(102, 20);
            lblRecipieName.TabIndex = 11;
            lblRecipieName.Text = "Recipie Name";
            // 
            // lblServingSize
            // 
            lblServingSize.AutoSize = true;
            lblServingSize.ForeColor = Color.FromArgb(217, 168, 126);
            lblServingSize.Location = new Point(194, 125);
            lblServingSize.Name = "lblServingSize";
            lblServingSize.Size = new Size(89, 20);
            lblServingSize.TabIndex = 10;
            lblServingSize.Text = "Serving Size";
            // 
            // lblCookTime
            // 
            lblCookTime.AutoSize = true;
            lblCookTime.BackColor = Color.FromArgb(64, 58, 64);
            lblCookTime.ForeColor = Color.FromArgb(217, 168, 126);
            lblCookTime.Location = new Point(194, 75);
            lblCookTime.Name = "lblCookTime";
            lblCookTime.Size = new Size(80, 20);
            lblCookTime.TabIndex = 9;
            lblCookTime.Text = "Cook Time";
            // 
            // lbIngriedients
            // 
            lbIngriedients.BackColor = Color.FromArgb(64, 58, 64);
            lbIngriedients.BorderStyle = BorderStyle.None;
            lbIngriedients.ForeColor = Color.FromArgb(217, 168, 126);
            lbIngriedients.FormattingEnabled = true;
            lbIngriedients.ItemHeight = 20;
            lbIngriedients.Location = new Point(25, 170);
            lbIngriedients.Name = "lbIngriedients";
            lbIngriedients.Size = new Size(369, 360);
            lbIngriedients.TabIndex = 4;
            lbIngriedients.KeyPress += lbIngriedients_KeyPress;
            // 
            // pbRecipieImage
            // 
            pbRecipieImage.BackColor = SystemColors.Info;
            pbRecipieImage.Location = new Point(25, 25);
            pbRecipieImage.Name = "pbRecipieImage";
            pbRecipieImage.Size = new Size(120, 120);
            pbRecipieImage.TabIndex = 0;
            pbRecipieImage.TabStop = false;
            // 
            // txtSteps
            // 
            txtSteps.BackColor = Color.FromArgb(64, 58, 64);
            txtSteps.BorderStyle = BorderStyle.None;
            txtSteps.Dock = DockStyle.Right;
            txtSteps.ForeColor = Color.FromArgb(217, 168, 126);
            txtSteps.Location = new Point(511, 50);
            txtSteps.Margin = new Padding(0);
            txtSteps.Multiline = true;
            txtSteps.Name = "txtSteps";
            txtSteps.ReadOnly = true;
            txtSteps.ScrollBars = ScrollBars.Vertical;
            txtSteps.Size = new Size(421, 553);
            txtSteps.TabIndex = 6;
            txtSteps.Text = "Steps:";
            txtSteps.KeyPress += txtSteps_KeyPress;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(115, 64, 34);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(13, 13, 13);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(71, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            btnBack.KeyPress += btnBack_KeyPress;
            // 
            // frmRecipie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 79, 88);
            ClientSize = new Size(982, 653);
            Controls.Add(btnBack);
            Controls.Add(txtSteps);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmRecipie";
            Padding = new Padding(50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipie";
            Load += frmRecipie_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRecipieImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListBox lbIngriedients;
        private PictureBox pbRecipieImage;
        private Label lblServingSize;
        private Label lblCookTime;
        private Label lblRecipieName;
        private TextBox txtSteps;
        private Button btnBack;
    }
}