using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {

	public partial class EquipmentAmmo : EquipmentBase {
		public virtual int RefId { get; set; }
		public virtual int AmmoTypeValue { get; set; }
		public virtual int CaliberTypeValue { get; set; }
		public virtual int EffDamageModArmor { get; set; }
		public virtual int EffDamageMod { get; set; }
		public virtual int Amount { get; set; }
    }
}
