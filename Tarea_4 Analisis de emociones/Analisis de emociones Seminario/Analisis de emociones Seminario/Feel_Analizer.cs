using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace Analisis_de_emociones_Seminario
{
    public class Feel_Analizer
    {
        static MLContext mlContext = new MLContext();
        static PredictionEngine<Sentimiento, Prediccion> predictor;
        static List<string> palabrasPositivas = new List<string> { "feliz", "alegría", "excelente", "maravilloso", "bueno", "genial" };
        static List<string> palabrasNegativas = new List<string> { "triste", "malo", "horrible", "terrible", "odio", "pésimo" };
        static List<string> palabrasNeutrales = new List<string> { "ok", "normal", "meh", "regular", "aceptable", "indiferente", "neutral" };
       
        public string Run(string texto)
        {
            EntrenarModeloML();
            Prediccion resultadoML = PredecirConML(texto);

            string resultadoDiccionario = PredecirConDiccionario(texto);

            string resultadoFinal = CombinarPredicciones(resultadoML.PredictedLabel, resultadoDiccionario, resultadoML.Score);

            return resultadoFinal;
        }

        static void EntrenarModeloML()
        {
            string rutaArchivo = @"C:\Users\DIEGO\Desktop\Tareas_Seminario\Tarea_4 Analisis de emociones\Analisis de emociones Seminario\Analisis de emociones Seminario\sentimientos.csv";  // Cambia esta ruta
            IDataView datos = mlContext.Data.LoadFromTextFile<Sentimiento>(
                rutaArchivo, separatorChar: ',', hasHeader: true);

            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", nameof(Sentimiento.Texto))
                .Append(mlContext.Transforms.Conversion.MapValueToKey("Label"))
                .Append(mlContext.MulticlassClassification.Trainers.SdcaMaximumEntropy())
                .Append(mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

            var modelo = pipeline.Fit(datos);
            predictor = mlContext.Model.CreatePredictionEngine<Sentimiento, Prediccion>(modelo);
        }

        static Prediccion PredecirConML(string texto)
        {
            var entrada = new Sentimiento { Texto = texto };
            var resultado = predictor.Predict(entrada);
            return resultado;
        }

        static string PredecirConDiccionario(string texto)
        {
            if (palabrasPositivas.Any(p => texto.Contains(p)))
                return "positivo";
            if (palabrasNegativas.Any(p => texto.Contains(p)))
                return "negativo";
            if (palabrasNeutrales.Any(p => texto.Contains(p)))
                return "neutral";
            return "desconocido";
        }

        static string CombinarPredicciones(string ml, string diccionario, float[] score)
        {
            float confianzaPositivo = score[0];
            float confianzaNegativo = score[1];
            float confianzaNeutral = score[2];

            if (ml == diccionario)
                return ml;

            if ((ml == "positivo" && confianzaPositivo < 0.50) ||
                (ml == "negativo" && confianzaNegativo < 0.50) ||
                (ml == "neutral" && confianzaNeutral < 0.50))
            {
                return diccionario;
            }

            if (ml == "neutral" && (diccionario == "positivo" || diccionario == "negativo"))
            {
                return diccionario;
            }

            if ((ml == "positivo" && confianzaPositivo > 0.80) ||
                (ml == "negativo" && confianzaNegativo > 0.80) ||
                (ml == "neutral" && confianzaNeutral > 0.80))
            {
                return ml;
            }

            return diccionario != "desconocido" ? diccionario : ml;
        }
    }
}
