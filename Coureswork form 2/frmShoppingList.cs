using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coureswork_form_2
{
    partial class frmShoppingList : Form
    {
        ShoppingList listOfShopping;
        Recipies recipies;
        public frmShoppingList(ShoppingList ShoppingList, Recipies selectedRecipies)
        {
            InitializeComponent();
            listOfShopping = ShoppingList;
            recipies = selectedRecipies;
        }

        private void frmShoppingList_Load(object sender, EventArgs e)
        {
            RefreshListBox();//needed in order to load information into shopping list list box - used refersh list box to save on code as refersh list box called in other functions
            if (listOfShopping.GetItems().Count > 0)
            {
                lbShoppingList.SelectedIndex = 0;
            }
        }

        private void lbShoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbShoppingList.SelectedIndex;
            if (selectedIndex > -1)
            {
                txtItemName.Text = listOfShopping.GetItems()[selectedIndex].GetName();
                txtItemAmount.Text = Convert.ToString(listOfShopping.GetItems()[selectedIndex].GetAmount());
                string measurement = listOfShopping.GetItems()[selectedIndex].GetMeasurement(); // stored as variable as it saves the data being fetched twice
                if (measurement != "NULL")
                {
                    txtItemUnits.Text = measurement;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbShoppingList.SelectedIndex;
            if (selectedIndex > -1)
            {
                listOfShopping.GetItems()[selectedIndex].Update(txtItemName.Text.Trim(), txtItemAmount.Text.Trim(), txtItemUnits.Text.Trim()); //trimmed incase they add extra blank space when typing
            }

            RefreshListBox();
            lbShoppingList.SelectedIndex = selectedIndex;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbShoppingList.SelectedIndex;
            if (selectedIndex > -1)
            {
                listOfShopping.RemoveShopping(selectedIndex);
            }
            ClearTextItemDetails();//clears details in the text box - saves accidentally updating an item with the old info
            RefreshListBox();
            if (lbShoppingList.Items.Count > 0 && selectedIndex != -1)
            {
                lbShoppingList.SelectedIndex = selectedIndex - 1;
            }

        }
        private void btnMarkOff_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbShoppingList.SelectedIndex;
            if (selectedIndex > -1)
            {
                listOfShopping.GetItems()[selectedIndex].ItemBeenGot();
            }
            RefreshListBox();
            lbShoppingList.SelectedIndex = selectedIndex;
        }
        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbShoppingList.Items.Clear();
            listOfShopping.ClearListObj();
            ClearTextItemDetails(); // stops information being diaplyed that isnt in list
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtAddItemName.Text != "")
            {
                listOfShopping.AddShopping(txtAddItemName.Text.Trim(), txtAddItemAmount.Text.Trim(), txtAddItemUnit.Text.Trim()); //trimmed incase they add extra blank space when typing
                RefreshListBox();
                ClearTextItemAdder(); // ease of use incase they want to add multiple items dont have to manually delete or click clear button















            }
        }
        private void btnClearAddItemText_Click(object sender, EventArgs e)
        {
            ClearTextItemAdder();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }



        //Form Functions
        public void RefreshListBox() // need this as .refresh() function is currently not working due to a bug in MS code
        {
            lbShoppingList.Items.Clear();
            foreach (Item item in listOfShopping.GetItems())
            {
                lbShoppingList.Items.Add(item.GetFormattedForList());
            }

        }
        public void ClearTextItemDetails()
        {
            txtItemAmount.Clear();
            txtItemUnits.Clear();
            txtItemName.Clear();

        }

        public void ClearTextItemAdder()
        {
            txtAddItemName.Clear();
            txtAddItemAmount.Clear();
            txtAddItemUnit.Clear();
        }


        //key press events

        private void txtAddItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // enter buttin allows item adding with enter
            {
                btnAddItem_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }
        private void txtAddItemAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAddItem_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void txtAddItemUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAddItem_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }


        private void txtAddItemName_KeyDown_1(object sender, KeyEventArgs e) //allows navigation of form usinf arrow keys
        {
            if (e.KeyCode == Keys.Down)
            {
                txtAddItemAmount.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnAddItem.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtItemUnits.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                lbShoppingList.Select();
            }
        }
        private void txtAddItemAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtAddItemUnit.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnAddItem.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtAddItemName.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                lbShoppingList.Select();
            }
        }
        private void txtAddItemUnit_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                btnClearAddItemText.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtAddItemAmount.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                lbShoppingList.Select();
            }
        }

        private void btnAddItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                btnClearAddItemText.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txtAddItemName.Focus();
            }
        }

        private void btnClearAddItemText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                btnAddItem.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txtAddItemAmount.Focus();
            }
        }


        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtItemUnits.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txtItemAmount.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                lbShoppingList.Select();
            }
        }

        private void txtItemAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtItemUnits.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                txtItemName.Focus();
            }
        }

        private void txtItemUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtItemName.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtAddItemName.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                lbShoppingList.Select();
            }
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnUpdate_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void txtItemAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnUpdate_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void txtItemUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnUpdate_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void lbShoppingList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnMarkOff_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
            else if (e.KeyChar == 'c')
            {
                btnClearList_Click(sender, e);
            }
        }

        private void btnUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnClearList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnMarkOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnAddItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnClearAddItemText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void lbShoppingList_KeyDown(object sender, KeyEventArgs e)// had to use for delete as key press doesnt recognise delete
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Right)
            {
                txtItemName.Focus();
            }
        }

        private void btnBack_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }
    }
}

