//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIRF.Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parametro
    {
        public int parametroID { get; set; }
        public int moduloID { get; set; }
        public string parametro1 { get; set; }
        public string descripcion { get; set; }
        public int valorInt { get; set; }
    
        public virtual CatModulo CatModulo { get; set; }
    }
}
