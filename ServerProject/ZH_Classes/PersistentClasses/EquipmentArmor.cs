using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {

	public partial class EquipmentArmor : EquipmentBase {
		public virtual int RefId { get; set; }
		public virtual System.Nullable<int> EffDamageModBullet { get; set; }
		public virtual System.Nullable<int> EffDamageModHit { get; set; }
		public virtual string EffConditionModBullet { get; set; }
		public virtual string EffConditionModHit { get; set; }
    }
}
