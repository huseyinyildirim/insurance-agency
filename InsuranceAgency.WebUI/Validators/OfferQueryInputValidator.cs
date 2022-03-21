using FluentValidation;
using InsuranceAgency.WebUI.Models;

namespace InsuranceAgency.WebUI.Validators
{
    public class OfferQueryInputValidator : AbstractValidator<OfferQueryInput>
    {
        public OfferQueryInputValidator()
        {
            RuleFor(x => x.TCId).Length(11).NotEmpty().WithMessage("Lütfen kimlik numaranızı giriniz.");
        }
    }
}