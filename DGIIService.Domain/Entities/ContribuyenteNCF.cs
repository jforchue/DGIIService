using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGIIService.Domain.Entities
{
    public class ContribuyenteNCF
    {
        public string RncCedula { get; set; }
        public string NCF { get; set; }
        public double Monto { get; set; }
        public double Itebis18 { get; set; }
    }
}
