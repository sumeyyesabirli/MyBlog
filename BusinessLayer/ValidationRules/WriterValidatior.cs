using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidatior: AbstractValidator<Writer>
    {
        public WriterValidatior()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Bırakmayınız");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soy Adını Boş Bırakmayınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını Boş Bırakmayınız");
           // RuleFor(x => x.WriterAbout).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi içermelidir");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Değer Giriniz");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 Karakter Fazla Değer Girişi Yapmayınız");
        }
    }
}
