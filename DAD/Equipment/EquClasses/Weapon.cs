using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.Equipment.EquClasses {
    public class Weapon {
        public string Name { get; set; }
        public dynamic Weight { get; set; }
        public dynamic Price { get; set; }
        public dynamic Damage { get; set; }
        public string Type { get; set; }
        public dynamic Proficency { get; set; }
        public string Description { get; set; }
        public Weapon() {
        }
    }

    public class rootWeapon {
        public List<Weapon> Weapon { get; set; }
    }
}