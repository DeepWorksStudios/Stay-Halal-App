using Stay_Halal.Scripts.Libraries.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stay_Halal.MVVM.Model;

public class QAModel
{
    public string QestionTitle { get; set; }
    public string QestionDescription { get; set; }
    public string AwnserTitle { get; set; }
    public string AwnserDescription { get; set; }

    public ThemeModel Theme { get { return Theme_Lib.ActivTheme; } }
}
