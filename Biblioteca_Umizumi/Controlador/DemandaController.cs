using System;
using System.Diagnostics;

namespace Biblioteca_Umizumi.Controlador
{
    public class DemandaController
    {
        public string EjecutarPrediccion(int idLibro, DateTime fecha)
        {
            int dia = fecha.Day;
            int mes = fecha.Month;
            int anio = fecha.Year;
            int diaSemana = (int)fecha.DayOfWeek;

            var psi = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = $"\"C:\\Users\\manue\\Documents\\Contenido UMG\\7mo Ciclo 2025\\Base de Datos ll\\Modelo Predictivo\\predecir_demanda.py\" {idLibro} {dia} {mes} {anio} {diaSemana}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var proceso = Process.Start(psi))
            {
                string salida = proceso.StandardOutput.ReadToEnd();
                string errores = proceso.StandardError.ReadToEnd();
                proceso.WaitForExit();

                if (!string.IsNullOrEmpty(errores))
                    return $"❌ Error en Python: {errores}";

                return salida;
            }
        }

    }
}
