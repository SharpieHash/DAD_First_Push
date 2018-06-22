﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAD.PlrSheet {

    public class Character {
        //Instance variables
        // Character info
        public string plrName { get; set; }
        public string plrClass { get; set; }
        public string plrRace { get; set; }
        public dynamic plrLevel { get; set; }
        public string plrBackground { get; set; }
        public string userName { get; set; }
        public string plrAlignment { get; set; }
        public dynamic plrExperience { get; set; }
        // Character Vitals
        public dynamic plrArmour { get; set; }
        public dynamic plrHP { get; set; }

        // Character Saving throws
        public dynamic plrSaveStrength { get; set; }
        public dynamic plrSaveDexterity { get; set; }
        public dynamic plrSaveConstitution { get; set; }
        public dynamic plrSaveInteligence { get; set; }
        public dynamic plrSaveWisdom { get; set; }
        public dynamic plrSaveCharisma { get; set; }
        // Character Skills
        public dynamic plrStrength { get; set; }
        public dynamic plrDexterity { get; set; }
        public dynamic plrConstitution { get; set; }
        public dynamic plrInteligence { get; set; }
        public dynamic plrWisdom { get; set; }
        public dynamic plrCharisma { get; set; }
        public dynamic plrPerception { get; set; }
        // Character Proficiency
        public dynamic plrProfiency { get; set; }
        // Character Aspirations
        public string plrPersonality { get; set; }
        public string plrIdeals { get; set; }
        public string plrBonds { get; set; }
        public string plrFlaws { get; set; }
        // Character Equipment
        public List<string> plrEquiptment { get; set; }
        public dynamic plrCarryWeight { get; set; }
        // Character Attacks and Spellcasting
        public string[] plrSpells { get; set; }
        // Character Traits

        // Character
        private Equipment.Equipment equipment;


        //Constructor
        public Character() {
            plrSpells = new string[3];
            equipment = new Equipment.Equipment();
            //MessageBox.Show(equipment.getWeapon("Wooden Spear").Name).ToString();
        }
        /*private void setCarryWeight() {
            this.plrCarryWeight = (this.plrStrength * 5);
            string name = equipment.Spears.
            if (){
                this.plrCarryWeight += 
            }
        }*/
    }
    public class rootCharacter {
        public List<Character> Character { get; set; }
        public void ConvertAllToInt() {
            for (int i= 0; i < this.Character.Count; i++) {
                Character[i].plrLevel = Convert.ToInt32(this.Character[i].plrLevel);
                Character[i].plrExperience = Convert.ToInt32(this.Character[i].plrExperience);
                Character[i].plrSaveStrength = Convert.ToInt32(this.Character[i].plrSaveStrength);
                Character[i].plrSaveDexterity = Convert.ToInt32(this.Character[i].plrSaveDexterity);
                Character[i].plrSaveConstitution = Convert.ToInt32(this.Character[i].plrSaveConstitution);
                Character[i].plrSaveInteligence = Convert.ToInt32(this.Character[i].plrSaveInteligence);
                Character[i].plrSaveWisdom = Convert.ToInt32(this.Character[i].plrSaveWisdom);
                Character[i].plrSaveCharisma = Convert.ToInt32(this.Character[i].plrSaveCharisma);
                Character[i].plrStrength = Convert.ToInt32(this.Character[i].plrStrength);
                Character[i].plrDexterity = Convert.ToInt32(this.Character[i].plrDexterity);
                Character[i].plrConstitution = Convert.ToInt32(this.Character[i].plrConstitution);
                Character[i].plrInteligence = Convert.ToInt32(this.Character[i].plrInteligence);
                Character[i].plrWisdom = Convert.ToInt32(this.Character[i].plrWisdom);
                Character[i].plrCharisma = Convert.ToInt32(this.Character[i].plrCharisma);
                Character[i].plrPerception = Convert.ToInt32(this.Character[i].plrPerception);
            }
        }
    }
}