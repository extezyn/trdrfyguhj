//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Figentity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Classes
    {
        public int ClassID { get; set; }
        public System.DateTime ClassDate { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> TrainerID { get; set; }
    
        public virtual Members Members { private get; set; }
        public virtual Trainers Trainers { private get; set; }
    }
}
