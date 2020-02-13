using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using netsatis.tables;


namespace netsatis.Validations
{
    public class DepoValidator : AbstractValidator<Depo>
    {
        public DepoValidator()
        {
            RuleFor(p => p.DepoKodu).NotEmpty().WithMessage("depo kodu alanı boş geçilemez");
            RuleFor(p => p.DepoAdi).NotEmpty().WithMessage("depo adi alanı boş geçilemez");
        }
    }
}
