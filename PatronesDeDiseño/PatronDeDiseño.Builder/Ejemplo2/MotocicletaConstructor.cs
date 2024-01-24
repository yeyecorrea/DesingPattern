namespace PatronDeDiseño.Builder.Ejemplo2
{
    /// <summary>
    /// clase constructora en concreto
    /// </summary>
    public class MotocicletaConstructor : VehiculoConstructor
    {
        public MotocicletaConstructor()
        {
            vehiculo = new Vehiculo("Motocicleta");
        }

        public override void ConstruirChasis()
        {
            vehiculo["chasis"] = "Chasis de motocicleta";
        }

        public override void ConstruirMotor()
        {
            vehiculo["motor"] = "500 cc";
        }

        public override void ConstruirPuertas()
        {
            vehiculo["puertas"] = "2";
        }

        public override void ConstruirRuedas()
        {
            vehiculo["ruedas"] = "0";
        }
    }
}
