using FluentValidation;
using InsuranceAgency.WebUI.Models;

namespace InsuranceAgency.WebUI.Validators
{
    public class QuotationCreateInputValidator : AbstractValidator<QuotationCreateInput>
    {
        public QuotationCreateInputValidator()
        {
            RuleFor(x => x.Plate).NotEmpty().WithMessage("Lütfen plaka giriniz.");
            RuleFor(x => x.TCId).Length(11).NotEmpty().WithMessage("Lütfen kimlik numaranızı giriniz.");
            RuleFor(x => x.LicenseSerialCode).Length(2).NotEmpty().WithMessage("Lütfen ruhsat seri kodunu giriniz.");
            RuleFor(x => x.LicenseSerialNo).Length(6).NotEmpty().WithMessage("Lütfen ruhsat seri numaranızı giriniz.");
        }
    }
}