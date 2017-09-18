using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SCAF.Model
{
    public class MasterPageItem
    {
        public string Title { get; set; }
        public ImageSource Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
