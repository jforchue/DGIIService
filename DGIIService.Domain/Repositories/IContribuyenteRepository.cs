using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGIIService.Domain.Entities;

namespace DGIIService.Domain.Repositories
{
    public interface IContribuyenteRepository
    {
        List<Contribuyente> Get();
        List<ContribuyenteNCF> GetContribuyenteNCFList(int id);
    }
}
