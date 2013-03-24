using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {

	public partial class EquipmentTypeAmmo : EquipmentTypeBase {
		public virtual int RefId { get; set; }
		public virtual int AmmoTypeValue { get; set; }
		public virtual int CaliberTypeValue { get; set; }
		public virtual int DamageModArmor { get; set; }
		public virtual int DamageMod { get; set; }
    }
}
