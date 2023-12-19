namespace Coureswork_form_2
{
    partial class frmRecipieBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnAddToList = new Button();
            lblRecipieName = new LinkLabel();
            lblServingSize = new Label();
            lblCookTime = new Label();
            lbIngriedients = new ListBox();
            pbRecipieImage = new PictureBox();
            lbRecipies = new ListBox();
            label9 = new Label();
            panel2 = new Panel();
            btnRecpieBrowser = new Button();
            btnShoppingList = new Button();
            btnRecipieFinder = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRecipieImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            btnAddToList.BackgroundImageLayout = ImageLayout.None;
            btnAddToList.CausesValidation = false;
            btnAddToList.FlatStyle = FlatStyle.Popup;
            btnAddToList.Location = new Point(147, 475);
            btnAddToList.Margin = new Padding(0);
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
            lblRecipieName.LinkClicked += lblRecipieName_LinkClicked_1;
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
            lblCookTime.BackColor = Color.FromArgb(64, 58, 64);
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
            // lbRecipies
            // 
            lbRecipies.BackColor = Color.FromArgb(64, 58, 64);
            lbRecipies.BorderStyle = BorderStyle.None;
            lbRecipies.Dock = DockStyle.Left;
            lbRecipies.ForeColor = Color.FromArgb(217, 168, 126);
            lbRecipies.FormattingEnabled = true;
            lbRecipies.ItemHeight = 20;
            lbRecipies.Location = new Point(45, 45);
            lbRecipies.Name = "lbRecipies";
            lbRecipies.Size = new Size(400, 540);
            lbRecipies.TabIndex = 5;
            lbRecipies.SelectedIndexChanged += lbRecipies_SelectedIndexChanged_1;
            lbRecipies.KeyPress += lbRecipies_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(217, 168, 126);
            label9.Location = new Point(45, 22);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 10;
            label9.Text = "Recipies";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(89, 79, 88);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lbRecipies);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(1, 24);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(45);
            panel2.Size = new Size(980, 630);
            panel2.TabIndex = 5;
            // 
            // btnRecpieBrowser
            // 
            btnRecpieBrowser.BackColor = Color.FromArgb(89, 79, 88);
            btnRecpieBrowser.FlatAppearance.BorderSize = 0;
            btnRecpieBrowser.FlatStyle = FlatStyle.Flat;
            btnRecpieBrowser.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecpieBrowser.Location = new Point(0, 0);
            btnRecpieBrowser.Name = "btnRecpieBrowser";
            btnRecpieBrowser.Size = new Size(94, 48);
            btnRecpieBrowser.TabIndex = 6;
            btnRecpieBrowser.Text = "Recipie Browser";
            btnRecpieBrowser.UseVisualStyleBackColor = false;
            btnRecpieBrowser.KeyPress += btnRecpieBrowser_KeyPress;
            // 
            // btnShoppingList
            // 
            btnShoppingList.BackColor = Color.FromArgb(64, 58, 64);
            btnShoppingList.FlatAppearance.BorderSize = 0;
            btnShoppingList.FlatStyle = FlatStyle.Flat;
            btnShoppingList.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnShoppingList.Location = new Point(91, 0);
            btnShoppingList.Name = "btnShoppingList";
            btnShoppingList.Size = new Size(94, 48);
            btnShoppingList.TabIndex = 7;
            btnShoppingList.Text = "Shopping List";
            btnShoppingList.UseVisualStyleBackColor = false;
            btnShoppingList.Click += btnShoppingList_Click_1;
            btnShoppingList.KeyPress += btnShoppingList_KeyPress;
            // 
            // btnRecipieFinder
            // 
            btnRecipieFinder.BackColor = Color.FromArgb(64, 58, 64);
            btnRecipieFinder.FlatAppearance.BorderSize = 0;
            btnRecipieFinder.FlatStyle = FlatStyle.Flat;
            btnRecipieFinder.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipieFinder.Location = new Point(183, 0);
            btnRecipieFinder.Name = "btnRecipieFinder";
            btnRecipieFinder.Size = new Size(94, 48);
            btnRecipieFinder.TabIndex = 8;
            btnRecipieFinder.Text = "Recipie Finder";
            btnRecipieFinder.UseVisualStyleBackColor = false;
            btnRecipieFinder.Click += btnRecpieFinder_Click;
            btnRecipieFinder.KeyPress += btnRecipieFinder_KeyPress;
            // 
            // frmRecipieBrowser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 79, 88);
            ClientSize = new Size(982, 653);
            Controls.Add(btnRecipieFinder);
            Controls.Add(btnShoppingList);
            Controls.Add(btnRecpieBrowser);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmRecipieBrowser";
            Text = "Recipie Browser";
            Load += frmRecipieBrowser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRecipieImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MenuStrip msUniversalMenu;
        private ToolStripMenuItem recipieViewerToolStripMenuItem;
        private ToolStripMenuItem shoppingListToolStripMenuItem;
        private ToolStripMenuItem recipieFinderToolStripMenuItem;
        private Panel panel1;
        private Button btnAddToList;
        private LinkLabel lblRecipieName;
        private Label lblServingSize;
        private Label lblCookTime;
        private ListBox lbIngriedients;
        private PictureBox pbRecipieImage;
        private ListBox lbRecipies;
        private Label label9;
        private Panel panel2;
        private Button btnRecpieBrowser;
        private Button btnShoppingList;
        private Button btnRecipieFinder;
    }
}