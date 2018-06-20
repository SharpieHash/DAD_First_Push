﻿using System;
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
        public string Name { get; set; }
        public string JpgLocation { get; set; }
        public string Type { get; set; }
        public dynamic NumOfMobs { get; set; }
    }
}
