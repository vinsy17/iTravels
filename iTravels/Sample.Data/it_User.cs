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
    
    public partial class it_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public it_User()
        {
            this.it_User_Role = new HashSet<it_User_Role>();
        }
    
        public System.Guid User_Id { get; set; }
        public string Email_Address { get; set; }
        public bool Is_Email_Confirmed { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Mobile_Number { get; set; }
        public string Display_Name { get; set; }
        public string Security_Stamp { get; set; }
        public bool Is_Mobile_Number_Confirmed { get; set; }
        public bool Is_Two_Factor_Enabled { get; set; }
        public bool Is_Lockout_Enabled { get; set; }
        public Nullable<System.DateTime> Lockout_End_Date_Utc { get; set; }
        public long Access_Failed_Count { get; set; }
        public bool Is_Deleted { get; set; }
        public System.DateTime Create_Time_Stamp { get; set; }
        public System.DateTime Update_Time_Stamp { get; set; }
        public string Password_Salt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<it_User_Role> it_User_Role { get; set; }
    }
}
