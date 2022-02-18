using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaJJT.Business.DTOs
{
    public sealed class DTOPais : DTOBase
    {
        public short PaisCodigo { get; set; }
        public string PaisIso1 { get; set; } = null!;
        public string PaisNombre { get; set; } = null!;
    }
}
