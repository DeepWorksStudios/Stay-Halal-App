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
            return Type switch
            {
                Inhalt_Type.Halal => Color.Parse("#009B54"),
                Inhalt_Type.Haram => Color.Parse("#CE0C1F"),
                Inhalt_Type.Unknown => Color.Parse("#FF9B54"),
                _ => Color.Parse("#FF9B54"),
            };
        }
    }

    public ThemeModel Theme { get { return Theme_Lib.ActivTheme; } }
}
