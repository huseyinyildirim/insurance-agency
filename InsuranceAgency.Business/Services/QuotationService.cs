using System.Collections.Generic;
using AutoMapper;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Data.Entities;
using InsuranceAgency.Data.Repository;
using InsuranceAgency.Shared;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public class QuotationService : IQuotationService
    {
        private readonly IQuotationRepository _quotationRepository;
        private readonly IMapper _mapper;

        public QuotationService(IMapper mapper, IQuotationRepository quotationRepository)
        {
            _mapper = mapper;
            _quotationRepository = quotationRepository;
        }

        public QuotationService()
        {
        }

        public Response<List<QuotationDto>> GetAll()
        {
            var quotations = _quotationRepository.GetAllQuotations();

            return Response<List<QuotationDto>>.Success(_mapper.Map<List<QuotationDto>>(quotations), HttpStatusCode.OK);
        }

        public Response<QuotationDto> GetById(int id)
        {
            var quotation = _quotationRepository.GetQuotationById(id);

            if (quotation == null)
            {
                return Response<QuotationDto>.Fail(Messages.NOT_FOUND, HttpStatusCode.NOT_FOUND);
            }

            return Response<QuotationDto>.Success(_mapper.Map<QuotationDto>(quotation), HttpStatusCode.OK);
        }

        public Response<QuotationDto> GetByPlateTCId(string plate, string tcId)
        {
            var quotation = _quotationRepository.GetQuotationByPlateTCId(plate, tcId);

            if (quotation == null)
            {
                return Response<QuotationDto>.Fail(Messages.NOT_FOUND, HttpStatusCode.NOT_FOUND);
            }

            return Response<QuotationDto>.Success(_mapper.Map<QuotationDto>(quotation), HttpStatusCode.OK);
        }

        public Response<QuotationDto> Create(QuotationCreateDto quotationCreateDto)
        {
            var newQuotation = _mapper.Map<Quotation>(quotationCreateDto);

            _quotationRepository.CreateQuotation(newQuotation);

            return Response<QuotationDto>.Success(_mapper.Map<QuotationDto>(newQuotation), HttpStatusCode.OK);
        }
    }
}
