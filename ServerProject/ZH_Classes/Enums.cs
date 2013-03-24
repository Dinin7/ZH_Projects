using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH_Classes {
	public class Enums {

		

	}
	public enum WeaponType {
		Hit = 1,
		Pistol = 2,
		Rifle = 3,
		SmallAuto = 4,
		LargeAuto = 5,
		LongRange = 6,
		Arrows = 7,
		Heavy = 8
	};

	public enum ModAttributeType {
		CStr = 1,
		CDex = 2,
		CInt = 3,
		CAtt = 4,
		CHth = 5,
		CReg = 6,
		CRes = 7,
		CML = 8,
		CAcu = 9,
		CZA = 10
	};

	public enum ModType {
		Percent = 1,
		Absolut = 2
	};
}
