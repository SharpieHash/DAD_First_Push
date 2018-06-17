using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAD.Equipment {
    class Equipment {
        // Instance variables
        // Weapons
        private EquClasses.Weapon[] allWeapons;
        private dynamic Spears;
        private EquClasses.Weapon WoodSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Wooden Spear', 'Weight': '2', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'}");

        private string Spearli = @"{
                         'WoodSpear' : {'Name': 'Wooden Spear', 'Weight': '2', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'},
                         'StoneSpear' : {'Name': 'Stone Spear', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'},
                         'IronSpear' : {'Name': 'Iron Spear', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'},
                         'SteelSpear' : {'Name': 'Steel Spear', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'},
                         'ElvenSpear' : {'Name': 'Elven Spear', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'},
                         'DwarvenSpear' : {'Name': 'Dwarven Spear', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'},
                         'OrcishSpear' : {'Name': 'Orcish Spear', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'},
                         'LegendarySpear' : {'Name': 'Legendary Spear', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'},
                         'DragonBoneSpear' : {'Name': 'Dragon Bone Spear', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}
                         }";*/
        private dynamic Swords;
        private string Swordli = @"{
                         'WoodSword' : {'Name': 'Wooden Sword', 'Weight': '1', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'},
                         'StoneSword' : {'Name': 'Stone Sword', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'},
                         'IronSword' : {'Name': 'Iron Sword', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'},
                         'SteelSword' : {'Name': 'Steel Sword', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'},
                         'ElvenSword' : {'Name': 'Elven Sword', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'},
                         'DwarvenSword' : {'Name': 'Dwarven Sword', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'},
                         'OrcishSword' : {'Name': 'Orcish Sword', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'},
                         'LegendarySword' : {'Name': 'Legendary Sword', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'},
                         'DragonBoneSword' : {'Name': 'Dragon Bone Sword', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}
                         }";
        private dynamic Axes;
        private string Axeli = @"{
                         'WoodAxe' : {'Name': 'Wooden Axe', 'Weight': '1', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'},
                         'StoneAxe' : {'Name': 'Stone Axe', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'},
                         'IronAxe' : {'Name': 'Iron Axe', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'},
                         'SteelAxe' : {'Name': 'Steel Axe', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'},
                         'ElvenAxe' : {'Name': 'Elven Axe', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'},
                         'DwarvenAxe' : {'Name': 'Dwarven Axe', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'},
                         'OrcishAxe' : {'Name': 'Orcish Axe', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'},
                         'LegendaryAxe' : {'Name': 'Legendary Axe', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'},
                         'DragonBoneAxe' : {'Name': 'Dragon Bone Axe', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}
                         }";
        private dynamic Maces = @"{
                         'WoodMaces' : {'Name': 'Wooden Maces', 'Weight': '1', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'},
                         'StoneMaces' : {'Name': 'Stone Maces', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'},
                         'IronMaces' : {'Name': 'Iron Maces', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'},
                         'SteelMaces' : {'Name': 'Steel Maces', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'},
                         'ElvenMaces' : {'Name': 'Elven Maces', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'},
                         'DwarvenMaces' : {'Name': 'Dwarven Maces', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'},
                         'OrcishMaces' : {'Name': 'Orcish Maces', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'},
                         'LegendaryMaces' : {'Name': 'Legendary Maces', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'},
                         'DragonBoneMaces' : {'Name': 'Dragon Bone Maces', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}
                         }";
        private dynamic GreatSwords = @"{
                         'StoneGreatSword' : {'Name': 'Stone Great Sword', 'Weight': '5', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'},
                         'IronGreatSword' : {'Name': 'Iron Great Sword', 'Weight': '6', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'},
                         'SteelGreatSword' : {'Name': 'Steel Great Sword', 'Weight': '7', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'},
                         'ElvenGreatSword' : {'Name': 'Elven Great Sword', 'Weight': '8', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'},
                         'DwarvenGreatSword' : {'Name': 'Dwarven Great Sword', 'Weight': '9', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'},
                         'OrcishGreatSword' : {'Name': 'Orcish Great Sword', 'Weight': '10', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'},
                         'LegendaryGreatSword' : {'Name': 'Legendary Great Sword', 'Weight': '11', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'},
                         'DragonBoneGreatSword' : {'Name': 'Dragon Bone Great Sword', 'Weight': '12', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}
                         }";
        private dynamic BattleAxes = @"{
                         'StoneBattleAxe' : {'Name': 'Stone Battle Axe', 'Weight': '5', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'},
                         'IronBattleAxe' : {'Name': 'Iron Battle Axe', 'Weight': '6', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'},
                         'SteelBattleAxe' : {'Name': 'Steel Battle Axe', 'Weight': '7', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'},
                         'ElvenBattleAxe' : {'Name': 'Elven Battle Axe', 'Weight': '8', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'},
                         'DwarvenBattleAxe' : {'Name': 'Dwarven Battle Axe', 'Weight': '9', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'},
                         'OrcishBattleAxe' : {'Name': 'Orcish Battle Axe', 'Weight': '10', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'},
                         'LegendaryBattleAxe' : {'Name': 'Legendary Battle Axe', 'Weight': '11', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'},
                         'DragonBoneBattleAxe' : {'Name': 'Dragon Bone Battle Axe', 'Weight': '12', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}
                         }";
        private dynamic WarHammers;
        private dynamic Bows;
        private dynamic Arrows;
        private dynamic Throwables;
        private dynamic Staves;
        private dynamic Scepters;
        private dynamic Boomerang;
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
        // Constructor
        public Equipment() {
            allWeapons = new EquClasses.Weapon[] { WoodSpear};
        }
        public EquClasses.Weapon getWeapon (string Name) {
            return null;
        }
        private EquClasses.Weapon listIndexer (EquClasses.Weapon[] weaponList, string weaponName) {
            for(int i = 0; i > weaponList.GetLength(0); i++) {
                if (weaponName == weaponList[i].Name) {
                    return weaponList[i];
                }
            }
            return null;
        }
    }
}


