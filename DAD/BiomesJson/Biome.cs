using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.BiomesJson {
    class rootBiome {
        public List<Biome> biomes { get; set; }
        public void ConvertAllToInt() {
            for (int i = 0; i < this.biomes.Count; i++) {
                biomes[i].Temprature = Convert.ToInt32(this.biomes[i].Temprature);
                biomes[i].Humidity = Convert.ToInt32(this.biomes[i].Humidity);
                biomes[i].Height = Convert.ToInt32(this.biomes[i].Height);
            }
        }
        public Biome randomLoactionGen() {
            Random rd = new Random();
            int randomInt = rd.Next(0, biomes.Count);
            return biomes[randomInt];
        }
    }
    class Biome {
        //JPEG size 250x120
        //Map size 1080x268
        public string Name { get; set; }
        public dynamic Temprature { get; set; }
        public dynamic Humidity { get; set; }
        public string ControllingFaction { get; set; }
        public dynamic Height { get; set; }
        public List<string> CharacterBonus { get; set; }
        public List<SubBiome> subBiomes { get; set; }
        public string JpgName { get; set; }
    }
    class SubBiome {
        Random rd = new Random();
        public string Name() { return genName("_"); }
        public string JpgLocation { get; set; }
        public string Type { get; set; }
        private int NumOfMobs() { return rd.Next(0, 3); }
        public void MobsInArea() { /*List<string> return using randomNumOfMobs and the mob character sheets*/}
        private string genName(string placeType) {
            return null;
        }
    }
}
