Console.Clear();

Console.WriteLine("Este programa calcula la superficie de un rectangulo");

//decimal v = decimal.Parse("222");

//string baseRectanguloTexto = Console.ReadLine();
//double baseRectangulo = double.Parse(baseRectanguloTexto);

Console.WriteLine("ingrese la base del rectangulo: ");

double baseRectangulo = double.Parse(Console.ReadLine());

Console.WriteLine("ingrese la altura del rectangulo: ");

double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.WriteLine("la superficie del rectangulo es " + superficieRectangulo);

bool esMayorADiez = superficieRectangulo > 10;

if (esMayorADiez)
{
    //mostrar el mensaje solo si es mayor a diez
    Console.WriteLine("La superficie del rectangulo es mayor.");

} else
{
    //mostrar el mensaje solo si es menor a diez
    Console.WriteLine("La superficie del rectangulo es menor.");

}

Console.ReadKey();