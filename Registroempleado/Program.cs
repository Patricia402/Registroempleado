
Empleado[] empleado = new Empleado[10];

void agregarEmpleado(int pos)
{
    Console.Write("Nombres: ");
    empleado[pos].nombres = Console.ReadLine();
    Console.Write("Apellidos: ");
    empleado[pos].apellidos = Console.ReadLine();
    Console.Write("Cargo: ");
    empleado[pos].cargo = Console.ReadLine();
   Console.Write("Salario: ");
    empleado[pos].salario = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registro guardado satisfactoriamente");
    Console.ResetColor();
}
    struct Empleado
{
   public string nombre;
   public string apellido;
   public string cargo;
   public double salario;
}
