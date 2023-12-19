class ShoppingList
{
    private List<Item> listOfItems;

    string path = "ShoppingList.txt";
    public void AddShopping(string item, string amount,string measurement)
    {

        foreach (Item listedItem in listOfItems)
        {
            if (listedItem.GetName() == item)
            {
                if(amount == "")
                {
                    amount = "1";
                }
                listedItem.IncreaseAmount(Convert.ToSingle(amount));
                return;
            }
            else
            {
                Item item1 = new Item(item,amount,measurement);
                listOfItems.Add(item1);
                return;
            }
        }
        Item item2 = new Item(item,amount,measurement);
        listOfItems.Add(item2);
    }
    public void RemoveShopping(int index)
    {
        listOfItems.RemoveAt(index);
    }
    public void CheckOff(string item)
    {

        for (int i = 0; i < listOfItems.Count; i++)
        {
            if (listOfItems[i].GetName() == item)
            {
                listOfItems[i].ItemBeenGot();
            };

        };
    }
    
    public void initialiseList()
    {
        listOfItems = new();
    }
    public void SaveList()
    {
        int count = listOfItems.Count;
        string fileData = "";
        if(count == 0)
        {
            ClearFile();
        }
        else
        {
            foreach(Item item in listOfItems)
            {
                fileData= fileData + item.GetDataForSaveFile();
            }
            if(File.Exists(path))
            {  
                File.WriteAllText(path,fileData);
            }
        }
        
    }
    public void OpenList()
    {
        if (File.Exists(path))
        {
            string contents = File.ReadAllText(path).Trim();
            List<string> itemDetails = contents.Split(",").ToList();
            itemDetails.RemoveAt(itemDetails.Count - 1);//needed as the formatting adds an empty index at last index
            for (int i = 0; i < itemDetails.Count; i = i + 4)
            {
                Item itemTemp = new Item(itemDetails[i], itemDetails[i + 1], itemDetails[i + 3]);
                if (itemDetails[i + 2].ToLower() == "true")
                {
                    itemTemp.ItemBeenGot();
                }
                listOfItems.Add(itemTemp);
            }
        }
    }
    public void ClearListObj()
    {
        listOfItems.Clear();
    }
    public List<Item> GetItems()
    {
        return listOfItems;
    }
    
    public List<string> GetAllItemsNames() // allows items form shooping list to be used in recipie search
    {
        List<string> itemNames = new List<string>();
        foreach(Item item in listOfItems)
        {
            itemNames.Add(item.GetName());
        }
        return itemNames;
    }
    public void AddRecipeIngriedients(Item ingriedient)
    {
        listOfItems.Add(ingriedient);
    }
    public void ClearFile()
    {
        if (File.Exists(path))
        {
            File.WriteAllText(path, "");
        }
    }
}
