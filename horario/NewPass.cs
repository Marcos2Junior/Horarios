﻿using System;

namespace horario
{
    public class NewPass
    {
        /// <summary>
        /// Gerar senha aleatoria
        /// </summary>
        /// <param name="quantidade">quantidade de caracteres</param>
        /// <param name="caracteresEspeciais">true para permitir caracteres especiais</param>
        /// <param name="letrasMaiusculas">true para permitir letras maiusculas</param>
        /// <param name="numeros">true para permitir numeros</param>
        /// <param name="letrasMinusculas">true para letras minusculas</param>
        /// <returns>Retorna senha gerada</returns>
        public string Gerar(int quantidade, bool caracteresEspeciais, bool letrasMaiusculas, bool numeros, bool letrasMinusculas)
        {
            string result = "";

            Random r = new Random();

            for (int i = 0; i < quantidade; i++)
            {
                if (caracteresEspeciais && result.Length < quantidade)
                    result += Convert.ToChar(r.Next(35, 38));

                if (letrasMaiusculas && result.Length < quantidade)
                    result += Convert.ToChar(r.Next(65, 90));

                if (numeros && result.Length < quantidade)
                    result += r.Next(1, 9);

                if (letrasMinusculas && result.Length < quantidade)
                    result += Convert.ToChar(r.Next(97, 122));

                if (result.Length == quantidade)
                    break;
            }

            return result;
        }
    }
}