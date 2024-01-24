namespace PatronDeDiseño.Builder.Ejercicio3
{
    /// <summary>
    /// Tiene sentido usar el patrón Builder sólo cuando tus productos son
    // bastante complejo y requiere una configuración extensa.
    //
    // A diferencia de otros patrones creacionales, diferentes constructores concretos pueden
    // producir productos no relacionados. En otras palabras, resultados de varios constructores.
    // puede que no siempre siga la misma interfaz.
    /// </summary>
    public class Producto
    {
        private List<object> _partes = new List<object>();

        public void Añadir(string parte)
        {
            this._partes.Add(parte);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._partes.Count; i++)
            {
                str += this._partes[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return $"Partes del producto {str} \n";
        }
    }
}
