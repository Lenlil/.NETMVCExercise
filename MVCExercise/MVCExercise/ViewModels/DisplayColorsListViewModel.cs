using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCExercise.ViewModels
{
    public class DisplayColorsListViewModel
    {
        public List<ColorViewModel> Group1ColorList { get; set; }
        public List<ColorViewModel> Group2ColorList { get; set; }
        public List<ColorViewModel> Group3ColorList { get; set; }
    }
}
