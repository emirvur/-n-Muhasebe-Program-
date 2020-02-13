using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using netsatis.tables;

namespace netsatis.Validations
{
    public class StokValidator : AbstractValidator<Stok>
    {
        public StokValidator()
        {
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("stok kodu alanı boş geçilemez");
            RuleFor(p => p.StokAdi).NotEmpty().WithMessage("stok adi alanı boş geçilemez").Length(5, 50)
                .WithMessage("5 ile 50 karakter gir");
            RuleFor(p => p.Barkod).NotEmpty().WithMessage(" alanı boş geçilemez");
            RuleFor(p => p.StokKodu).NotEmpty().WithMessage("stok kodu alanı boş geçilemez");
            RuleFor(p => p.AlisFiyati1).GreaterThanOrEqualTo(0).WithMessage(" alıs fiyatı-1- 0 veya buyuk olmalı");
            RuleFor(p => p.AlisFiyati2).GreaterThanOrEqualTo(0).WithMessage(" alıs fiyatı-2- 0 veya buyuk olmalı");
            RuleFor(p => p.AlisFiyati3).GreaterThanOrEqualTo(0).WithMessage(" alıs fiyatı-3- 0 veya buyuk olmalı");
            RuleFor(p => p.SatisFiyati1).GreaterThanOrEqualTo(0).WithMessage(" alıs fiyatı -1-0 veya buyuk olmalı");
            RuleFor(p => p.SatisFiyati2).GreaterThanOrEqualTo(0).WithMessage(" alıs fiyatı -2-0 veya buyuk olmalı");
            RuleFor(p => p.SatisFiyati3).GreaterThanOrEqualTo(0).WithMessage(" alıs fiyatı -3-0 veya buyuk olmalı");
        }
    }
}
