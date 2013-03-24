using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class CharacterSkill {
		public virtual int Id { get; set; }
		public virtual Skill Skill { get; set; }
		public virtual int CharacterID { get; set; }
		public virtual int SkillID { get; set; }
		public virtual int Level { get; set; }
    }
}
