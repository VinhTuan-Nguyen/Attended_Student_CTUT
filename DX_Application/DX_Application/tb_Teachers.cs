//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DX_Application
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Teachers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Teachers()
        {
            this.tb_Attended = new HashSet<tb_Attended>();
            this.tb_ClassRooms = new HashSet<tb_ClassRooms>();
            this.tb_Courses = new HashSet<tb_Courses>();
        }
    
        public string col_TeacherID { get; set; }
        public string col_FName { get; set; }
        public string col_Department { get; set; }
        public string col_Email { get; set; }
        public string col_Phone { get; set; }
        public Nullable<bool> col_Sex { get; set; }
        public byte[] col_Avatar { get; set; }
    
        public virtual tb_Accounts tb_Accounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Attended> tb_Attended { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ClassRooms> tb_ClassRooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Courses> tb_Courses { get; set; }
    }
}
