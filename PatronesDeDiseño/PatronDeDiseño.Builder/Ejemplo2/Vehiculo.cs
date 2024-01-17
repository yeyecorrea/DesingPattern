namespace PatronDeDiseño.Builder.Ejemplo2
{
    /// <summary>
    /// Clase producto
    /// </summary>
    public class Vehiculo
    {
        private string _tipoVehiculo;
        private Dictionary<string, string> _partes = new Dictionary<string, string>();

        // Constructor de la clase
        public Vehiculo(string tipoVehiculo)
        {
            _tipoVehiculo = tipoVehiculo;
        }

        // Getter y Setter
        public string this[string key]
        {
            get { return _partes[key]; }
            set { _partes[key] = value; }
        }

        public void Mostrar()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo de Vehiculo: {0}", _tipoVehiculo);
            Console.WriteLine(" chasis : {0}", _partes["chasis"]);
            Console.WriteLine(" motor : {0}", _partes["motor"]);
            Console.WriteLine(" #reudas: {0}", _partes["ruedas"]);
            Console.WriteLine(" #puertas : {0}", _partes["puertas"]);
        }
    }
}
