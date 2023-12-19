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
    partial class frmRecipieFinder : Form
    {
        Recipies recipeList;
        List<Recipe> matchingRecipies;
        ShoppingList shoppingList;
        public frmRecipieFinder(Recipies selectedRecipies, ShoppingList selectedShoppingList)
        {
            InitializeComponent();
            recipeList = selectedRecipies;
            shoppingList = selectedShoppingList;
        }

        private void frmRecipieFinder_Load(object sender, EventArgs e)
        {
            txtAddIngriedient.Select();
        }

        private void btnAddIngriedient_Click(object sender, EventArgs e)
        {
            lbOwnedIngriedients.Items.Add(txtAddIngriedient.Text.Trim().ToLower()); //removes any empty space and converts to lower - needed as all infriedeints are stored in lower case - when searching need lowercase
            txtAddIngriedient.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbOwnedIngriedients.SelectedIndex;
            if (selectedIndex != -1)//checks if nothing selected
            {
                lbOwnedIngriedients.Items.RemoveAt(selectedIndex);
            }

            if (lbOwnedIngriedients.Items.Count > 0 && selectedIndex != -1)
            {
                lbOwnedIngriedients.SelectedIndex = selectedIndex - 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbOwnedIngriedients.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> inputtedIngriedients = new List<string>();
            foreach (string ingriedient in lbOwnedIngriedients.Items)
            {
                inputtedIngriedients.Add(ingriedient);
            }
            matchingRecipies = recipeList.FindRecipiesFromIngriedients(inputtedIngriedients);
            if (matchingRecipies.Count > 0)//stops it trying to add anything from an empty list
            {
                lbRecipies.Items.Clear();// needed else of search clicked again just adds to list box whilst keeping what else is in ther
                foreach (Recipe recipe in matchingRecipies)
                {
                    lbRecipies.Items.Add(recipe.GetRecipieName());
                }
            }


        }

        private void lbRecipies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbRecipies.SelectedIndex;
            lbIngriedients.Items.Clear();
            if (selectedIndex != -1)//stopd programe trying to fetch from an index that doesnt exist
            {
                lblRecipieName.Text = matchingRecipies[selectedIndex].GetRecipieName().Trim();
                lblCookTime.Text = $"Cook Time: {matchingRecipies[selectedIndex].GetCookTime()}";
                lblServingSize.Text = $"Serving Size: {matchingRecipies[selectedIndex].GetServingSize()}";
                pbRecipieImage.Image = matchingRecipies[selectedIndex].GetImg();

                foreach (Item ingriedient in matchingRecipies[selectedIndex].GetIngridients())
                {
                    lbIngriedients.Items.Add(ingriedient.GetFormattedIngriedient());
                }
            }
        }

        private void lblRecipieName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbRecipies.SelectedIndex > -1)
            {
                frmRecipie frmRecipie = new frmRecipie(recipeList.GetAllRecipies()[lbRecipies.SelectedIndex]);
                Hide();
                frmRecipie.ShowDialog();
                Show();
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbRecipies.SelectedIndex;
            if (selectedIndex != -1)
            {
                foreach (Item ingriedient in recipeList.GetAllRecipies()[selectedIndex].GetIngridients())
                {
                    shoppingList.AddRecipeIngriedients(ingriedient);
                }
                shoppingList.SaveList();
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }


        //key press events
        private void txtAddIngriedient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAddIngriedient_Click(sender, e);
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void txtAddIngriedient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                btnAddIngriedient.Select();
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (lbOwnedIngriedients.Items.Count > 0)
                {
                    lbOwnedIngriedients.Focus();
                    lbOwnedIngriedients.SelectedIndex = lbOwnedIngriedients.Items.Count - 1;
                }
            }
        }


        private void lbRecipies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (lbRecipies.SelectedIndex > -1)
                {
                    frmRecipie frmRecipie = new frmRecipie(recipeList.GetAllRecipies()[lbRecipies.SelectedIndex]);
                    Hide();
                    frmRecipie.ShowDialog();
                    Show();
                }
            }
            else if (e.KeyChar == '\u001b')
            {
                Close();
            }
            else if (e.KeyChar == 'a')
            {
                btnAddToList_Click(sender, e);
            }
        }


        //key press (esc for closing form)
        private void lbIngriedients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void lbOwnedIngriedients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
            else if (e.KeyChar == '\r')
            {
                btnSearch_Click(sender, e);
            }
            else if (e.KeyChar == 'c')
            {
                btnClear_Click(sender, e);
            }
            else if (e.KeyChar == 's')
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnAddIngriedient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnClear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void lbOwnedIngriedients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
            if (e.KeyCode == Keys.Down)
            {
                if (lbOwnedIngriedients.SelectedIndex == lbOwnedIngriedients.Items.Count - 1)
                {
                    txtAddIngriedient.Focus();
                }
            }
        }
    }
}
