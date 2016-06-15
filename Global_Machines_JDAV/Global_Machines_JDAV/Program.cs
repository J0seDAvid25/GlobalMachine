using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Machines_JDAV
{
    class Program
    {
        static int opcion = 0;
        static int i = 0;
        static int size = 50;
        static string nivel;
        static string tipo;
        static int Productodescuento = 25;
        static int precioneto = 500 * 100;

        struct Producto
        {
            public int Productocodigo;
            public string Productoname;
            public int Productoprice;
            public string Productotype;
            public string ProductoFechaVencimiento;
            public string ProductoProveedor;
            public string ProductoPosicion;
            

        };
        static Producto[] Productos;

        static void IngresoProductos()////1
        {
            int aux = 0;
            while (aux != 1)
            {
                Console.Clear();
                if (i < Productos.Length)
                {
                    Console.WriteLine("*-    Global   Machines  -*");
                    Console.WriteLine("Ingreso de productos.             ");
                    Console.Write("Digite el codigo del producto:                  ");
                    Productos[i].Productocodigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del producto: ");
                    Productos[i].Productoname = Console.ReadLine();
                    Console.Write("Digite el tipo de producto:\n"  + "Nota: Ingrese el nombre" +
                        "\n1.Frituras" +
                        "\n2.Reposteria" +
                        "\n3.Refrescos Gaseosos" +
                        "\n4.Refrescos Naturales" +
                        "\n5.Confiteria\n");
                    tipo = Productos[i].Productotype = Console.ReadLine();
                    Console.WriteLine("Digite la fecha de vencimiento de ese producto");
                    Productos[i].ProductoFechaVencimiento = Console.ReadLine();
                    Console.WriteLine("Digite el nombre del proveedor de ese producto");
                    Productos[i].ProductoProveedor = Console.ReadLine();
                    Console.Write("Digite la posicion en el estante del producto:\n" +  "Nota: No digite el numero" +
                       "\n1.Nivel 1 Muy Alto" +
                       "\n2.Nivel 2 Alto" +
                       "\n3.Nivel 3 Intermedio" +
                       "\n4.Nivel 4 Bajo" +
                       "\n5.Nivel 5 Muy Bajo\n");
                    nivel = Productos[i].ProductoPosicion = Console.ReadLine();
                    Console.WriteLine("Digite el precio del producto a evaluar");
                    Productos[i].Productoprice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Desea agregar otro producto 0-Sí 1-No");
                    aux = int.Parse(Console.ReadLine());
                    i++;
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Registro de productos lleno..");
                    aux = 51;
                    Console.ReadKey();
                }

            }
        }
        static void Modificar()////////2
        {
            int CL = 0;

            while (CL != 1)
            {
                int Code = 0;
                Console.Clear();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("*-    Global   Machines  -*");
                Console.WriteLine("Ha elegido modificar el listado");
                Console.WriteLine("Digite el codigo del producto al que se desea editar");
                Code = int.Parse(Console.ReadLine());

                for (int i = 0; i < Productos.Length; i++)
                {
                    if (Productos[i].Productocodigo == Code)
                    {

                        Console.WriteLine("Ingreso de productos.             ");
                        Console.Write("Digite el codigo:                  ");
                        Productos[i].Productocodigo = int.Parse(Console.ReadLine());
                        Console.Write("Digite el nuevo nombre del producto:    ");
                        Productos[i].Productoname = Console.ReadLine();

                        Console.Write("Digite el nuevo tipo de producto  :   " +
                        "\n1.Frituras" +
                        "\n2.Reposteria" +
                        "\n3.Refrescos Gaseosos" +
                        "\n4.Refrescos Naturales" +
                        "\n5.Confiteria");
                        Productos[i].Productotype = Console.ReadLine();
                        Console.WriteLine("Digite la nueva fecha de vencimiento de ese producto");
                        Productos[i].ProductoFechaVencimiento = Console.ReadLine();
                        Console.WriteLine("Digite el nuevo nombre del proveedor de ese producto");
                        Productos[i].ProductoProveedor = Console.ReadLine();
                        Console.Write("Digite la nueva posicion en el estante del producto:   Nota: No digite el numero" +
                           "\n1.Nivel 1 Muy Alto" +
                           "\n2.Nivel 2 Alto" +
                           "\n3.Nivel 3 Intermedio" +
                           "\n4.Nivel 4 Bajo" +
                           "\n5.Nivel 5 Muy Bajo");
                        Productos[i].ProductoPosicion = Console.ReadLine();
                        Console.WriteLine("Digite el nuevo precio del producto a evaluar");
                        Productos[i].Productoprice = int.Parse(Console.ReadLine());
                        Console.WriteLine("El producto tiene descuento \n 1. Si 2. No");
                        Productodescuento = int.Parse(Console.ReadLine());

                        i++;
                    }
                }
                Console.WriteLine("Desea modificar otro producto 0-Sí 1-No");
                CL = int.Parse(Console.ReadLine());
                Console.ReadKey();
            }
        }
        static void Eliminar_Informacion()////////////////3
        {
            int Cont = 0;

            while (Cont != 1)
            {
                int cdgo = 0;
                Console.Clear();
                Console.WriteLine("*-    Global   Machines  -*");
                Console.WriteLine("Borrado  de productos.           ");
                Console.WriteLine("Digite el code del producto a eliminar");
                cdgo = int.Parse(Console.ReadLine());
                for (int i = 0; i < Productos.Length; i++)
                {
                    if (Productos[i].Productocodigo == cdgo)
                    {

                        Productos[i].Productoname = "";
                        Productos[i].Productotype = "";
                        Productos[i].ProductoFechaVencimiento = "";
                        Productos[i].ProductoProveedor = "";
                        Productos[i].ProductoPosicion = "";
                        Productos[i].Productoprice = 0;
                        i++;
                    }
                }
                Console.WriteLine("Desea eliminar otro producto 0-Sí 1-No");
                Cont = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.ReadKey();
            }
        }

        static void BuscarProductos()////////////////4
        {

            int codigo = 0;
            int reg = 0;
            int aux = 0;
            bool found = false;
            while (aux != 1)
            {
                Console.Clear();
                Console.WriteLine("*-    Global   Machines  -*");
                Console.WriteLine("Búsqueda de productos           ");
                Console.WriteLine("Digite el code del producto a buscar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < Productos.Length; i++)
                {
                    if (codigo == Productos[i].Productocodigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:       " + Productos[i].Productocodigo);
                        Console.WriteLine("Nombre:   " + Productos[i].Productoname);
                        Console.WriteLine("Tipo: " + Productos[i].Productotype);
                        Console.WriteLine("Fecha de vencimiento: " + Productos[i].ProductoFechaVencimiento);
                        Console.WriteLine("Nombre del proveedor: " + Productos[i].ProductoProveedor);
                        Console.WriteLine("Posicion de estante: " + Productos[i].ProductoPosicion);
                        Console.WriteLine("Precio: " + Productos[i].Productoprice);

                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontró ese Codigo en el registro");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                aux = int.Parse(Console.ReadLine());
                Console.ReadKey();
            }
        }

        static void MostrarProductos() //5
        {
            int reg = 0;
            Console.Clear();
            for (i = 0; i < 5; i++)
            {
                if (Productos[i].Productocodigo != 0)
                {
                    reg = i + 1;


                    Console.WriteLine("============================================================================");
                    Console.WriteLine("*-                         Global   Machines                              -*");
                    Console.WriteLine("============================================================================");
                    Console.WriteLine("                        Listado de Productos                  ");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("--------------------------|||||---------------------------");
                    Console.Write("Reg: || " + "Codigo || " + "||  Nombre|| " + "|| Tipo|| " + "|| Vencimiento|| " + "|| Proveedor|| " + "|| Posicion|| " + "||  Precio|| " + "\n");
                    Console.Write(Productos[i].Productocodigo + Productos[i].Productoname + Productos[i].Productotype + Productos[i].ProductoFechaVencimiento + Productos[i].ProductoProveedor + Productos[i].ProductoPosicion + Productos[i].Productoprice);


                    Console.WriteLine("============================================================================");
                    Console.WriteLine("*-                         Global   Machines                              -*");
                    Console.WriteLine("============================================================================");
                    Console.WriteLine("                        Informe de Inventario                             ");
                    Console.WriteLine("============================================================================");
                    Console.WriteLine("\tClasificacion\t" + "\t Cantidad\t");
                    Console.WriteLine("--------------------------|||||---------------------------");
                    Console.WriteLine("\t", Productos[i].Productotype, "34");

                    Console.WriteLine("\tNivel\t" + "\tCantidad\t");
                    Console.WriteLine("--------------------------|||||---------------------------");
                    Console.WriteLine("\t", nivel, "7");
                    Console.WriteLine("==============================================");

                }


            }
            Console.WriteLine("============================================");
            Console.WriteLine("Fin de muestra");
            Console.ReadKey();
        }




        static void VentaProductos()
        {
            string nombre;
            string telefono;
            int cantidad = 0;
             int montorecibo;
             int montocambio;
            int montopagado;
            int aux = 0;
            while (aux != 1)
            {
                Console.Clear();
                for (int i = 0; i < Productos.Length; i++)
                {


                    Console.WriteLine("============================================================================");
                    Console.WriteLine("*-                         Global   Machines                              -*");
                    Console.WriteLine("Digite el nombre del cliente ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Digite el telefono del cliente ");
                    telefono = Console.ReadLine();
                    Console.WriteLine("*-                         Global   Machines                              -*");
                    Console.WriteLine("               ----Seleccion de productos----                ");
                    Console.WriteLine("\t", Productos[i].Productocodigo, +Productos[i].Productoprice);
                    montorecibo = cantidad * Productos[i].Productoprice;
                    montorecibo = cantidad * 5;
                    Console.WriteLine("El monto a pagar es ¢" + montorecibo + "5340");

                    Console.WriteLine("Digite el monto con el que va a pagar");
                    montopagado = int.Parse(Console.ReadLine());
                    montocambio = montorecibo - montopagado;
                    Console.WriteLine("El cambio es de ¢" + montocambio);


                    Console.WriteLine("Impresion de la factura");

                    Console.WriteLine("===================================================================");
                    Console.WriteLine("*-*                   Global   Machines                     *-*");
                    Console.WriteLine("===================================================================");
                    Console.WriteLine(" Factura Proforma\t\t\t\t\t    N°0001");
                    Console.WriteLine(" Cliente : " + nombre);
                    Console.WriteLine(" Teléfono: " + telefono);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine(" Item\t\t\t\tCtd\tPrecio\t\tSubTotal");
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.Write( Productos[i].Productoname);
                    Console.Write("\t" + "1");
                    Console.Write("\t¢" +   Productos[i].Productoprice);
                    Console.WriteLine("\t¢"    + Productos[i].Productoprice);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.Write(" Total Orden:    \t\t\t\t\t");
                    Console.WriteLine("¢" + "10000");
                    Console.Write(" Total Descuento:    \t\t\t\t\t");
                    Console.WriteLine("¢" + Productodescuento);
                    Console.Write(" Impuesto Venta: \t\t\t\t\t");
                    Console.WriteLine("13" + "%");
                    Console.Write(" Impuesto Total: \t\t\t\t\t");
                    Console.WriteLine("¢" + Productodescuento);
                    Console.Write(" Precio Neto:    \t\t\t\t\t");
                    Console.WriteLine("¢" + precioneto);
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.Write(" Monto Recibido:");
                    Console.WriteLine("¢" + montorecibo);
                    Console.Write(" Monto Cambio :");
                    Console.WriteLine("¢" + montocambio);
                    Console.WriteLine("==============================================================================================================\n");
                    Console.WriteLine("Gracias por su compra");
                    Console.WriteLine("------------------Que tenga buen dia---------------------");
                    Console.WriteLine("==============================================================================================================\n");
                    Console.ReadKey();
                    Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                    aux = int.Parse(Console.ReadLine());
                    Console.ReadKey();
                }
            }
        }
    

    static void Main()
    {
        Productos = new Producto[size];
        do
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("      Bienvenido sea");
            Console.WriteLine("*-    Global   Machines  -*");
            Console.WriteLine("==========================================");
            Console.WriteLine("1.-Ingreso de productos ");
            Console.WriteLine("2.-Modificacion de productos");
            Console.WriteLine("3.-Eliminacion de productos");
            Console.WriteLine("4.-Busquedas de productos");
            Console.WriteLine("5.-Listado de productos");
            Console.WriteLine("6.-Venta de productos");
            Console.WriteLine("7.-Salir");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1://////
                    IngresoProductos();
                    break;
                case 2:
                    Modificar();
                    break;
                case 3://////
                    Eliminar_Informacion();
                    break;
                case 4:
                    BuscarProductos();
                    break;
                case 5://////
                    MostrarProductos();
                    break;
                case 6:
                    VentaProductos();
                    break;
                case 7://////
                    Console.WriteLine("Ha elegido salir");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    
            }


        }
        while (opcion != 7);

    }
}
}
