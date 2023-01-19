
using Stay_Halal.Scripts.Libraries.Dynamic;

namespace Stay_Halal.MVVM.Model;

public class TeamMemberModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Pictrue { get; set; }

    public ThemeModel Theme { get { return Theme_Lib.ActivTheme; } }
}

