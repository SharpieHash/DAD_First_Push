using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.Equipment.EquClasses {
    public class Weapon {

        public string Name { get; set; }
        public dynamic Weight { get; set; }
        public dynamic Price { get; set; }
        public dynamic Damage { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public dynamic Proficency { get; set; }

        public Weapon() {
        }
    }

    public class rootWeapon {
        public List<Weapon> Weapon { get; set; }
        public void ConvertAllToInt() {
            for (int i = 0; i < this.Weapon.Count; i++) {
                Weapon[i].Weight = Convert.ToInt32(this.Weapon[i].Weight);
                Weapon[i].Price = Convert.ToInt32(this.Weapon[i].Price);
                Weapon[i].Damage = Convert.ToInt32(this.Weapon[i].Damage);
                Weapon[i].Proficency = Convert.ToInt32(this.Weapon[i].Proficency);
            }
        }
    }
}
