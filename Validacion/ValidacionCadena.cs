using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;

namespace Prestamos_Tarea3.Validacion
{
    public class ValidacionCadena : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            List<string> charNoValidos = new List<string>() { "¡", "!", "@", "=", "+", "*", "\\", "/", "<", ">", "|", ":", ";", "¿", "?" };

            if (value != null)
            {
                string cad = value.ToString();

                if (string.IsNullOrWhiteSpace(cad))
                {
                    return new ValidationResult(false, "Debes de poner un texto válido, que no sea solo un espacio en blanco.");
                }
                else if (!(!cad.Equals(cad.ToLower())))
                {
                    return new ValidationResult(false, "Debes de poner un texto válido, El texto debe de contener mínimo una mayúscula al inicio.");
                }
                else if (cad.Length > 100)
                {
                    return new ValidationResult(false, "Debes de poner un texto válido, excedió el tamaño permitido.");
                }
                else if (!ValidarCaracteres(cad, charNoValidos))
                {
                    return new ValidationResult(false, "Debes de poner un texto válido, que no contenga ninguno de los siguientes caracteres: " + charNoValidos.ToString());
                }

                return ValidationResult.ValidResult;
            }

            return new ValidationResult(false, "Debes de poner un texto válido.");
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
    }
}