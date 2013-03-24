using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class EquipmentTypeBase {
		public virtual int Id { get; set; }
		public virtual string EqName { get; set; }
		public virtual System.Nullable<int> ReqSkillId { get; set; }
		public virtual int Price { get; set; }
		public virtual int Weight { get; set; }
		public virtual System.Nullable<int> ReqRelationPoints { get; set; }
		public virtual int ZombieAttraction { get; set; }
		public virtual int ObjectType { get; set; }
		public virtual int Complexity { get; set; }
		public virtual int AmountSlots { get; set; }
		public virtual int SlotTypeValue { get; set; }
    }
}
