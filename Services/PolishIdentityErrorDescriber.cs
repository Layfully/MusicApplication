using Microsoft.AspNetCore.Identity;

namespace MusicApplication.Services
{
    public class PolishIdentityErrorDescriber : IdentityErrorDescriber
    {
        public PolishIdentityErrorDescriber()
        {
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError() { Code = base.ConcurrencyFailure().Code, Description = "Optymistyczna awaria współbieżności, obiekt został zmodyfikowany."};
        }

        public override IdentityError DefaultError()
        {
            return new IdentityError() { Code = base.DefaultError().Code, Description = "Wystąpił nieznany błąd."};
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError() { Code = base.DuplicateEmail(email).Code, Description = "Email '{0}' jest już zajęty."};
        }

        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError() { Code = base.DuplicateRoleName(role).Code, Description = "Nazwa roli '{0}' jest już zajęta." };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError() { Code = base.DuplicateUserName(userName).Code, Description = "Nazwa użytkownika '{0}' jest już zajęta."};
        }

        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError() { Code = base.InvalidEmail(email).Code, Description = "Email '{0}' jest nieprawidłowy." };
        }

        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError() { Code = base.InvalidRoleName(role).Code, Description = "Nazwa roli '{0}' jest nieprawidłowa." };
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError() { Code = base.InvalidToken().Code, Description = "Nieprawidłowy token."};
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError() { Code = base.LoginAlreadyAssociated().Code, Description = "Użytkownik z tym loginem już istnieje."};
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError() { Code = base.PasswordMismatch().Code, Description = "Nieprawidłowe hasło."};
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError() { Code = base.PasswordRequiresDigit().Code, Description = "Hasła muszą mieć co najmniej jedną cyfrę (0-9)."};
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError() { Code = base.PasswordRequiresLower().Code, Description = "Hasła muszą mieć co najniej jedną małą literę (a-z)."};
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError() { Code = base.PasswordRequiresNonAlphanumeric().Code, Description = "Hasła muszą mieć co najmniej jeden znak niealfanumeryczny."};
            }

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError() { Code = base.PasswordRequiresUniqueChars(uniqueChars).Code, Description = "Hasła muszą zawierać co najmniej {0} różnych znaków."};
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError() { Code = base.PasswordRequiresUpper().Code, Description = "Hasła muszą mieć co najmniej jedną wielką literę ('A'-'Z')."};
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError() { Code = base.PasswordTooShort(length).Code, Description = "Hasła muszą mieć co najmniej {0} znaków." };
        }

        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError() { Code = base.UserAlreadyHasPassword().Code, Description = "Użytkownik ma już ustawione hasło." };
        }

        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError() { Code = base.UserAlreadyInRole(role).Code, Description = "Użytkownik pełni już rolę '{0}'." };
        }

        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError() { Code = base.UserLockoutNotEnabled().Code, Description = "Blokada nie jest włączona dla tego użytkownika." };
        }

        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError() { Code = base.UserNotInRole(role).Code, Description = "Użytkownik nie ma roli '{0}'."};
        }

        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError() { Code = base.InvalidUserName(userName).Code, Description = "Nazwa użytkownika '{0}' jest nieprawidłowa, może zawierać tylko litery lub cyfry." };
        }

        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError() { Code = base.RecoveryCodeRedemptionFailed().Code, Description = "Wykorzystanie kodu odzyskiwania nie powiodło się." };
        }
    }
}
