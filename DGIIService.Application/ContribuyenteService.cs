using DGIIService.Domain.Entities;
using DGIIService.Domain.Repositories;
using DGIIService.Domain.Services;

namespace DGIIService.Application
{
    public class ContribuyenteService : IContribuyenteService
    {
        IContribuyenteRepository _contribuyenteRepository;

        public ContribuyenteService(IContribuyenteRepository contribuyenteRepository)
        {
            _contribuyenteRepository = contribuyenteRepository ?? throw new ArgumentNullException(nameof(contribuyenteRepository));
        }

        public List<Contribuyente> Get()
        {
            return _contribuyenteRepository.Get();
        }

        public List<ContribuyenteNCF> GetContribuyenteNCFList(int id)
        {
            return _contribuyenteRepository.GetContribuyenteNCFList(id);
        }
    }
}