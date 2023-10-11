using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Custom
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola minimum {length} karakter olmalıdır."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola en az bir tane küçük karakter ('a'-'z') içermelidir ."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az bir alfanumerik olmayan karakter içermelidir."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description= "Parola en az bir büyük harf ('A'-'Z') içermelidir."
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
             return new IdentityError()
            {
                Code = "PasswordRequiresDigit",
                Description = "Parola en az bir rakam içermelidir. ('0'-'9')."
             };
        }
    }
}
