namespace Coureswork_form_2
{
    partial class frmRecipieFinder
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
            panel2 = new Panel();
            panel1 = new Panel();
            btnAddToList = new Button();
            lblRecipieName = new LinkLabel();
            lblServingSize = new Label();
            lblCookTime = new Label();
            lbIngriedients = new ListBox();
            pbRecipieImage = new PictureBox();
            panel3 = new Panel();
            label9 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            label1 = new Label();
            btnSearch = new Button();
            btnAddIngriedient = new Button();
            label8 = new Label();
            txtAddIngriedient = new TextBox();
            lbOwnedIngriedients = new ListBox();
            lbRecipies = new ListBox();
            btnBack = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRecipieImage).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1, 23);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(45);
            panel2.Size = new Size(980, 630);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 58, 64);
            panel1.Controls.Add(btnAddToList);
            panel1.Controls.Add(lblRecipieName);
            panel1.Controls.Add(lblServingSize);
            panel1.Controls.Add(lblCookTime);
            panel1.Controls.Add(lbIngriedients);
            panel1.Controls.Add(pbRecipieImage);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(514, 45);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25, 25, 0, 0);
            panel1.Size = new Size(421, 540);
            panel1.TabIndex = 4;
            // 
            // btnAddToList
            // 
            btnAddToList.BackColor = Color.FromArgb(115, 64, 34);
            btnAddToList.FlatStyle = FlatStyle.Popup;
            btnAddToList.ForeColor = Color.FromArgb(13, 13, 13);
            btnAddToList.Location = new Point(147, 475);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(127, 55);
            btnAddToList.TabIndex = 14;
            btnAddToList.Text = "Add Ingriedients to Shopping List";
            btnAddToList.UseVisualStyleBackColor = false;
            btnAddToList.Click += btnAddToList_Click;
            // 
            // lblRecipieName
            // 
            lblRecipieName.AutoSize = true;
            lblRecipieName.Location = new Point(219, 25);
            lblRecipieName.Name = "lblRecipieName";
            lblRecipieName.Size = new Size(102, 20);
            lblRecipieName.TabIndex = 8;
            lblRecipieName.TabStop = true;
            lblRecipieName.Text = "Recipie Name";
            lblRecipieName.LinkClicked += lblRecipieName_LinkClicked;
            // 
            // lblServingSize
            // 
            lblServingSize.AutoSize = true;
            lblServingSize.ForeColor = Color.FromArgb(217, 168, 126);
            lblServingSize.Location = new Point(219, 125);
            lblServingSize.Name = "lblServingSize";
            lblServingSize.Size = new Size(89, 20);
            lblServingSize.TabIndex = 7;
            lblServingSize.Text = "Serving Size";
            // 
            // lblCookTime
            // 
            lblCookTime.AutoSize = true;
            lblCookTime.ForeColor = Color.FromArgb(217, 168, 126);
            lblCookTime.Location = new Point(219, 73);
            lblCookTime.Name = "lblCookTime";
            lblCookTime.Size = new Size(80, 20);
            lblCookTime.TabIndex = 6;
            lblCookTime.Text = "Cook Time";
            // 
            // lbIngriedients
            // 
            lbIngriedients.BackColor = Color.FromArgb(64, 58, 64);
            lbIngriedients.BorderStyle = BorderStyle.None;
            lbIngriedients.ForeColor = Color.FromArgb(217, 168, 126);
            lbIngriedients.FormattingEnabled = true;
            lbIngriedients.ItemHeight = 20;
            lbIngriedients.Location = new Point(25, 161);
            lbIngriedients.Name = "lbIngriedients";
            lbIngriedients.Size = new Size(369, 300);
            lbIngriedients.TabIndex = 4;
            lbIngriedients.KeyPress += lbIngriedients_KeyPress;
            // 
            // pbRecipieImage
            // 
            pbRecipieImage.BackColor = Color.FromArgb(217, 168, 126);
            pbRecipieImage.Location = new Point(25, 25);
            pbRecipieImage.Name = "pbRecipieImage";
            pbRecipieImage.Size = new Size(120, 120);
            pbRecipieImage.TabIndex = 0;
            pbRecipieImage.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 58, 64);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(btnAddIngriedient);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtAddIngriedient);
            panel3.Controls.Add(lbOwnedIngriedients);
            panel3.Controls.Add(lbRecipies);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(45, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 540);
            panel3.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(217, 168, 126);
            label9.Location = new Point(142, 2);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 10;
            label9.Text = "Owned Ingriedients";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(115, 64, 34);
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.ForeColor = Color.FromArgb(13, 13, 13);
            btnClear.Location = new Point(245, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 27);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.KeyPress += btnClear_KeyPress;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(115, 64, 34);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = Color.FromArgb(13, 13, 13);
            btnDelete.Location = new Point(37, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 27);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.KeyPress += btnDelete_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(217, 168, 126);
            label1.Location = new Point(25, 308);
            label1.Name = "label1";
            label1.Size = new Size(371, 20);
            label1.TabIndex = 23;
            label1.Text = "Recipies containing searched ingriedients(Most - least)";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(115, 64, 34);
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.ForeColor = Color.FromArgb(13, 13, 13);
            btnSearch.Location = new Point(245, 226);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 27);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.KeyPress += btnSearch_KeyPress;
            // 
            // btnAddIngriedient
            // 
            btnAddIngriedient.BackColor = Color.FromArgb(115, 64, 34);
            btnAddIngriedient.FlatStyle = FlatStyle.Popup;
            btnAddIngriedient.ForeColor = Color.FromArgb(13, 13, 13);
            btnAddIngriedient.Location = new Point(37, 226);
            btnAddIngriedient.Name = "btnAddIngriedient";
            btnAddIngriedient.Size = new Size(127, 27);
            btnAddIngriedient.TabIndex = 21;
            btnAddIngriedient.Text = "Add Ingriedient";
            btnAddIngriedient.UseVisualStyleBackColor = false;
            btnAddIngriedient.Click += btnAddIngriedient_Click;
            btnAddIngriedient.KeyPress += btnAddIngriedient_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(217, 168, 126);
            label8.Location = new Point(135, 170);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 20;
            label8.Text = "Owned Ingriedient";
            // 
            // txtAddIngriedient
            // 
            txtAddIngriedient.BackColor = Color.FromArgb(89, 79, 88);
            txtAddIngriedient.BorderStyle = BorderStyle.FixedSingle;
            txtAddIngriedient.Location = new Point(135, 193);
            txtAddIngriedient.Name = "txtAddIngriedient";
            txtAddIngriedient.Size = new Size(132, 27);
            txtAddIngriedient.TabIndex = 7;
            txtAddIngriedient.KeyDown += txtAddIngriedient_KeyDown;
            txtAddIngriedient.KeyPress += txtAddIngriedient_KeyPress;
            // 
            // lbOwnedIngriedients
            // 
            lbOwnedIngriedients.BackColor = Color.FromArgb(89, 79, 88);
            lbOwnedIngriedients.BorderStyle = BorderStyle.FixedSingle;
            lbOwnedIngriedients.ForeColor = Color.FromArgb(217, 168, 126);
            lbOwnedIngriedients.FormattingEnabled = true;
            lbOwnedIngriedients.ItemHeight = 20;
            lbOwnedIngriedients.Location = new Point(25, 25);
            lbOwnedIngriedients.Name = "lbOwnedIngriedients";
            lbOwnedIngriedients.Size = new Size(371, 142);
            lbOwnedIngriedients.TabIndex = 6;
            lbOwnedIngriedients.KeyDown += lbOwnedIngriedients_KeyDown;
            lbOwnedIngriedients.KeyPress += lbOwnedIngriedients_KeyPress;
            // 
            // lbRecipies
            // 
            lbRecipies.BackColor = Color.FromArgb(64, 58, 64);
            lbRecipies.BorderStyle = BorderStyle.None;
            lbRecipies.ForeColor = Color.FromArgb(217, 168, 126);
            lbRecipies.FormattingEnabled = true;
            lbRecipies.ItemHeight = 20;
            lbRecipies.Location = new Point(25, 331);
            lbRecipies.Name = "lbRecipies";
            lbRecipies.Size = new Size(371, 180);
            lbRecipies.TabIndex = 5;
            lbRecipies.SelectedIndexChanged += lbRecipies_SelectedIndexChanged;
            lbRecipies.KeyPress += lbRecipies_KeyPress;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(115, 64, 34);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.ForeColor = Color.FromArgb(13, 13, 13);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(71, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmRecipieFinder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 79, 88);
            ClientSize = new Size(982, 653);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmRecipieFinder";
            Text = "Recipie Finder";
            Load += frmRecipieFinder_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRecipieImage).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ListBox lbRecipies;
        private Panel panel1;
        private Button btnAddToList;
        private LinkLabel lblRecipieName;
        private Label lblServingSize;
        private Label lblCookTime;
        private ListBox lbIngriedients;
        private PictureBox pbRecipieImage;
        private Panel panel3;
        private ListBox lbOwnedIngriedients;
        private TextBox txtAddIngriedient;
        private Label label1;
        private Button btnSearch;
        private Button btnAddIngriedient;
        private Label label8;
        private Button btnClear;
        private Button btnDelete;
        private Button btnBack;
        private Label label9;
    }
}