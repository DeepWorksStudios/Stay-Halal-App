using Stay_Halal.MVVM.Model;
using System;
using System.Collections.Generic;
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
            InhaltsstoffModel[] inhaltsstoffeTabak= new InhaltsstoffModel[] { new InhaltsstoffModel() { Name="Nicotin",Type=Inhalt_Type.Haram}};
            ProductModel tabak = new ProductModel() { Barcode = "42425304",Hersteller="Pueblo" ,Title="Pueblo Dreh Tabak",Inhaltsstoffe=inhaltsstoffeTabak };

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
