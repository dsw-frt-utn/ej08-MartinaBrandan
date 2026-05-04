namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var helper = new ProductHelper();

            string resultado = helper.ObtenerEtiquetaProducto(123, "Mouse", 5000);

            Console.WriteLine(resultado);
        }
    }
}
