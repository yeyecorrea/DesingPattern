using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDiseño.Singleton.Ejemplo1
{
    /// <summary>
    /// Clase que contiene la estructura de una patron Singleton 
    /// </summary>
    public class Singleton
    {
        //1) Debe tener una propiedad estática (con un campo de respaldo privado) para devolver una instancia de una clase.
        // También se puede utilizar un método estático para devolver una instancia.
        private static Singleton _instance;

        // 2) Debe tener constructor privado o protegido. Sin constructores públicos y parametrizados
        private Singleton()
        {
                
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
                
            }
        }

        // 3) Debe tener  al menos un método público no estático para una operación singleton.
        public void DoSingletonOperation()
        {
            Console.WriteLine("Singleton operation");
        }
    }
}
