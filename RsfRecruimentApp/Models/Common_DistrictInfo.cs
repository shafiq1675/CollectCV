//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RsfRecruimentApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Common_DistrictInfo
    {
        public Common_DistrictInfo()
        {
            this.Common_UpazillaInfo = new HashSet<Common_UpazillaInfo>();
        }
    
        public string DIST_CODE { get; set; }
        public string DIST_NAME { get; set; }
        public string DIVI_CODE { get; set; }
        public System.DateTime CREATED { get; set; }
        public System.DateTime MODIFIED { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ICollection<Common_UpazillaInfo> Common_UpazillaInfo { get; set; }
    }
}
