//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace marathon_skills_2021.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timesheet
    {
        public int TimesheetID { get; set; }
        public Nullable<int> StaffIDNum { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string PaymentAmount { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}
