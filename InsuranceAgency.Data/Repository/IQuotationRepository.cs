using System.Collections.Generic;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public interface IQuotationRepository
    {
        IEnumerable<Quotation> GetAllQuotations();

        Quotation GetQuotationById(int quotationId);

        IEnumerable<Quotation> GetAllQuotationByTCId(string tcId);

        Quotation GetQuotationByPlateTCId(string plate, string tcId);

        void CreateQuotation(Quotation quotation);

        void UpdateQuotation(Quotation quotation);

        void DeleteQuotation(Quotation quotation);
    }
}
