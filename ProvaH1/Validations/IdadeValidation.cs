using System.ComponentModel.DataAnnotations;

namespace ProvaH1.Validations
{
    public class IdadeValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            return (int)value <= 15;
        }
    }
}
