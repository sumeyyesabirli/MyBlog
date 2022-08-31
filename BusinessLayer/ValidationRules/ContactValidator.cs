using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini Boş Bırakmayınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Bırakmayınız");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Bırakmayınız");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lüften en az 3 Karakter Girşi Yapınız");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lüften en az 3 Karakter Girşi Yapınız");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("Lüften 50  Karakterden  Fazla Girş Yapmayınız");
        }

    }
}
