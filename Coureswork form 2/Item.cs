class Item
{
    private string name;
    private float amount=1;
    private bool itemBeenGot = false;
    private string measurement = "NULL";

    public Item(string selectedName, string selectedAmount,string selectedMeasurement)  
    {
        name = selectedName;
        bool isInt = float.TryParse(selectedAmount, out float result); ;
        if (isInt == true)
        {
            amount = Convert.ToSingle(selectedAmount);
        }
        if(selectedMeasurement == "")
        {
            measurement = "NULL";
        }
        else
        {
            measurement = selectedMeasurement;
        }
        
    }
    public string GetName()
    {
        return name;
    }
    public float GetAmount() 
    { 
        return amount; 
    }
    public string GetMeasurement()
    {
        return measurement;
    }
    public void ItemBeenGot()
    {
        itemBeenGot = true;
    }
    public void IncreaseAmount(float increaseBy)
    {
        amount = amount + increaseBy;
    }
    public bool IsGot()
    {
        return itemBeenGot;
    }
    public string GetDataForSaveFile()
    {
        return $"{name},{amount},{itemBeenGot},{measurement},";
    }
    
    public string GetFormattedIngriedient()
    {
        if (GetMeasurement() == "NULL")
        {
            return $"{amount} {name}" ;
        }
        else
        {
            return $"{amount} {measurement} {name}";
        }
    }
    public string GetFormattedForList()
    {
        
        if (itemBeenGot == true)
        {
            if(GetMeasurement() == "NULL")
            {
                return $"[X] {name} {amount}";
            }
            else
            {
                return $"[X] {name} {amount} ({measurement})";
            }

        }
        else
        {
            if (GetMeasurement() == "NULL")
            {
                return $"[ ] {name} {amount}";
            }
            else
            {
                return $"[ ] {name} {amount} ({measurement})";
            }
        }
        
        
    }
    public void Update(string selectedName,string selectedAmount,string selecetdMeasurement)
    {
        name = selectedName;
        bool isInt = float.TryParse(selectedAmount, out amount);
        if (isInt == true)
        {
            amount = Convert.ToSingle(selectedAmount);
        }
        if(selecetdMeasurement != "")
        {
            measurement = selecetdMeasurement;
        }
    }

}