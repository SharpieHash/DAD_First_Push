using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.Equipment.EquClasses {
    public class Armour {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public int Damage { get; set; }
        public string Type = "Weapons";
        public int Proficency { get; set; }
    }
    public class RootArmour{
        public List<Armour> Armour { get; set; }
    }
}
