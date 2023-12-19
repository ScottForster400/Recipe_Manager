namespace Coureswork_form_2
{
    partial class frmRecipieBrowser : Form
    {
        Recipies recipeList = new Recipies();
        ShoppingList shoppingList = new ShoppingList();
        frmShoppingList frmShoppingList_;
        frmRecipieFinder frmRecipieFinder_;

        public frmRecipieBrowser(Recipies selectedRecipies, ShoppingList selectedShoppingList)
        {
            InitializeComponent();
            recipeList = selectedRecipies;
            shoppingList = selectedShoppingList;
        }

        private void frmRecipieBrowser_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            foreach (Recipe recipe in recipeList.GetAllRecipies())
            {
                lbRecipies.Items.Add(recipe.GetRecipieName());
            }
            lbRecipies.SelectedIndex = 0;
            lbRecipies.Select();
            frmShoppingList_ = new frmShoppingList(shoppingList, recipeList);
            frmRecipieFinder_ = new frmRecipieFinder(recipeList, shoppingList);
        }



        private void lbRecipies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbIngriedients.Items.Clear();
            int selctedIndex = lbRecipies.SelectedIndex;
            List<Recipe> recipes = recipeList.GetAllRecipies();
            lblRecipieName.Text = recipes[selctedIndex].GetRecipieName().Trim(); // need to trim as the recipies have a blank new line above due to file format
            lblServingSize.Text = $"Serving Size: {recipes[selctedIndex].GetServingSize()}";
            lblCookTime.Text = $"Cook Time: {recipes[selctedIndex].GetCookTime()}";
            pbRecipieImage.Image = recipes[selctedIndex].GetImg();
            foreach (Item ingriedient in recipes[selctedIndex].GetIngridients())
            {
                lbIngriedients.Items.Add(ingriedient.GetFormattedIngriedient()); // gets all item info then displays in good format - save repeated code
            }
        }

        private void lblRecipieName_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbRecipies.SelectedIndex > -1)
            {
                frmRecipie frmRecipie = new frmRecipie(recipeList.GetAllRecipies()[lbRecipies.SelectedIndex]);
                Hide();
                frmRecipie.ShowDialog();
                Show();
            }
        }

        private void btnShoppingList_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmShoppingList_.ShowDialog();
            shoppingList.ClearFile();
            shoppingList.SaveList();
            Show();
        }

        private void btnRecpieFinder_Click(object sender, EventArgs e)
        {
            Hide();
            frmRecipieFinder_.ShowDialog();
            Show();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbRecipies.SelectedIndex;
            if (selectedIndex != -1) // checks if no item is selected
            {
                foreach (Item ingriedient in recipeList.GetAllRecipies()[selectedIndex].GetIngridients())
                {
                    shoppingList.AddRecipeIngriedients(ingriedient);
                }
                shoppingList.SaveList(); // added this incase they closed the application withouth opening the shoppinglist to save
            }
        }

        //key press events
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

        private void lbIngriedients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnRecpieBrowser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnShoppingList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void btnRecipieFinder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }
    }
}
