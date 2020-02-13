using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using netsatis.tables;

namespace netsatis.Validations
{
    public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(p => p.Turu).NotEmpty().WithMessage("turu  alanı boş geçilemez");
            RuleFor(p => p.Tanimi).NotEmpty().WithMessage("tanım adi alanı boş geçilemez");
        }
    }
}
