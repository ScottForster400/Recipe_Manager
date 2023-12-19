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
    partial class frmRecipie : Form
    {
        Recipe selectedRecipe;

        public frmRecipie(Recipe tempRecipe) // takes in selected Recipie so the form can generate with information from the recipie
        {
            InitializeComponent();
            selectedRecipe = tempRecipe;

        }

        private void frmRecipie_Load(object sender, EventArgs e)
        {
            lblRecipieName.Text = selectedRecipe.GetRecipieName().Trim();
            lblServingSize.Text = $"Serving Size: {selectedRecipe.GetServingSize()}";
            lblCookTime.Text = $"Cook Time: {selectedRecipe.GetCookTime()}";
            pbRecipieImage.Image = selectedRecipe.GetImg();
            foreach (Item ingriedient in selectedRecipe.GetIngridients())
            {
                lbIngriedients.Items.Add(ingriedient.GetFormattedIngriedient());
            }
            foreach (string step in selectedRecipe.GetSteps())
            {
                txtSteps.Text = txtSteps.Text + $"\r\n\r\n{step}"; // need \r\n as this returns carriage then adds a new line i have added 2 as I think it looks better formatted this way
            }
            btnBack.Select();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Dispose();//chose to use dispose as it fully deletes from freeing memory
        }

        //key press(esc to exit form)
        private void lbIngriedients_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
            }
        }

        private void txtSteps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001b')
            {
                Close();
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
