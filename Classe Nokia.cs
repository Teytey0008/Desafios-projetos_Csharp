using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Nokia(string numero) : base(numero)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Implementar a lógica específica para instalar aplicativo em um Nokia
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia...");
        }
    }
}
