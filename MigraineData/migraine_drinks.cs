//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigraineData
{
    using System;
    using System.Collections.Generic;
    
    public partial class migraine_drinks
    {
        public int id { get; set; }
        public int migraine_id { get; set; }
        public int drink_id { get; set; }
    
        public virtual drink drink { get; set; }
        public virtual migraine migraine { get; set; }
    }
}
