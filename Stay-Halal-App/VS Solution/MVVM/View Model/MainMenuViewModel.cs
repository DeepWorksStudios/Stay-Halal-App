
using Stay_Halal.MVVM.Model;
using Stay_Halal.Scripts.Libraries.Static;
using System.Collections.ObjectModel;

namespace Stay_Halal.MVVM.ViewModel;

public partial class MainMenuViewModel : BaseViewModel
{
    #region Observable Data 


    public ObservableCollection<QAModel> Qestions { get; set; } = new ObservableCollection<QAModel>();
    #endregion


    public MainMenuViewModel() : base()
    {
        Title = Localisation_Lib.ViewTitle_HauptMenü;

        Qestions.Add(new QAModel { QestionTitle = "Frage Title",QestionDescription="Volle frage max char muss bestimmt werden", AwnserTitle = "darum",AwnserDescription="test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
        Qestions.Add(new QAModel { QestionTitle = "warum hier", QestionDescription = "test", AwnserTitle = "darum", AwnserDescription = "test" });
    }
}

