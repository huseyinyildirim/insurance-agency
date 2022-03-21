using System.Threading.Tasks;
using InsuranceAgency.Provider.Models;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Provider
{
    public interface IProvider
    {
        Task<Response<Offer>> GetOfferAsync(Quotation quotation);
    }
}