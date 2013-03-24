using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class Accuracy {
		public virtual int Id { get; set; }
		public virtual int CharacterID { get; set; }
		public virtual int AccuracyValue { get; set; }
		public virtual int WeaponTypeValue { get; set; }
    }
}
