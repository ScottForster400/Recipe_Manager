using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Recipies
{
    public List<Recipe>  listOfRecipies;
    string path = "Recipies.txt";

    public void InitialiseRecipies()
    {
        listOfRecipies = new List<Recipe>();
    }
    public void SaveList()
    {
        if(File.Exists(path))
        {
            string allRecipiesFormatted = FormatAllRecipies();
            File.AppendAllText(path, allRecipiesFormatted);
        }
       
    }
    public void addRecipe(string selectedName,List<Item> selectedItems, List<string>selecetdSteps,string selecetdServingSize, string selectedImgLink, string selectedCookTime)
    {
        Recipe tempRecipie = new Recipe(selectedName,selectedItems, selecetdSteps, selecetdServingSize,selectedImgLink,selectedCookTime);
        listOfRecipies.Add(tempRecipie);

    }
    public void OpenList()
    {
        if (File.Exists(path))
        {
            string recipieName;
            List<string> ingriedientsString;
            List<string> stepsList;
            string servingSize;
            string imgLink;
            string cookTime;
            string unsortedRecipiesString = File.ReadAllText(path).Trim();
            List<string> unsortedRecipiesList = unsortedRecipiesString.Split(";").ToList();
            unsortedRecipiesList.RemoveAt(unsortedRecipiesList.Count - 1);

            for (int i = 0; i < unsortedRecipiesList.Count; i = i + 6)
            {
                recipieName = unsortedRecipiesList[i];
                ingriedientsString = unsortedRecipiesList[i + 1].Split(",").ToList();
                stepsList = unsortedRecipiesList[i + 2].Split(",").ToList();
                servingSize = unsortedRecipiesList[i + 3];
                imgLink = unsortedRecipiesList[i + 4];
                cookTime = unsortedRecipiesList[i + 5];
                ingriedientsString.RemoveAt(ingriedientsString.Count - 1);
                stepsList.RemoveAt(stepsList.Count - 1);
                List<Item> ingriedientsObj = CreateIngriedientsObjList(ingriedientsString);
                Recipe recipie1 = new Recipe(recipieName, ingriedientsObj, stepsList, servingSize, imgLink, cookTime);
                listOfRecipies.Add(recipie1);
            }
        }
    }
    public void ClearList()
    {
        listOfRecipies.Clear();
    }
    private List<Item> CreateIngriedientsObjList(List<string>itemDetails)
    {
        List<Item> createdIngrdients = new List<Item>();
        for (int i = 0; i < itemDetails.Count; i = i + 4)
        {
            Item itemTemp = new Item(itemDetails[i], itemDetails[i + 1], itemDetails[i+3]);
            if (itemDetails[i + 2].ToLower() == "true")
            {
                itemTemp.ItemBeenGot();
            }
            createdIngrdients.Add(itemTemp);
        }
        return createdIngrdients;
    }
    public string FormatAllRecipies()
    {
        string formattedRecipies = "";
        foreach(Recipe recipie in listOfRecipies)
        {
           formattedRecipies=formattedRecipies+recipie.GetFormatedForFile();
        }
        return formattedRecipies;
    }
   public List<Recipe> GetAllRecipies()
    {
        return listOfRecipies;
    }
    public List<Recipe> FindRecipiesFromIngriedients(List<string> enteredIngriedients)
    {
        List<Recipe> matchingRecipies = new List<Recipe>();
        int numberOfMatchingIngriedients =0;
        int freeSpacePointer = 0;//need this to know where the next free space in array is
        int[,] matchingIngriedientsRecipieStore = new int[listOfRecipies.Count, 2]; //Learned how to make and manipulate 2d arrays from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays
        for (int i = 0; i < listOfRecipies.Count; i++)
        {
            List<Item> recipieIngriedients = listOfRecipies[i].GetIngridients();
            foreach (Item ingriedient in recipieIngriedients)
            {
                if (enteredIngriedients.Contains(ingriedient.GetName()) == true)
                {
                    numberOfMatchingIngriedients = numberOfMatchingIngriedients + 1;
                }
            }
            if (numberOfMatchingIngriedients >= 3)
            {
                matchingIngriedientsRecipieStore[freeSpacePointer, 0] = i;
                matchingIngriedientsRecipieStore[freeSpacePointer, 1] = numberOfMatchingIngriedients;
                freeSpacePointer=freeSpacePointer+1;
            }
            numberOfMatchingIngriedients = 0;
        }
        if (freeSpacePointer - 1 > 0)//stops the sorting algoritm getting stuck in a infinite loop if not enough matching recipies are found
        {
            bool swapMade = true;
            while (swapMade == true)//This allows loop to be broken if no swaps made saving time and processing as bubble soot would continue until every value checked
            {
                for (int i = 0; i < freeSpacePointer - 1; i++)//Used bubble sort algorithm to sort the array into decending order of matching ingriedients
                {
                    swapMade = false;

                    if (matchingIngriedientsRecipieStore[i, 1] < matchingIngriedientsRecipieStore[i + 1, 1])
                    {
                        int tempRecipieIndex = matchingIngriedientsRecipieStore[i + 1, 0];
                        int tempMatchingIngriedients = matchingIngriedientsRecipieStore[i + 1, 1];
                        matchingIngriedientsRecipieStore[i + 1, 0] = matchingIngriedientsRecipieStore[i, 0];
                        matchingIngriedientsRecipieStore[i + 1, 1] = matchingIngriedientsRecipieStore[i, 1];
                        matchingIngriedientsRecipieStore[i, 0] = tempRecipieIndex;
                        matchingIngriedientsRecipieStore[i, 1] = tempMatchingIngriedients;
                        swapMade = true;
                    }
                }
            }
        }
        for(int i = 0; i<freeSpacePointer; i++)
        {
            matchingRecipies.Add(listOfRecipies[matchingIngriedientsRecipieStore[i,0]]);
        }
        return matchingRecipies;
    }
    

}
