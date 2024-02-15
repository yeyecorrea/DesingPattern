using PatronDeDiseño.Builder.Ejemplo2;
using PatronDeDiseño.Singleton.Ejemplo1;
using PatronesDeDiseño.Prototype.Ejemplo1;
using PatronesDeDiseño.Prototype.Ejemplo2;

//// Invocacion del ejemplo 1

//ICreditCard creditCard = new PlatinumFactory().CreateProdut();
//if (creditCard != null)
//{
//    Console.WriteLine($"Card Type: {creditCard.GetCardType()}");
//    Console.WriteLine($"Credit Limit: {creditCard.GetCreditLimit()}");
//    Console.WriteLine($"Annual Charge: {creditCard.GetAnnualCharge()}");

//}else
//{
//    Console.WriteLine("Invalid Card Type");
//}

//// Invocacion del ejemplo 2

//IAutomovil automovil = new CarroFactory().CreateAutomovil();
//if (automovil != null)
//{
//    Console.WriteLine("C");
//}


//// Ejemplo 1 del patron Builder

//VehiculoConstructor constructor;

//// Instanciamos la clase director
//Tienda tienda = new Tienda();

//constructor = new MotocicletaConstructor();
//tienda.Constructor(constructor);
//constructor.Vehiculo.Mostrar();


// Ejemplo 1 del patron Prototype

//// se crea un objecto d ela clase concreta
//var prototype = new ConcretePrototypeA { PropertyA = 10 };

//// usamos el prototype para crear distintos objectos
//Client.CreateObject(prototype);
//Client.CreateObject(prototype);

//// editamos el valor de la propiedad y creamos una nueva instancia con la actualizacion
//prototype.PropertyA = 15;
//Client.CreateObject(prototype);

// Ejemplo 2 del patron Prototype

Singleton s1 = Singleton.Instance;

Singleton s2 = Singleton.Instance;

// se valida si es la misma instancia, este ejemplo no funciona para subprocesos
Console.WriteLine(s1 == s2);

