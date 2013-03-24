using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {

	public partial class EquipmentTypeWeapon : EquipmentTypeBase {
		public virtual int RefId { get; set; }
		public virtual int CaliberTypeValue { get; set; }
		public virtual int WeaponRange { get; set; }
		public virtual System.Nullable<int> PrecisionManual { get; set; }
		public virtual System.Nullable<int> PrecisionAuto { get; set; }
		public virtual int Damage { get; set; }
		public virtual int Magazinsize { get; set; }
		public virtual string Reloadtime { get; set; }
		public virtual string ConditionLossPerBullet { get; set; }
		public virtual int AutomaticTypeValue { get; set; }
		public virtual string FirerateManual { get; set; }
		public virtual string FirerateAuto { get; set; }
		public virtual int Loudness { get; set; }
		public virtual int DamageDropOff { get; set; }
		public virtual int Spreading { get; set; }
		public virtual int DamageModArmor { get; set; }
    }
}
