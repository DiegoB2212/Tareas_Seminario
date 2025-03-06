using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisis_de_emociones_Seminario
{
    public class Sentimiento
    {
        [LoadColumn(0)]
        public string Texto { get; set; }

        [LoadColumn(1)]
        public string Label { get; set; }
    }
}
