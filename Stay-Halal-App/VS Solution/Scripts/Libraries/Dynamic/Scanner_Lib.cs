using Stay_Halal.MVVM.Model;
using Stay_Halal.MVVM.View;
using Stay_Halal.Scripts.Libraries.Static;

namespace Stay_Halal.Scripts.Libraries.Dynamic;

public class Scanner_Lib
{
    #region Private Data
    private readonly DB_Lib db;
    #endregion

    #region Constructor/Destructor
    public Scanner_Lib(DB_Lib _db) { db = _db; }
    #endregion

    #region Public Calls
    public void ScanProdukt(string id)
    {
        Device.BeginInvokeOnMainThread(async () =>
        {
            string route;
            Dictionary<string, object> parameters;
            ProductModel detail = db.GetProdukt(id);

            if (string.IsNullOrEmpty(id)|| string.IsNullOrWhiteSpace(id))
            {
               

                route = $"//MainMenu/MainMenuView/{nameof(MessagePage)}";
                parameters = new() { ["Model"] = Resources_Lib.NoInput };

                await Shell.Current.GoToAsync(route, parameters);
                return;
            }

            if (detail == null)
            {
              

                route = $"//MainMenu/MainMenuView/{nameof(MessagePage)}";
                parameters = new() { ["Model"] = Resources_Lib.ScannerFail };
                await Shell.Current.GoToAsync(route, parameters);
                return;
            }

            route = $"//MainMenu/MainMenuView/{nameof(ProductDetailView)}";
            parameters = new() { ["Model"] = detail };
            
            await Shell.Current.GoToAsync(route, parameters);
            

        });
    }
    #endregion
}
