//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicalDiagnosticProcedure
    {
        public int Id { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        public Nullable<System.DateTime> DateMeeting { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public string Results { get; set; }
        public string Recommendations { get; set; }
        public Nullable<int> Price { get; set; }
        public string Payment_type { get; set; }
    
        public virtual Doctors Doctors { get; set; }
        public virtual Patients Patients { get; set; }
    }
}
