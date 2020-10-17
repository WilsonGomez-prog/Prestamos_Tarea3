using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;

namespace Prestamos_Tarea3.Validacion
{
    public class ValidacionMonto : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            List<string> charNoValidos = new List<string>() { "¡", "!", "@", "=", "+", "*", "\\", "/", "<", ">", "|", ":", ";", "¿", "?" };

            if (value != null)
            {
                if (!ValidarNumeros(value.ToString()))
                {
                    return new ValidationResult(false, "Debes de poner un monto válido, que no contenga letras.");
                }
                else if (ValidarCaracteres(value.ToString(), charNoValidos))
                {
                    return new ValidationResult(false, "Debes de poner un monto válido, que no contenga ninguno de los siguientes caracteres: " + charNoValidos.ToString());
                }
                else
                {
                    double.TryParse(value.ToString(), out double money);

                    if (money < 0)
                    {
                        return new ValidationResult(false, "Debes de poner un monto válido, mayor a cero.");
                    }
                }

                return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "Debes de poner un monto válido.");
        }

        public bool ValidarCaracteres(string cadena, List<string> caracteres)
        {

            foreach (string invalido in caracteres)
            {
                if (cadena.Contains(invalido))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ValidarNumeros(string cadena)
        {

            foreach (char invalido in cadena.ToCharArray())
            {
                if (Char.IsLetter(invalido))
                {
                    return false;
                }
                else if (Char.IsWhiteSpace(invalido))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
