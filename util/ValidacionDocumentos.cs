using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOO.util
{
    static class ValidacionDocumentos
    {
        public static bool Validar(string tipoElemento, char[] elemento)
        {
            bool f = false;
            if (tipoElemento == "cedula" || tipoElemento == "CEDULA")
            {
                f = ValidarCedula(elemento);
            }
            else if (tipoElemento == "rnc" || tipoElemento == "RNC")
            {
                f = ValidarRNC(elemento);
            }

            return f;
        }


        private static bool ValidarCedula(char[] ced)
        {
            char[] cedula = CLR(ced);
            int suma = 0;
            int division = 0;
            char[] peso = { '1', '2', '1', '2', '1', '2', '1', '2', '1', '2' };

            if (cedula.Length != 11)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!Char.IsDigit(cedula[i]))
                    {
                        return false;
                    }
                    int a = Convert.ToInt32(Char.GetNumericValue(cedula[i]));
                    int b = Convert.ToInt32(Char.GetNumericValue(peso[i]));

                    char[] mult = Convert.ToString(a * b).ToCharArray();

                    if (mult.Length > 1)
                    {
                        a = Convert.ToInt32(Char.GetNumericValue(mult[0]));
                        b = Convert.ToInt32(Char.GetNumericValue(mult[1]));
                    }
                    else
                    {
                        a = 0;
                        b = Convert.ToInt32(Char.GetNumericValue(mult[0]));
                    }

                    suma = suma + a + b;
                }

                division = (suma / 10) * 10;

                if (division < suma)
                {
                    division += 10;
                }

                int digito = division - suma;

                if (digito != Char.GetNumericValue(cedula[10]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidarRNC(char[] rnc)
        {
            char[] peso = { '7', '9', '8', '6', '5', '4', '3', '2' };

            int suma = 0;
            int division = 0;

            if (rnc.Length != 9)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    if (!Char.IsDigit(rnc[i]))
                    {
                        return false;
                    }

                    suma = suma + (Convert.ToInt32(Char.GetNumericValue(rnc[i]) * Char.GetNumericValue(peso[i])));
                }
            }

            division = suma / 11;
            int resto = suma - (division * 11);
            int digito = 0;

            if (resto == 0)
            {
                digito = 2;
            }
            else if (resto == 1)
            {
                digito = 1;
            }
            else
            {
                digito = 11 - resto;
            }

            if (digito != Char.GetNumericValue(rnc[8]))
            {
                return false;
            }

            return true;
        }

        public static bool Validar(char[] elemento)
        {
            bool resultado = false;
            if (elemento.Length == 11 || elemento.Length == 13)
            {
                resultado = ValidarCedula(elemento);

            }
            else if (elemento.Length == 9)
            {
                resultado = ValidarRNC(elemento);
            }

            return resultado;
        }

        private static char[] CLR(char[] a)
        {
            int y = 0;
            Char[] r = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                {

                    r[y] = a[i];
                    y++;
                }
            }
            char[] rr = new char[y];
            for (int x = 0; x < y; x++)
            {
                rr[x] = r[x];
            }
            return rr;
        }
    }
}
