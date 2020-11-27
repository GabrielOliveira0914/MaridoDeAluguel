using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Model;
using Teste.Service.Interface;

namespace Teste.Service
{
    public class TesteService : ITesteService
    {
        public string IMC(IndiceMC imc)
        {
            float result;
            string texto;
            result = imc.Peso / (imc.Altura * imc.Altura);

            if (result <= 18.5)
            {
                texto = "Peso baixo";
            }else if (result <= 24.9)
            {
                texto = " Peso normal";
            }else if (result <= 29.9)
            {
                texto = "Sobrepeso";
            }else if (result <= 34.9)
            {
                texto = "Obesidade (Grau 1)";
            }else if (result <= 39.9)
            {
                texto = "Obesidade Severa (Grau 2)";
            }else
            {
                texto = "Obesidade Mórbida (Grau 3)";
            }

            return ("Seu IMC é " + result + " e você está com " + texto);
        }
    }
}
