using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio_CSharp
{
    class QuizeInfo
    {
        public string[] respostas;
        public string respostaCorreta = string.Empty;
        public string Questao = string.Empty;
        public string SelecionarResposta = "";
        public void InitArray()
        {
            respostas = new string[4];
        }

   
    }
}
