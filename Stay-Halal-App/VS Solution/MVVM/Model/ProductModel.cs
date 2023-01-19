using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stay_Halal.MVVM.Model;

public class ProductModel
{
    public string Barcode { get; set; }
    public string Title { get; set; }
    public string Hersteller { get; set; }

    public InhaltsstoffModel[] Inhaltsstoffe { get; set; }
}
