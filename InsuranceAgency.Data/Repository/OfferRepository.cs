using System.Collections.Generic;
using System.Linq;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public class OfferRepository : BaseRepository<Offer>, IOfferRepository
    {
        private readonly IQuotationRepository _quotationRepository;

        public OfferRepository(AppDbContext context, IQuotationRepository quotationRepository) : base(context)
        {
            _quotationRepository = quotationRepository;
        }

        public void CreateOffer(Offer offer)
        {
            Create(offer);
        }

        public void DeleteOffer(Offer offer)
        {
            Delete(offer);
        }

        public IEnumerable<Offer> GetAllOffers()
        {
            return FindAll();
        }

        public Offer GetOfferById(int offerId)
        {
            return FindByCondition(x => x.Id == offerId).FirstOrDefault();
        }

        public IEnumerable<Offer> GetAllOfferByTCId(string tcId)
        {
            var quotationRepositoryResult = _quotationRepository.GetAllQuotationByTCId(tcId);

            var quotationIds = quotationRepositoryResult.Select(x => x.Id).ToArray();
            var plates = quotationRepositoryResult.Select(x => x.Plate).ToArray();

            return FindByCondition(x => quotationIds.Contains(x.QuotationId) && plates.Contains(x.Plate)).ToList();
        }

        public void UpdateOffer(Offer offer)
        {
            Update(offer);
        }
    }
}
