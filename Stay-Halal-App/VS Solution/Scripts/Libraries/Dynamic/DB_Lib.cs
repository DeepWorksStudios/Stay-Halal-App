
using Stay_Halal.MVVM.Model;


namespace Stay_Halal.Scripts.Libraries.Dynamic;

public class DB_Lib
{
    #region Private Data
    private readonly List<ProductModel> Produkte = new();
    #endregion

    #region Constructor
    public DB_Lib()
    {
        CreateTestData();

        //Init DB Connection
        //Fetch Data 
        //Populate List
    }
    #endregion

    #region Public Calls
    public ProductModel GetProdukt(string id)
    {
        for (int i = 0; i < Produkte.Count; i++)
        {
            if (string.Equals(Produkte[i].Barcode, id))
            {
                return Produkte[i];
            }
        }

        return null;
    }
    #endregion

    #region Private Calls
    private void CreateTestData()
    {
      

        InhaltsstoffModel[] inhaltsstoffeTabak = new InhaltsstoffModel[] 
        { 
            new InhaltsstoffModel() { Name = "Nicotin", Type = Inhalt_Type.Haram },
            new InhaltsstoffModel() { Name = "Teer", Type = Inhalt_Type.Haram }
        };

        InhaltsstoffModel[] inhaltsstoffeAlk = new InhaltsstoffModel[]
        {
            new InhaltsstoffModel() { Name = "Alkohol", Type = Inhalt_Type.Haram },
            new InhaltsstoffModel() { Name = "Weizenmehl", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Magermilchpulver", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Milchfett", Type = Inhalt_Type.Halal },
        };
        InhaltsstoffModel[] inhaltsstoffeMager = new InhaltsstoffModel[]
        {
            new InhaltsstoffModel() { Name = "Magermilchpulver", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Buttereinfett", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Haselnüsse", Type = Inhalt_Type.Halal }
        };


        InhaltsstoffModel[] inhaltsstoffeErdnuss = new InhaltsstoffModel[]
        {
            new InhaltsstoffModel() { Name = "Kartoffelstärke", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Weizenmehl", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Schalenfrüchte", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Gewürze", Type = Inhalt_Type.Halal }
        };

        InhaltsstoffModel[] inhaltsstoffeHaribo = new InhaltsstoffModel[]
        {
            new InhaltsstoffModel() { Name = "Gelatine", Type = Inhalt_Type.Haram },
            new InhaltsstoffModel() { Name = "Glukosesirup", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Zucker", Type = Inhalt_Type.Halal },
            new InhaltsstoffModel() { Name = "Bienenwachs", Type = Inhalt_Type.Halal }
        };


        ProductModel tabak = new()
        {
            Barcode = "42425304",
            Hersteller = "Pueblo",
            Title = "Pueblo Dreh Tabak",
            Inhaltsstoffe = inhaltsstoffeTabak
        };

        

     
        ProductModel haribo = new()
        {
            Barcode = "4001686315101",
            Hersteller = "Haribo",
            Title = "Happy Cola",
            Inhaltsstoffe = inhaltsstoffeHaribo
        };


        ProductModel milka = new()
        {
            Barcode = "7622400004483",
            Hersteller = "Milka",
            Title = "Tender",
            Inhaltsstoffe = inhaltsstoffeAlk
        };

      
        ProductModel milka2 = new()
        {
            Barcode = "7622200003938",
            Hersteller = "Milka",
            Title = "Milkinis",
            Inhaltsstoffe = inhaltsstoffeMager
        };

        ProductModel erdnuss = new()
        {
            Barcode = "4337256170949",
            Hersteller = "The Snack & Nut Company GmbH",
            Title = "Erdnüsse",
            Inhaltsstoffe = inhaltsstoffeErdnuss
        };

        Produkte.Add(erdnuss);
        Produkte.Add(milka2);
        Produkte.Add(milka);
        Produkte.Add(haribo);       
        Produkte.Add(tabak);

    }
    #endregion
}
