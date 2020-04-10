using System;
using System.Collections.Generic;

namespace ExemploBuilder_04
{
    class Veiculo

    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        // Constructor

        public Veiculo(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        // Indexer

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(" Tipo Veículo: {0}", _vehicleType);
            Console.WriteLine(" Estrutura : {0}", _parts["frame"]);
            Console.WriteLine(" Motor : {0}", _parts["engine"].Equals("0") ? "Não existe" : _parts["engine"]);
            Console.WriteLine(" #Rodas: {0}", _parts["wheels"].Equals("0") ? "Não existe" : _parts["wheels"]);
            Console.WriteLine(" #Portas : {0}", _parts["doors"].Equals("0") ? "Não existe" : _parts["doors"]);
        }
    }
}
