using DGIIService.Domain.Entities;
using DGIIService.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGIIService.Domain.Services
{
    public interface IContribuyenteService: IContribuyenteRepository
    {
        List<Contribuyente> Get();
    }
}
