using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using netsatis.tables;
namespace netsatis.Validations
{
    public class KasaValidator : AbstractValidator<Kasa>
    {
        public KasaValidator()
        {
            RuleFor(p => p.KasaKodu).NotEmpty().WithMessage("kasa kodu alanı boş geçilemez");
            RuleFor(p => p.KasaAdi).NotEmpty().WithMessage("kasa adi alanı boş geçilemez");
        }
    }
}
