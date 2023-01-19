

using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Static;


namespace Stay_Halal.Scripts.Libraries.Dynamic;

public class Setting_Lib
{

    #region Private Data
    private SettingModel setting_Data;
    private bool hasKey = false;
    #endregion

    #region Public Data
    public SettingModel Setting_Data { get { return setting_Data; } }
    public bool HasKey { get { return hasKey; } }
    public Updated_Settings updated_Settings;
    #endregion

    #region Constructor/Destructor
    public Setting_Lib()
    {
     

        hasKey = Preferences.ContainsKey("sh_first");
        setting_Data = Setting_Lib.Get_Preferences();
        Change_Settings(setting_Data);   
    }
    #endregion

    #region Public Calls
    public void Comfirm_Key()
    {
        hasKey = true;
        Preferences.Default.Set("fp_first", true);
    }
    public void Change_Settings(SettingModel _data)
    {
        setting_Data.DataCaching = _data.DataCaching;
        setting_Data.Theme = _data.Theme;
        Application.Current.UserAppTheme = _data.Theme;

        Setting_Lib.Set_Preferences(setting_Data);
        updated_Settings?.Invoke(setting_Data);
    }

    #endregion

    #region Private Calls
    private static void Set_Preferences(SettingModel setting_Data)
    {
        Preferences.Default.Set("sh_datacache", setting_Data.DataCaching);    
        Preferences.Default.Set("sh_theme", (int)setting_Data.Theme);
    }
    private static SettingModel Get_Preferences()
    {
        SettingModel settingModel = new();
        settingModel.DataCaching = Preferences.Get("sh_datacache", true);
        settingModel.Theme = (AppTheme)Preferences.Get("sh_theme", 0);
        return settingModel;
    }
    #endregion
}