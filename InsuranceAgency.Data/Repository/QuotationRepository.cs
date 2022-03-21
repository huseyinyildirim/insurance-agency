using System.Collections.Generic;
using System.Linq;
using InsuranceAgency.Data.Entities;

namespace InsuranceAgency.Data.Repository
{
    public class QuotationRepository : BaseRepository<Quotation>, IQuotationRepository
    {
        public QuotationRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateQuotation(Quotation quotation)
        {
            Create(quotation);
        }

        public void DeleteQuotation(Quotation quotation)
        {
            Delete(quotation);
        }

        public IEnumerable<Quotation> GetAllQuotations()
        {
            return FindAll();
        }

        public Quotation GetQuotationById(int quotationId)
        {
            return FindByCondition(x => x.Id == quotationId).FirstOrDefault();
        }

        public Quotation GetQuotationByPlateTCId(string plate, string tcId)
        {
            return FindByCondition(x => x.Plate == plate && x.TCId == tcId).FirstOrDefault();
        }

        public IEnumerable<Quotation> GetAllQuotationByTCId(string tcId)
        {
            return FindByCondition(x => x.TCId == tcId).ToList();
        }

        public void UpdateQuotation(Quotation quotation)
        {
            Update(quotation);
        }
    }
}
