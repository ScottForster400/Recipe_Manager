using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 class Recipe
{
    private string recipieName;
    private List<Item> ingriedients;
    private List<string> Steps;
    private string servingSize;
    private Image img;
    private string cookTime;

    public Recipe(string selectedName, List<Item> selcetedIngridients, List<string> selectedSteps, string selctedServingSize,string selectedImgLink, string selectedCookTime)
    {
        recipieName = selectedName;
        ingriedients = selcetedIngridients;
        Steps = selectedSteps;
        servingSize = selctedServingSize;
        img = Image.FromFile(selectedImgLink);
        cookTime = selectedCookTime;
    }
     public List<Item> GetIngridients()
    {
        return ingriedients;
    }
    public List<string> GetSteps()
    {
        return Steps;
    }
    public string GetServingSize()
    {
        return servingSize;
    }
    public Image GetImg()
    {
        return img;
    }
    public string GetCookTime()
    {
        return cookTime;
    }
    public string GetFormatedForFile()
    {
        string formatedString = "";
        formatedString = formatedString + $"{recipieName};";
        foreach (Item item in ingriedients)
        {
            formatedString = formatedString + $"{item.GetDataForSaveFile()}";
        }
        formatedString = formatedString + ";";
        foreach (string step in Steps)
        {
            formatedString = formatedString + $"{step},";
        }
        formatedString = formatedString + ";";
        formatedString = formatedString + $"{servingSize};";
        return formatedString;
    }
     public void AddToShoppingList(ShoppingList shoppingList)
    {
        foreach (Item item in ingriedients)
        {
            shoppingList.AddShopping(item.GetName(), Convert.ToString(item.GetAmount()), item.GetMeasurement());
        }
    }
    public string GetRecipieName()
    {
        return recipieName;
    }
    public List<string> GetAllIngriedientsNames() //gets names of ingriedients in recipe allowing for meal packs to be made
    {
        List<string> itemNames = new List<string>();
        foreach (Item item in ingriedients)
        {
            itemNames.Add(item.GetName());
        }
        return itemNames;
    }
}