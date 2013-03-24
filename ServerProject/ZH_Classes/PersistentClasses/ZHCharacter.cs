using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public  partial class ZHCharacter {
		public ZHCharacter() {
			Accuracies = new List<Accuracy>();
			EffAccuracies = new List<ChEffAccuracy>();
			EquipmentBases = new List<EquipmentBase>();
			Merchantrelations = new List<Merchantrelation>();
			Skills = new List<CharacterSkill>();
        }
        public virtual int Id { get; set; }
        public virtual ChEffStat ChEffStat { get; set; }
        public virtual int UserID { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Gender { get; set; }
        public virtual int Caps { get; set; }
        public virtual int Experience { get; set; }
        public virtual int Level { get; set; }
        public virtual int Skillpoints { get; set; }
        public virtual float PositionLat { get; set; }
        public virtual float PositionLng { get; set; }
        public virtual System.Nullable<int> TestSpeed { get; set; }
        public virtual int ChStats { get; set; }
        public virtual int ChEffStats { get; set; }
		public virtual int Strength { get; set; }
		public virtual int Dexterity { get; set; }
		public virtual int Intelligence { get; set; }
		public virtual int Attention { get; set; }
		public virtual int Health { get; set; }
		public virtual int Regeneration{ get; set; }
		public virtual int Resistance { get; set; }
		public virtual int ZombieAttraction { get; set; }
		public virtual int MaxLoad { get; set; }

        public virtual IList<Accuracy> Accuracies { get; set; }
        public virtual IList<ChEffAccuracy> EffAccuracies { get; set; }
        public virtual IList<EquipmentBase> EquipmentBases { get; set; }
        public virtual IList<Merchantrelation> Merchantrelations { get; set; }
        public virtual IList<CharacterSkill> Skills { get; set; }
    }
}
