using static Dsw2026Ej8.Sale;

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

            //Product producto = new Product("Original");
            //Problema3 p3 = new Problema3();
            //string resultado = p3.CompararCopias(5, producto);
            //Console.WriteLine(resultado);

            //Problema4 p4 = new Problema4();
            //Console.WriteLine(p4.CalcularPromedio(8, 9, 10));     
            //Console.WriteLine(p4.CalcularPromedio(8, null, 10)); 
            //Console.WriteLine(p4.CalcularPromedio(null, null, null)); 
            //Console.WriteLine(p4.CalcularPromedio(8, 20, 10));

            // Problema5 p5 = new Problema5();
            //Sale ventaMinorista = new RetailSale { Amount = 1000 };
            //Sale ventaMayorista = new WholesaleSale { Amount = 1000 };
            //Console.WriteLine(p5.ObtenerImporteFinal(ventaMinorista)); 
            //Console.WriteLine(p5.ObtenerImporteFinal(ventaMayorista)); 

            Problema6 p6 = new Problema6();
            Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
        }
    }
}
