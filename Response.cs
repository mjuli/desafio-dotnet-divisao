using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc_api
{
    public class Response
    {
        public Response(double resultado, string erro)
        {
            Resultado = resultado;
            Erro = erro;
        }
        public double Resultado { get; set; }
        public string Erro { get; set; }

    }
}