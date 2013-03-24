using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class SkillMod {
		public virtual int Id { get; set; }
		public virtual int SkillID { get; set; }
		public virtual int ModAttributeTypeValue { get; set; }
		public virtual int ModTypeValue { get; set; }
		public virtual int Modifier { get; set; }
    }
}
