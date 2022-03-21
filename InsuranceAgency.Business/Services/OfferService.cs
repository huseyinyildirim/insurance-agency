using System;
using System.Collections.Generic;
using AutoMapper;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Data.Entities;
using InsuranceAgency.Data.Repository;
using InsuranceAgency.Shared;
using InsuranceAgency.Shared.Dtos;

namespace InsuranceAgency.Business.Services
{
    public class OfferService : IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IMapper _mapper;

        public OfferService(IMapper mapper, IOfferRepository offerRepository)
        {
            _mapper = mapper;
            _offerRepository = offerRepository;
        }

        public OfferService()
        {
        }

        public Response<List<OfferDto>> GetAllByTCId(string tcId)
        {
            var offers = _offerRepository.GetAllOfferByTCId(tcId);

            if (offers == null)
            {
                return Response<List<OfferDto>>.Fail(Messages.NOT_FOUND, HttpStatusCode.NOT_FOUND);
            }

            return Response<List<OfferDto>>.Success(_mapper.Map<List<OfferDto>>(offers), HttpStatusCode.OK);
        }

        public Response<OfferDto> Create(OfferCreateDto offerCreateDto)
        {
            var newOffer = _mapper.Map<Offer>(offerCreateDto);

            newOffer.CreatedAt = DateTime.Now;

            _offerRepository.CreateOffer(newOffer);

            return Response<OfferDto>.Success(_mapper.Map<OfferDto>(newOffer), HttpStatusCode.OK);
        }
    }
}
