namespace Coureswork_form_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // this is needed in order create recipie browser form on load as i need to pass in a recipies object and shopping list object
            // This allows me to pass between forms using the same variables
            Recipies recipesloadup = new Recipies();
            ShoppingList shoppingListloadup = new ShoppingList();
            recipesloadup.InitialiseRecipies();
            recipesloadup.OpenList();
            shoppingListloadup.initialiseList();
            shoppingListloadup.OpenList();

            frmRecipeBrowser frmRecipieBrowser = new frmRecipeBrowser(recipesloadup, shoppingListloadup);
           
            Application.Run(frmRecipieBrowser);
        }

        

        
            
    }

}
