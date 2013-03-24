using System;
using System.Text;
using System.Collections.Generic;


namespace ZH_Classes {
    
    public partial class MerchantStock {
		public virtual int Id { get; set; }
		public virtual int EqId { get; set; }
		public virtual int MerchantID { get; set; }
		public virtual int Amount { get; set; }
    }
}
