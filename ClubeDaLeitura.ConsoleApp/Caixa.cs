using System;
using System.Collections.Generic;

namespace ReadClub.ConsoleApp
{
    public enum CorCaixa
    {
        azul = 1,
        vermelha,
        preta,
        branca,
        rosa
    }

    public class Caixa
    {
        public string id;
        public CorCaixa cor;
        public string etiqueta;
        public string numeroCaixa;
        public List<Revista>Revistas = new List<Revista>();

        
    }
}
