using System.Globalization;
using System.Windows.Controls;

namespace WpfComboBoxErrorTemplate
{
    public sealed class CustomValidationRule : ValidationRule
    {
        public bool IsValid;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (IsValid) return ValidationResult.ValidResult;

            return new ValidationResult(false, "Something went wrong");
        }
    }
}
