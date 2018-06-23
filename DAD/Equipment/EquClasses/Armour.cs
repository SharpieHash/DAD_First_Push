using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.Equipment.EquClasses {
    public class Armour {
        public string Name { get; set; }
        public dynamic Weight { get; set; }
        public dynamic Price { get; set; }
        public dynamic ArmourRating { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public dynamic Proficency { get; set; }
    }
    public class RootArmour {
        public List<Armour> Armour { get; set; }

        public void ConvertAllToInt(){
            for (int i = 0; i < Armour.Count; i++) {
                Armour[i].Weight = Convert.ToInt32(Armour[i].Weight);
                Armour[i].Price = Convert.ToInt32(Armour[i].Price);
                Armour[i].ArmourRating = Convert.ToInt32(Armour[i].ArmourRating);
                Armour[i].Proficency = Convert.ToInt32(Armour[i].ArmourRating);
            }
        }
    }
}
