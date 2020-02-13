using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using netsatis.tables;

namespace netsatis.Validations
{
    public class OdemeTuruValidator : AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(p => p.OdemeTuruKodu).NotEmpty().WithMessage("odemeturu kodu alanı boş geçilemez");
            RuleFor(p => p.OdemeTuruAdi).NotEmpty().WithMessage("odemeturu adi alanı boş geçilemez");
        }
    }
}
