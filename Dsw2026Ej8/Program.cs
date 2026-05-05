namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ProductHelper helper = new ProductHelper();
            //string resultado = helper.ObtenerEtiquetaProducto(123, "Mouse", 5000);
            //Console.WriteLine(resultado);


            //Problema2 p2 = new Problema2();
            //Console.WriteLine(p2.CrearResumenVenta(1, "Mouse", 2, 5000));
            //Console.WriteLine(p2.CrearResumenVenta(2, "Teclado", 0, 10000));

            Product producto = new Product("Original");
            Problema3 p3 = new Problema3();
            string resultado = p3.CompararCopias(5, producto);
            Console.WriteLine(resultado);

        }
    }
}
