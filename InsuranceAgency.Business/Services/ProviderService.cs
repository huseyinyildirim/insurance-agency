using AutoMapper;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Provider;
using InsuranceAgency.Provider.Models;
using InsuranceAgency.Shared;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IMapper _mapper;
        IProvider _provider;

        public ProviderService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ProviderService(IProvider provider)
        {
            _provider = provider;
        }

        public Response<Offer> GetOffer(ProviderQueryDto providerQueryDto)
        {
            //var map = _mapper.Map<Quotation>(providerQueryDto);

            var result = _provider.GetOfferAsync(new Quotation()
            {
                Plate = providerQueryDto.Plate,
                TCId=providerQueryDto.TCId,
                LicenseSerialCode = providerQueryDto.LicenseSerialCode,
                LicenseSerialNo = providerQueryDto.LicenseSerialNo
            });

            if (result.IsFaulted == false)
            {
                if (result.Result.IsSuccessful)
                {
                    return Response<Offer>.Success(result.Result.Data, HttpStatusCode.NO_CONTENT);
                }
                else
                {
                    return Response<Offer>.Fail(result.Result.Errors, HttpStatusCode.NO_CONTENT);
                }
            }
            else
            {
                return Response<Offer>.Fail(result.Exception.Message, HttpStatusCode.BAD_REQUEST);
            }
        }
    }
}
