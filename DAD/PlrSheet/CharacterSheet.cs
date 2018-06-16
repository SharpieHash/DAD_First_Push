using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.PlrSheet {

    public class Character {
        //Instance variables
        // Character info
        private string plrName;
        private string plrClass;
        private string plrRace;
        private int plrLevel;
        private string plrBackground;
        private string userName;
        private string plrAlignment;
        private int plrExperience;
        // Character Vitals
        private int plrArmour;
        private int plrHP;

        // Character Saving throws
        private int plrSaveStrength;
        private int plrSaveDexterity;
        private int plrSaveConstitution;
        private int plrSaveInteligence;
        private int plrSaveWisdom;
        private int plrSaveCharisma;
        // Character Skills
        private int plrStrength;
        private int plrDexterity;
        private int plrConstitution;
        private int plrInteligence;
        private int plrWisdom;
        private int plrCharisma;
        private int plrPerception;
        // Character Proficiency
        private int plrProfiency;
        // Character Aspirations
        private string plrPersonality;
        private string plrIdeals;
        private string plrBonds;
        private string plrFlaws;
        // Character Equipment
        private string[] plrEquiptment;
        private int plrCarryWeight;
        // Character Attacks and Spellcasting
        private string[] plrSpells;
        // Character Traits

        // Character


        //Constructor
        public Character() {
            plrSpells = new string[3];
        }
        private void setCarryWeight() {
            this.plrCarryWeight = (this.plrStrength * 5);
            if (searchStringArr(this.plrEquiptment, "% BackPack")){

            }
        }
        private string searchStringArr(string[] searchArray, string stringToSearch) {
            for(int i = 0; i > searchArray.GetLength(0); i++) {
                if(stringToSearch == searchArray[i]) {
                    return searchArray[i];
                }
            }
            return null;
        }
    }
}