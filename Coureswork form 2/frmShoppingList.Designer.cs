namespace Coureswork_form_2
{
    partial class frmShoppingList
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
            label11 = new Label();
            lbShoppingList = new ListBox();
            panel1 = new Panel();
            label9 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            btnMarkOff = new Button();
            btnClearList = new Button();
            label5 = new Label();
            label6 = new Label();
            txtItemUnits = new TextBox();
            txtItemAmount = new TextBox();
            label7 = new Label();
            txtItemName = new TextBox();
            label8 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClearAddItemText = new Button();
            btnAddItem = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAddItemUnit = new TextBox();
            txtAddItemAmount = new TextBox();
            txtAddItemName = new TextBox();
            btnBack = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lbShoppingList);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(1, 23);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(45);
            panel2.Size = new Size(980, 630);
            panel2.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(217, 168, 126);
            label11.Location = new Point(45, 22);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 10;
            label11.Text = "Shoppping List";
            // 
            // lbShoppingList
            // 
            lbShoppingList.BackColor = Color.FromArgb(64, 58, 64);
            lbShoppingList.BorderStyle = BorderStyle.FixedSingle;
            lbShoppingList.Dock = DockStyle.Left;
            lbShoppingList.ForeColor = Color.FromArgb(217, 168, 126);
            lbShoppingList.FormattingEnabled = true;
            lbShoppingList.ItemHeight = 20;
            lbShoppingList.Location = new Point(45, 45);
            lbShoppingList.Name = "lbShoppingList";
            lbShoppingList.Size = new Size(400, 540);
            lbShoppingList.TabIndex = 5;
            lbShoppingList.SelectedIndexChanged += lbShoppingList_SelectedIndexChanged;
            lbShoppingList.KeyDown += lbShoppingList_KeyDown;
            lbShoppingList.KeyPress += lbShoppingList_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 58, 64);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnClearAddItemText);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAddItemUnit);
            panel1.Controls.Add(txtAddItemAmount);
            panel1.Controls.Add(txtAddItemName);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(514, 45);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25, 25, 0, 0);
            panel1.Size = new Size(421, 540);
            panel1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(217, 168, 126);
            label9.Location = new Point(286, 283);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 9;
            label9.Text = "Item Adder";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 58, 64);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnMarkOff);
            panel3.Controls.Add(btnClearList);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtItemUnits);
            panel3.Controls.Add(txtItemAmount);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtItemName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(421, 280);
            panel3.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(217, 168, 126);
            label10.Location = new Point(168, 5);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 16;
            label10.Text = "Item Editor";
            // 
            // btnMarkOff
            // 
            btnMarkOff.BackColor = Color.FromArgb(115, 64, 34);
            btnMarkOff.FlatStyle = FlatStyle.Popup;
            btnMarkOff.Location = new Point(267, 232);
            btnMarkOff.Name = "btnMarkOff";
            btnMarkOff.Size = new Size(127, 26);
            btnMarkOff.TabIndex = 25;
            btnMarkOff.Text = "Mark Off";
            btnMarkOff.UseVisualStyleBackColor = false;
            btnMarkOff.Click += btnMarkOff_Click;
            btnMarkOff.KeyPress += btnMarkOff_KeyPress;
            // 
            // btnClearList
            // 
            btnClearList.BackColor = Color.FromArgb(115, 64, 34);
            btnClearList.FlatStyle = FlatStyle.Popup;
            btnClearList.Location = new Point(28, 232);
            btnClearList.Name = "btnClearList";
            btnClearList.Size = new Size(127, 26);
            btnClearList.TabIndex = 24;
            btnClearList.Text = "Clear List";
            btnClearList.UseVisualStyleBackColor = false;
            btnClearList.Click += btnClearList_Click;
            btnClearList.KeyPress += btnClearList_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(217, 168, 126);
            label5.Location = new Point(149, 78);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 22;
            label5.Text = "units(ml,g)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 161);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 21;
            // 
            // txtItemUnits
            // 
            txtItemUnits.BackColor = Color.FromArgb(89, 79, 88);
            txtItemUnits.BorderStyle = BorderStyle.FixedSingle;
            txtItemUnits.Location = new Point(149, 101);
            txtItemUnits.Name = "txtItemUnits";
            txtItemUnits.Size = new Size(125, 27);
            txtItemUnits.TabIndex = 18;
            txtItemUnits.KeyDown += txtItemUnits_KeyDown;
            txtItemUnits.KeyPress += txtItemUnits_KeyPress;
            // 
            // txtItemAmount
            // 
            txtItemAmount.BackColor = Color.FromArgb(89, 79, 88);
            txtItemAmount.BorderStyle = BorderStyle.FixedSingle;
            txtItemAmount.Location = new Point(269, 28);
            txtItemAmount.Name = "txtItemAmount";
            txtItemAmount.Size = new Size(125, 27);
            txtItemAmount.TabIndex = 17;
            txtItemAmount.KeyDown += txtItemAmount_KeyDown;
            txtItemAmount.KeyPress += txtItemAmount_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(217, 168, 126);
            label7.Location = new Point(269, 5);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 20;
            label7.Text = "Amount";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.FromArgb(89, 79, 88);
            txtItemName.BorderStyle = BorderStyle.FixedSingle;
            txtItemName.Location = new Point(28, 28);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(125, 27);
            txtItemName.TabIndex = 16;
            txtItemName.KeyDown += txtItemName_KeyDown;
            txtItemName.KeyPress += txtItemName_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(217, 168, 126);
            label8.Location = new Point(28, 5);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 19;
            label8.Text = "Item";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(115, 64, 34);
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(267, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 26);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.KeyPress += btnDelete_KeyPress;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(115, 64, 34);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(28, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 26);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            btnUpdate.KeyPress += btnUpdate_KeyPress;
            // 
            // btnClearAddItemText
            // 
            btnClearAddItemText.BackColor = Color.FromArgb(115, 64, 34);
            btnClearAddItemText.FlatStyle = FlatStyle.Popup;
            btnClearAddItemText.Location = new Point(267, 429);
            btnClearAddItemText.Name = "btnClearAddItemText";
            btnClearAddItemText.Size = new Size(127, 55);
            btnClearAddItemText.TabIndex = 14;
            btnClearAddItemText.Text = "Clear";
            btnClearAddItemText.UseVisualStyleBackColor = false;
            btnClearAddItemText.Click += btnClearAddItemText_Click;
            btnClearAddItemText.KeyDown += btnClearAddItemText_KeyDown;
            btnClearAddItemText.KeyPress += btnClearAddItemText_KeyPress;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(115, 64, 34);
            btnAddItem.FlatAppearance.BorderColor = Color.FromArgb(115, 64, 34);
            btnAddItem.FlatStyle = FlatStyle.Popup;
            btnAddItem.Location = new Point(267, 333);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(127, 55);
            btnAddItem.TabIndex = 13;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            btnAddItem.KeyDown += btnAddItem_KeyDown;
            btnAddItem.KeyPress += btnAddItem_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(217, 168, 126);
            label4.Location = new Point(25, 489);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 12;
            label4.Text = "units(ml,g):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 429);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(217, 168, 126);
            label2.Location = new Point(28, 397);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 10;
            label2.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(217, 168, 126);
            label1.Location = new Point(28, 303);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 9;
            label1.Text = "Item:";
            // 
            // txtAddItemUnit
            // 
            txtAddItemUnit.BackColor = Color.FromArgb(89, 79, 88);
            txtAddItemUnit.BorderStyle = BorderStyle.FixedSingle;
            txtAddItemUnit.Location = new Point(107, 489);
            txtAddItemUnit.Name = "txtAddItemUnit";
            txtAddItemUnit.Size = new Size(125, 27);
            txtAddItemUnit.TabIndex = 8;
            txtAddItemUnit.KeyDown += txtAddItemUnit_KeyDown;
            txtAddItemUnit.KeyPress += txtAddItemUnit_KeyPress;
            // 
            // txtAddItemAmount
            // 
            txtAddItemAmount.BackColor = Color.FromArgb(89, 79, 88);
            txtAddItemAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAddItemAmount.Location = new Point(107, 394);
            txtAddItemAmount.Name = "txtAddItemAmount";
            txtAddItemAmount.Size = new Size(125, 27);
            txtAddItemAmount.TabIndex = 7;
            txtAddItemAmount.KeyDown += txtAddItemAmount_KeyDown;
            txtAddItemAmount.KeyPress += txtAddItemAmount_KeyPress;
            // 
            // txtAddItemName
            // 
            txtAddItemName.BackColor = Color.FromArgb(89, 79, 88);
            txtAddItemName.BorderStyle = BorderStyle.FixedSingle;
            txtAddItemName.Location = new Point(107, 300);
            txtAddItemName.Name = "txtAddItemName";
            txtAddItemName.Size = new Size(125, 27);
            txtAddItemName.TabIndex = 5;
            txtAddItemName.KeyDown += txtAddItemName_KeyDown_1;
            txtAddItemName.KeyPress += txtAddItemName_KeyPress;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(115, 64, 34);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(71, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "<- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            btnBack.KeyPress += btnBack_KeyPress;
            // 
            // frmShoppingList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 79, 88);
            ClientSize = new Size(982, 653);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmShoppingList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopping List";
            Load += frmShoppingList_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ListBox lbShoppingList;
        private Panel panel1;
        private TextBox txtAddItemUnit;
        private TextBox txtAddItemAmount;
        private TextBox txtAddItemName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClearAddItemText;
        private Button btnAddItem;
        private Label label5;
        private Label label6;
        private TextBox txtItemUnits;
        private TextBox txtItemAmount;
        private TextBox txtItemName;
        private Label label7;
        private Label label8;
        private Button btnClearList;
        private Button btnMarkOff;
        private Button btnBack;
        private Label label9;
        private Label label11;
        private Label label10;
    }
}