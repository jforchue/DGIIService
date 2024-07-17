using Dapper;
using DGIIService.Domain.Entities;
using DGIIService.Domain.Repositories;
using DGIIService.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGIIService.Infrastructure
{
    public class ContribuyenteRepository : ConnectionRepository, IContribuyenteRepository
    {
        public List<Contribuyente> Get()
        {
            return _dbConnection.Query<Contribuyente>
                ("sp_contribuyentes_get",
                commandType: System.Data.CommandType.StoredProcedure)
                .AsList();
        }

        public List<ContribuyenteNCF> GetContribuyenteNCFList(int id)
        {
            return _dbConnection.Query<ContribuyenteNCF>
                ("sp_contribuyentes_ncf_get",
                new { id }, commandType: System.Data.CommandType.StoredProcedure)
                .AsList();
        }
    }
}
