using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {

	public partial class EquipmentWeapon : EquipmentBase {
		public virtual int RefId { get; set; }
		public virtual int CaliberTypeValue { get; set; }
		public virtual int EffRange { get; set; }
		public virtual System.Nullable<int> EffPrecisionManual { get; set; }
		public virtual System.Nullable<int> EffPrecisionAuto { get; set; }
		public virtual int EffDamage { get; set; }
		public virtual int EffMagazinsize { get; set; }
		public virtual string EffReloadTime { get; set; }
		public virtual string EffContitionLossPerBullet { get; set; }
		public virtual string EffFirerateManual { get; set; }
		public virtual string EffFirerateAuto { get; set; }
		public virtual int EffLoudness { get; set; }
		public virtual string EffDamageDropOff { get; set; }
		public virtual int EffSpreading { get; set; }
		public virtual int AutomaticType { get; set; }
		public virtual int EffDamageModArmor { get; set; }
    }
}
