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
    
    public partial class tb_Courses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Courses()
        {
            this.tb_Attended = new HashSet<tb_Attended>();
            this.tb_RegisterCourses = new HashSet<tb_RegisterCourses>();
        }
    
        public int col_CoursesID { get; set; }
        public string col_CoursesName { get; set; }
        public string col_Semester { get; set; }
        public Nullable<System.DateTime> col_DateStr { get; set; }
        public Nullable<System.DateTime> col_DateEnd { get; set; }
        public string col_DayoWeek { get; set; }
        public string col_Status { get; set; }
        public string col_TeacherID { get; set; }
        public string col_RoomID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Attended> tb_Attended { get; set; }
        public virtual tb_ClassRooms tb_ClassRooms { get; set; }
        public virtual tb_Teachers tb_Teachers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_RegisterCourses> tb_RegisterCourses { get; set; }
    }
}
