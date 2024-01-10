using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string VersaoIOS { get; set; }

        public Iphone(string numero, string modelo, string versaoIOS) : base(numero)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            VersaoIOS = versaoIOS;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Implementar a lógica específica para instalar aplicativo em um iPhone
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone {Modelo} com iOS {VersaoIOS}...");
        }
    }
}
