using System.Reflection;
using System.Text.Json;
using System.Threading.Channels;

namespace Clase2Modulo2
{
    internal class Program
    {

        //public delegate void ImprimirDelegate(string message);

        static void Main(string[] args)
        {

            #region Exceptions
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Ingrese un nombre");
            //        var input = Console.ReadLine();
            //        Console.WriteLine(input);
            //        //Conexion a un SQL 

            //        var result = JsonSerializer.Deserialize<Persona>("");


            //    }
            //    catch (ArgumentNullException ex)
            //    {
            //        Console.WriteLine("El parametro esta vacio...");
            //    }
            //    catch (JsonException ex)
            //    {
            //        Console.WriteLine("Ocurrio un error a la hora de deserializar");
            //    }
            //    catch (Exception ex)
            //    {
            //        //Guardar la informacion
            //        Console.WriteLine("Error general");
            //    }
            //    finally 
            //    {
            //        //Mantenimiento
            //    }



            //}
            //string edadString = "30a";

            ////int edad = int.Parse(edadString);

            //int edad = 0;


            // bool flagConversion =   int.TryParse(edadString, out edad);


            //if (flagConversion)
            //{
            //    Console.WriteLine($"Convertido correctamente valor: {edad}");
            //}
            //else 
            //{
            //    Console.WriteLine("No se pudo convertir el dato...");
            //}

            #endregion

            #region Delegates
            //var functionImprimir = Imprimir;
            //functionImprimir();

            //Pasarle una funcion nombrada/ explicita
            //var result =   Imprimir("data", ImpresoraComun);

            //var result2 = Imprimir("data2", ImpresoraPDF);


            //Pasarle una funcion anonima 

            //var result = Imprimir("data", (string mensaje)  => { Console.WriteLine($"Impreso desde impresora comun: {mensaje}"); }  );

            //var result2 = Imprimir("data2", (string mensaje ) => Console.WriteLine($"Impreso desde PDF : {mensaje}")  );


            //Action => Guardar referencia funciones que no van a devolver nada (void) 
            //Func => guardar referencia a funciones que van a devolver un valor 
            //Predicate  => guardar referencia a funciones que van a devolver un bool


            //var result = Imprimir("data", (string mensaje) => { Console.WriteLine("Impresion PDF"); });


            //Action<string> action = (string pers) => { Console.WriteLine("Hola"); };

            //Func<string,string,string> func = (string param1, string param2) => { return "string"; };


            #endregion


            #region LINQ

            var lstEdades = new List<int>() { 20 ,12, 5, 52, 77, 33, 21};

            //var lstEdadesFiltradas = new List<int>();

            //foreach (int edad in lstEdades) 
            //{
            //    if (edad >= 20) 
            //    {
            //        lstEdadesFiltradas.Add(edad);
            //    }

            //}


            //foreach (int edad in lstEdadesFiltradas) 
            //{
            //    Console.WriteLine(edad);
            //}

            //Foreach 
            //var lstEdadesFiltrada = lstEdades.Where(w => w >= 20);

            //foreach (var edad in lstEdadesFiltrada)
            //{
            //    Console.WriteLine(edad);
            //}


            // Si hay al menos una persona que tenga menos de 21 años 

            //var hayMenoresEdad = lstEdades.Any( edad => edad < 21  );


            //if (hayMenoresEdad)
            //{
            //    Console.WriteLine("no puedo ejecutar el programa");
            //}
            //else 
            //{
            //    Console.WriteLine("Entraste al programa");
            //}

            //bool result = lstEdades.All(edad => edad >= 21);


            var lstPersonas = new List<Persona>()
            {
                new Persona() { Nombre = "Andres", Apellido = "Bustos", Edad = 30, Direccion = new Direccion() { Calle = "calle1", CP ="1439" } },


            };



            ////bool todosMayorEdad = lstPersonas.All(persona => persona.Edad >= 21);

            //var lstNombres = lstPersonas.Select(s => new  { Nombre = s.Nombre, Apellido = s.Apellido , s.Direccion.Calle  } ).ToList();


            var edadesOrdenadas = lstPersonas.OrderBy( o=> o.Edad).ToList();

            lstPersonas.ForEach(f =>
            {
                Console.WriteLine(f.Apellido);

            });

            
            #endregion
        }



        public class PersonaDTO 
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
        }

        static string GetName() { return ""; }
        static void ImpresoraComun(string mensaje) 
        {

            //Gran logica para mmandarlo a una impresora comun...

            Console.WriteLine($"Impreso desde impresora comun: {mensaje}");
        }

        static void ImpresoraPDF(string mensaje)
        {

            //Gran logica para mmandarlo a un PDF...

            Console.WriteLine($"Impreso desde PDF : {mensaje}");
        }

        static string Imprimir(string message ,Action<string> functionCliente) 
        {
            //Validaciones
            //Logica de negocio
            //Imprimir => impresora/ PDF 
            message = message.ToUpper();
      
            
            functionCliente(message); //Ejecuitar una funcion
            return $"Se imprimio correctamente {message}";
        
        }



        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int  Edad { get; set; }
            public Direccion Direccion { get; set; }
            

        }
        public class Direccion 
        {
            public string Calle { get; set; }
            public string CP { get; set; }
        }

    }
}