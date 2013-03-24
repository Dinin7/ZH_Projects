using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class ChEffStat {
        public ChEffStat() {
        }
        public int Id { get; set; }
        public int EffStrenght { get; set; }
        public int EffDexterity { get; set; }
        public int EffIntelligence { get; set; }
        public int EffAttention { get; set; }
        public int EffHealth { get; set; }
        public int EffRegeneration { get; set; }
        public int EffResistance { get; set; }
        public int EffZombieAttraction { get; set; }
        public int EffInfection { get; set; }
        public int EffMaxLoad { get; set; }
    }
}
