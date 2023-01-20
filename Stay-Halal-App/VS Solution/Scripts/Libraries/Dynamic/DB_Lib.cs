
using Stay_Halal.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stay_Halal.Scripts.Libraries.Dynamic
{
    public class DB_Lib
    {
        private List<ProductModel> producte= new List<ProductModel>();

      
        public DB_Lib() 
        {
            CreateTestData();
        }

        void CreateTestData()
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


            ProductModel tabak = new ProductModel()
            {
                Barcode = "42425304",
                Hersteller = "Pueblo",
                Title = "Pueblo Dreh Tabak",
                Inhaltsstoffe = inhaltsstoffeTabak
            };

            

         
            ProductModel haribo = new ProductModel()
            {
                Barcode = "4001686315101",
                Hersteller = "Haribo",
                Title = "Happy Cola",
                Inhaltsstoffe = inhaltsstoffeHaribo
            };
    

            ProductModel milka = new ProductModel()
            {
                Barcode = "7622400004483",
                Hersteller = "Milka",
                Title = "Tender",
                Inhaltsstoffe = inhaltsstoffeAlk
            };

          
            ProductModel milka2 = new ProductModel()
            {
                Barcode = "7622200003938",
                Hersteller = "Milka",
                Title = "Milkinis",
                Inhaltsstoffe = inhaltsstoffeMager
            };

            ProductModel erdnuss = new ProductModel()
            {
                Barcode = "4337256170949",
                Hersteller = "The Snack & Nut Company GmbH",
                Title = "Erdnüsse",
                Inhaltsstoffe = inhaltsstoffeErdnuss
            };

            producte.Add(erdnuss);
            producte.Add(milka2);
            producte.Add(milka);
            producte.Add(haribo);       
            producte.Add(tabak);

        }


        public ProductModel GetProduct(string id)
        {
            for(int i=0;i<producte.Count;i++)
            {
                if (string.Equals(producte[i].Barcode,id))
                {
                    return producte[i];
                }
            }

            return null;
        }
    }
}
