using PatronDeDiseño.Builder.Ejemplo2;

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


// Ejemplo 1 del patron Builder

VehiculoConstructor constructor;

// Instanciamos la clase director
Tienda tienda = new Tienda();

constructor = new MotocicletaConstructor();
tienda.Constructor(constructor);
constructor.Vehiculo.Mostrar();
