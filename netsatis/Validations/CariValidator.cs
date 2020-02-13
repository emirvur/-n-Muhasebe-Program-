using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using netsatis.tables;

namespace netsatis.Validations
{
    public class CariValidator : AbstractValidator<Cari>
    {
        public CariValidator()
        {
            RuleFor(p => p.CariKodu).NotEmpty().WithMessage("cari kodu alanı boş geçilemez");
            RuleFor(p => p.CariAdi).NotEmpty().WithMessage("cari adi alanı boş geçilemez");
            RuleFor(p => p.YetkiliKisi).NotEmpty().WithMessage(" alanı boş geçilemez");
            RuleFor(p => p.FaturaUnvani).NotEmpty().WithMessage("fatura  alanı boş geçilemez");
            RuleFor(p => p.Email).EmailAddress().WithMessage("email alanı boş geçilemez");
            RuleFor(p => p.IskontoOrani).GreaterThanOrEqualTo(0).WithMessage(" iskonto oranı 0 veya buyuk olmalı");
            RuleFor(p => p.RiskLimiti).GreaterThanOrEqualTo(0).WithMessage(" risk limiti 0 veya buyuk olmalı");
          
        }
    }

}
