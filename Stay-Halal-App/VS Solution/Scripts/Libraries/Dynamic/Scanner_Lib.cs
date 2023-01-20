using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.View;
using Stay_Halal.Scripts.Libraries.Static;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.QrCode.Internal;

namespace Stay_Halal.Scripts.Libraries.Dynamic;

public class Scanner_Lib
{
    private DB_Lib db;

    public Scanner_Lib(DB_Lib _db) { db = _db; }

    public void ScanProduct(string input)
    {
        Debug.WriteLine(input);

        Device.BeginInvokeOnMainThread(async () =>
        {

            ProductModel detail = db.GetProduct(input);


            string route;
            Dictionary<string, object> parameters;

            if (detail == null)
            {
                System.Diagnostics.Debug.WriteLine("no product");

                route = $"{nameof(MessagePage)}";
                parameters = new() { ["Model"] = Resources_Lib.ScannerFail };

            }

            else
            {

                System.Diagnostics.Debug.WriteLine("got product");

                route = $"//MainMenu/MainMenuView/{nameof(ProductDetailView)}";
                parameters = new() { ["Model"] = detail };
            }

            await Shell.Current.GoToAsync(route, parameters);
        });
    }
}
