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
            Console.WriteLine("Vehicle Type: {0}", _tipoVehiculo);
            Console.WriteLine(" Frame : {0}", _partes["frame"]);
            Console.WriteLine(" Engine : {0}", _partes["engine"]);
            Console.WriteLine(" #Wheels: {0}", _partes["wheels"]);
            Console.WriteLine(" #Doors : {0}", _partes["doors"]);
        }
    }
}
