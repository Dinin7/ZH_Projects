using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {

	public partial class EquipmentTypeArmor : EquipmentTypeBase {
		public virtual int RefId { get; set; }
		public virtual int DamageModBullet { get; set; }
		public virtual int DamageModHit { get; set; }
		public virtual string ConditionLossPerBullet { get; set; }
		public virtual string ConditionLossPerHit { get; set; }
    }
}
