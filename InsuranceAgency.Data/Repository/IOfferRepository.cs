using System.Collections.Generic;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> GetAllOffers();

        IEnumerable<Offer> GetAllOfferByTCId(string tcId);

        Offer GetOfferById(int offerId);

        void CreateOffer(Offer offer);

        void UpdateOffer(Offer offer);

        void DeleteOffer(Offer offer);
    }
}
