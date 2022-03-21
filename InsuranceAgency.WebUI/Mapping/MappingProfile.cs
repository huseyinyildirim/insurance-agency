using AutoMapper;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Data.Entities;
using InsuranceAgency.WebUI.Models;

namespace InsuranceAgency.WebUI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Quotation, QuotationDto>().ReverseMap();
            CreateMap<Quotation, QuotationCreateDto>().ReverseMap();
            CreateMap<InsuranceProvider, InsuranceProviderDto>().ReverseMap();
            CreateMap<Offer, OfferDto>().ReverseMap();
            CreateMap<Offer, OfferCreateDto>().ReverseMap();

            CreateMap<OfferCreateDto, Provider.Models.Data>().ReverseMap();

            CreateMap<Provider.Models.Quotation, ProviderQueryDto>().ReverseMap();
            CreateMap<ProviderQueryDto, QuotationCreateInput>().ReverseMap();
            CreateMap<OfferResult, Provider.Models.Data>().ReverseMap();

            CreateMap<QuotationCreateDto, QuotationCreateInput>().ReverseMap();
        }
    }
}
