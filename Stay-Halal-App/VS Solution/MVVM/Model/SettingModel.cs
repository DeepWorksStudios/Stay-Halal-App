namespace Stay_Halal.MVVM.Model;

public enum Language { Deutsch, English};

public delegate void Updated_Settings(SettingModel _data);


public class SettingModel
{
    public bool DataCaching { get; set; }
    public AppTheme Theme { get; set; }
}

