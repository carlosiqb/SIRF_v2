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
    
    public partial class ModuloSubmodulo
    {
        public int moduloSubmoduloID { get; set; }
        public int catModuloID { get; set; }
        public int catSubmoduloID { get; set; }
    
        public virtual CatModulo CatModulo { get; set; }
        public virtual CatSubmodulo CatSubmodulo { get; set; }
    }
}
