using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace VozPortugues
{
    public class Fala
    {
        private SpeechSynthesizer Sintetizador = new SpeechSynthesizer();

        public void BemVindo()
        {
            Sintetizador.Volume = 100;
            Sintetizador.Speak("Aí meu caralho... seja bem vindo porra!");
        }
    }
}
