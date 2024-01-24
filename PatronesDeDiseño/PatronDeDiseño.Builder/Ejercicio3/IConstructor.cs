namespace PatronDeDiseño.Builder.Ejercicio3
{
    /// <summary>
    /// Interfaz (Builder) que define metodos para crear las diferentes partes de los objetos Producto
    /// </summary>
    public interface IConstructor
    {
        void ConstructorParteA();

        void ConstructorParteB();

        void ConstructorParteC();
    }
}
