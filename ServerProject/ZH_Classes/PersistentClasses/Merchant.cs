using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class Merchant {
        public Merchant() {
			MerchantStocks = new List<MerchantStock>();
        }
		public virtual int Id { get; set; }
		public virtual string MerchantName { get; set; }
		public virtual float PositionLat { get; set; }
		public virtual float PositionLng { get; set; }
		public virtual int Quality { get; set; }
		public virtual int ObjectTypeValue { get; set; }
		public virtual IList<MerchantStock> MerchantStocks { get; set; }
    }
}
