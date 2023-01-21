using Stay_Halal.Scripts.Libraries.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Stay_Halal.MVVM.Model;

public enum Inhalt_Type { Halal,Haram,Unknown}

public class InhaltsstoffModel
{
    public string Name { get; set; }
  
    public Inhalt_Type Type { get; set; }

    public string TypeText { get { return Enum.GetName(typeof(Inhalt_Type), Type); } }

    public Color TypeColor
    {
        get
        {
            switch (Type)
            {
                case Inhalt_Type.Halal:

                    return Color.Parse("#009B54");

                case Inhalt_Type.Haram:
                    return Color.Parse("#CE0C1F");

                case Inhalt_Type.Unknown:
                    return Color.Parse("#FF9B54");

                default: return Color.Parse("#FF9B54");
            }
        }
    }

    public ThemeModel Theme { get { return Theme_Lib.ActivTheme; } }
}
