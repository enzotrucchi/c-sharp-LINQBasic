class Alumno
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public int Nota { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var alumnosArray = new List<Alumno>
        {
            new Alumno { Nombre = "Juan", Edad = 18, Nota = 4 },
            new Alumno { Nombre = "Ana", Edad = 20, Nota = 9 },
            new Alumno { Nombre = "Pedro", Edad = 18, Nota = 6 },
            new Alumno { Nombre = "Luis", Edad = 18, Nota = 8 },
            new Alumno { Nombre = "Ana", Edad = 18, Nota = 7 },
            new Alumno { Nombre = "Sofía", Edad = 18, Nota = 10 },
        };

        Alumno[] alumnos = new Alumno[6];


        /*
         * Sin LINQ, enfoque tradicional
         */
        int i = 0;
 
        foreach(Alumno alumno in alumnosArray)
        {
            if (alumno.Nota >= 7)
            {
                alumnos[i] = alumno;
                i++;
                Console.WriteLine(alumno.Nombre);
            }
        }

        /*
         * Con LINQ
         */
        Alumno[] alumnosPromocionados = alumnosArray.Where(x => x.Nota >= 7).ToArray();

        Alumno[] alumnosAna = alumnosArray.Where(x => x.Nombre == "Ana").ToArray();

        Alumno primeraAna = alumnosArray.FirstOrDefault(x => x.Nombre == "Ana");

        foreach (var item in alumnosPromocionados)
        {
            Console.WriteLine(item.Nombre);
        }
        
        Console.WriteLine(alumnosAna);
        Console.WriteLine(primeraAna.Edad);

        // string collection
        IList<string> misLenguajes = new List<string>() {
            "C#",
            "VB",
            "C++",
            "Java",
            "PHP"
        };
        
        // Opción 1
        var resultado = from x in misLenguajes
                     where x.Contains("C")
                     select x;

        // Opción 2 (mismo resultado), utilizando lamba expression
        var resultado1 = misLenguajes.Where(x => x.Contains("C")).ToArray();

       foreach(var item in resultado)
       {
            Console.WriteLine(item);
       }
        
    }
}