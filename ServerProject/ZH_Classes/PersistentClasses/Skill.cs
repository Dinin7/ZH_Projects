using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class Skill {
        public Skill() {
			SkillMods = new List<SkillMod>();
        }
		public virtual int Id { get; set; }
		public virtual string SkillName { get; set; }
		public virtual int Skillpoints { get; set; }
		public virtual string SkillpointsMultiplier { get; set; }
		public virtual System.Nullable<int> PreStrenght { get; set; }
		public virtual System.Nullable<int> PreDexterity { get; set; }
		public virtual System.Nullable<int> PreIntelligence { get; set; }
		public virtual System.Nullable<int> PreAttention { get; set; }
		public virtual System.Nullable<int> PreSkillID1 { get; set; }
		public virtual System.Nullable<int> PreSkillLevel1 { get; set; }
		public virtual System.Nullable<int> PreSkillID2 { get; set; }
		public virtual System.Nullable<int> PreSkillLevel2 { get; set; }
		public virtual IList<SkillMod> SkillMods { get; set; }
    }
}
