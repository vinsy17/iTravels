//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class it_st_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public it_st_Role()
        {
            this.it_User_Role = new HashSet<it_User_Role>();
        }
    
        public long Role_Id { get; set; }
        public string Role_Name { get; set; }
        public bool Is_Active { get; set; }
        public bool Is_Deleted { get; set; }
        public System.DateTime Create_Time_Stamp { get; set; }
        public System.DateTime Update_Time_Stamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<it_User_Role> it_User_Role { get; set; }
    }
}
