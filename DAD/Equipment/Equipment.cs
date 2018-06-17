using Newtonsoft.Json;

namespace DAD.Equipment {
    class Equipment {
        // Instance variables
        // Weapons
        // Spears
        private EquClasses.Weapon[] Spears;
        private EquClasses.Weapon WoodSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Wooden Spear', 'Weight': '2', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'}");
        private EquClasses.Weapon StoneSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Stone Spear', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon IronSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Iron Spear', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon SteelSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Steel Spear', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon ElvenSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven Spear', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon DwarvenSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dwarven Spear', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'}");
        private EquClasses.Weapon OrcishSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Orcish Spear', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'}");
        private EquClasses.Weapon LegendarySpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary Spear', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneSpear = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone Spear', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}");
        // Swords
        private EquClasses.Weapon[] Swords;
        private EquClasses.Weapon WoodSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Wooden Sword', 'Weight': '1', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'}");
        private EquClasses.Weapon StoneSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Stone Sword', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon IronSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Iron Sword', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon SteelSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Steel Sword', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon ElvenSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven Sword', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon DwarvenSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dwarven Sword', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'}");
        private EquClasses.Weapon OrcishSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Orcish Sword', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'}");
        private EquClasses.Weapon LegendarySword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary Sword', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone Sword', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}");
        // Axes
        private EquClasses.Weapon[] Axes;
        private EquClasses.Weapon WoodAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Wooden Axe', 'Weight': '1', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'}");
        private EquClasses.Weapon StoneAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Stone Axe', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon IronAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Iron Axe', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon SteelAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Steel Axe', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon ElvenAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven Axe', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon DwarvenAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dwarven Axe', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'}");
        private EquClasses.Weapon OrcishAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Orcish Axe', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'}");
        private EquClasses.Weapon LegendaryAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary Axe', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone Axe', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}");
        // Maces
        private EquClasses.Weapon[] Maces;
        private EquClasses.Weapon WoodMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Wooden Mace', 'Weight': '1', 'Price': '0', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '0'}");
        private EquClasses.Weapon StoneMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Stone Maces', 'Weight': '3', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon IronMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Iron Maces', 'Weight': '4', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon SteelMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Steel Maces', 'Weight': '4', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon ElvenMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven Maces', 'Weight': '3', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon DwarvenMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dwarven Maces', 'Weight': '4', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'}");
        private EquClasses.Weapon OrcishMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@" {'Name': 'Orcish Maces', 'Weight': '5', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'}");
        private EquClasses.Weapon LegendaryMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary Maces', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneMace = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone Maces', 'Weight': '10', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}");
        // Great Swords
        private EquClasses.Weapon[] GreatSwords;
        private EquClasses.Weapon StoneGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Stone Great Sword', 'Weight': '5', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon IronGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Iron Great Sword', 'Weight': '6', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon SteelGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Steel Great Sword', 'Weight': '7', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon ElvenGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven Great Sword', 'Weight': '8', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon DwarvenGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dwarven Great Sword', 'Weight': '9', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'}");
        private EquClasses.Weapon OrcishGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Orcish Great Sword', 'Weight': '10', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'}");
        private EquClasses.Weapon LegendaryGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary Great Sword', 'Weight': '11', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneGreatSword = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone Great Sword', 'Weight': '12', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}");
        // Battle Axes
        private EquClasses.Weapon[] BattleAxes;
        private EquClasses.Weapon StoneBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Stone Battle Axe', 'Weight': '5', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon IronBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Iron Battle Axe', 'Weight': '6', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon SteelBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Steel Battle Axe', 'Weight': '7', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon ElvenBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven Battle Axe', 'Weight': '8', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon DwarvenBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dwarven Battle Axe', 'Weight': '9', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'}");
        private EquClasses.Weapon OrcishBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Orcish Battle Axe', 'Weight': '10', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'}");
        private EquClasses.Weapon LegendaryBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary Battle Axe', 'Weight': '11', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneBattleAxe = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone Battle Axe', 'Weight': '12', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}");
        // War Hammers
        private EquClasses.Weapon[] WarHammers;
        private EquClasses.Weapon StoneWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Stone War Hammer', 'Weight': '5', 'Price': '1', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon IronWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Iron War Hammer', 'Weight': '6', 'Price': '2', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon SteelWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Steel War Hammer', 'Weight': '7', 'Price': '3', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon ElvenWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven War Hammer', 'Weight': '8', 'Price': '4', 'Damage': '4', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon DwarvenWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dwarven War Hammer', 'Weight': '9', 'Price': '5', 'Damage': '5', 'type': 'Weapon', 'ProficencyReq': '5'}");
        private EquClasses.Weapon OrcishWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Orcish War Hammer', 'Weight': '10', 'Price': '7', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '6'}");
        private EquClasses.Weapon LegenaryWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary War Hammer', 'Weight': '11', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone War Hammer', 'Weight': '12', 'Price': '15', 'Damage': '10', 'type': 'Weapon', 'ProficencyReq': '8'}");
        // Bows
        private EquClasses.Weapon[] Bows;
        private EquClasses.Weapon WoodenBow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Wooden Bow', 'Weight': '1', 'Price': '1', 'Damage': '1', 'type': 'Weapon', 'ProficencyReq': '1'}");
        private EquClasses.Weapon HuntersBow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Hunters Bow', 'Weight': '2', 'Price': '3', 'Damage': '2', 'type': 'Weapon', 'ProficencyReq': '2'}");
        private EquClasses.Weapon ElvenBow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Elven Bow', 'Weight': '3', 'Price': '4', 'Damage': '3', 'type': 'Weapon', 'ProficencyReq': '3'}");
        private EquClasses.Weapon OrcishBow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Orcish Bow', 'Weight': '5', 'Price': '6', 'Damage': '6', 'type': 'Weapon', 'ProficencyReq': '4'}");
        private EquClasses.Weapon LegendaryBow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Legendary Bow', 'Weight': '8', 'Price': '10', 'Damage': '8', 'type': 'Weapon', 'ProficencyReq': '7'}");
        private EquClasses.Weapon DragonBoneBow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"{'Name': 'Dragon Bone Bow', 'Weight': '10', 'Price': '15', 'Damage': '12', 'type': 'Weapon', 'ProficencyReq': '8'}");
        private EquClasses.Weapon[] Arrows;
        private EquClasses.Weapon WoodenArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon StoneArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon IronArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon SteelArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon BarbedArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon ElvenArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon OrcishArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon LegendaryArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon DragonBoneArrow = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon[] Throwables;
        //private EquClasses.Weapon StoneWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon[] Staves;
        //private EquClasses.Weapon StoneWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon[] Scepters;
        //private EquClasses.Weapon StoneWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
        private EquClasses.Weapon[] Boomerang;
        //private EquClasses.Weapon StoneWarHammer = JsonConvert.DeserializeObject<EquClasses.Weapon>(@"");
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
            Spears = new EquClasses.Weapon[] { WoodSpear, StoneSpear, IronSpear, SteelSpear, ElvenSpear, DwarvenSpear, OrcishSpear, LegendarySpear, DragonBoneSpear };
            Swords = new EquClasses.Weapon[] { WoodSword, StoneSword, IronSword, SteelSword, ElvenSword, DwarvenSword, OrcishSword, LegendarySword, DragonBoneSword };
            Axes = new EquClasses.Weapon[] { WoodAxe, StoneAxe, IronAxe, SteelAxe, ElvenAxe, DwarvenAxe, OrcishAxe, LegendaryAxe, DragonBoneAxe };
            Maces = new EquClasses.Weapon[] { WoodMace, StoneMace, IronMace, SteelMace, ElvenMace, DwarvenMace, OrcishMace, LegendaryMace, DragonBoneMace };
            GreatSwords = new EquClasses.Weapon[] { StoneGreatSword, IronGreatSword, SteelGreatSword, ElvenGreatSword, DwarvenGreatSword, OrcishGreatSword, LegendaryGreatSword, DragonBoneGreatSword };
            BattleAxes = new EquClasses.Weapon[] { StoneBattleAxe, IronBattleAxe, SteelBattleAxe, ElvenBattleAxe, DwarvenBattleAxe, OrcishBattleAxe, LegendaryBattleAxe, DragonBoneBattleAxe };
            BattleAxes = new EquClasses.Weapon[] { StoneBattleAxe, IronBattleAxe, SteelBattleAxe, ElvenBattleAxe, DwarvenBattleAxe, OrcishBattleAxe, LegendaryBattleAxe, DragonBoneBattleAxe };
        }

        private EquClasses.Weapon listIndexer (EquClasses.Weapon[] weaponList, string weaponName) {
            for(int i = 0; i < weaponList.Length; i++) {
                if (weaponName.ToString() == weaponList[i].Name.ToString()) {
                    return weaponList[i];
                }
            }
            return null;
        }
    }
}


