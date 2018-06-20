using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace DAD.Equipment {
    class Equipment {
        /*
        {
        "Name": "",
        "Weight": "",
        "Price": "",
        "Damage": "",
        "Type": "Weapon",
        "ProficencyReq": ""
        }
        */
        // Spells
        private dynamic HealingSpells;
        private dynamic FireSpells;
        private dynamic IceSpells;
        private dynamic LightingSpells;
        private dynamic IllusionSpells;
        private dynamic AlterationSpells;
        private dynamic ConjurationSpells;
        // Armour
        private dynamic Shields;
        private dynamic Helms;
        private dynamic ChestPlate;
        private dynamic Braces;
        private dynamic Greaves;
        private dynamic LegPlates;
        private dynamic Sabatons;
        // Backpacks
        private dynamic BackPacks;
        // Money
        private dynamic Coins;
        // Potions
        private dynamic HealingPots;
        private dynamic AlerationPots;
        private dynamic IllusionPots;
        // Scrolls
        private dynamic FireScrolls;
        private dynamic IceScrolls;
        private dynamic LightningScrolls;
        private dynamic IllusionScrolls;
        private dynamic AlterationScrolls;
        private dynamic ConjurationScrolls;
        // Misc
        private dynamic Ores;
        private dynamic Ingots;
        private dynamic Pelts;
        private dynamic Gems;
        private dynamic Collectables;
        //
        private EquClasses.rootWeapon weaponLi;
        private EquClasses.RootArmour armourLi;
        // Constructor
        public Equipment() {
            weaponLi = new EquClasses.rootWeapon();
            armourLi = new EquClasses.RootArmour();
            loadAllJson();

        }
        // Mutators
        public EquClasses.rootWeapon getWeaponList { get; set; }
        public EquClasses.RootArmour getArmourList { get; set; }
        // Methods
        private void loadAllJson() {
            loadWeapons();
        }
        private void loadWeapons() {
            string cwr = Directory.GetCurrentDirectory();
            DirectoryInfo cwrParent = Directory.GetParent(cwr);
            cwrParent = cwrParent.Parent;
            cwr = cwrParent.FullName + "/Equipment/EquJson/WeaponList.json";
            dynamic Weaponjson = File.ReadAllText(cwr);
            weaponLi = JsonConvert.DeserializeObject<EquClasses.rootWeapon>(Weaponjson);
            ConvertAllWeapons();
        }
        private void ConvertAllWeapons() {
            for (int i = 0; i < weaponLi.Weapon.Count; i++) {
                //Int32.Parse(weaponLi.Weapon[i].Name);
                //Int32.Parse(weaponLi.Weapon[i].Price);
                //Int32.Parse(weaponLi.Weapon[i].Damage);
                //Int32.Parse(weaponLi.Weapon[i].Proficency);
            }
        }
    }
}



