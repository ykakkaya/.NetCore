using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidation:AbstractValidator<Writer>
    {
        public WriterValidation()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("ad kısmı boş olamaz");
            RuleFor(x => x.WriterPassword).Length(5).WithMessage("enaz 5 karakter olmalı");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("password kısmı boş olamaz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("mail kısmı boş olamaz");
            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("bu kısım boş olamaz");
        }
    }
}
