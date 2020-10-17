using System;
using System.Globalization;
using System.Windows.Controls;

namespace Prestamos_Tarea3.Validacion
{
    public class ValidacionFecha : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value != null)
            {
                DateTime date = new DateTime();
                DateTime.TryParse(value.ToString(), out date);

                if (date > DateTime.Now)
                    return new ValidationResult(false, "Debes de poner una fecha válida, menor a la actual.");

                return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "Debes de poner una fecha válida.");
        }
    }
}
