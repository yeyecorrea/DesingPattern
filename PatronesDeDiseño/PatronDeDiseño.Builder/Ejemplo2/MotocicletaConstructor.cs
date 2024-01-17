namespace PatronDeDiseño.Builder.Ejemplo2
{
    /// <summary>
    /// 
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
            vehiculo["chasis"] = "500 cc";
        }

        public override void ConstruirPuertas()
        {
            vehiculo["chasis"] = "2";
        }

        public override void ConstruirRuedas()
        {
            vehiculo["chasis"] = "0";
        }
    }
}
