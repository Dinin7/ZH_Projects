using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class EquipmentBase {
        public EquipmentBase() {
        }
		public virtual int Id { get; set; }
		public virtual EquipmentTypeBase EqBase { get; set; }
		public virtual int CharacterID { get; set; }
		public virtual string EqName { get; set; }
		public virtual int EqCondition { get; set; }
		public virtual int EffWeight { get; set; }
		public virtual int EffZombieAttraction { get; set; }
		public virtual int ObjectTypeValue { get; set; }
		public virtual int AmountSlots { get; set; }
		public virtual int EquipmentTypeBaseID { get; set; }
    }
}
