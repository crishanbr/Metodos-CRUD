using ConsoleApp1.Models;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //agregarEstudiante();
        //consultarEstudiantes();
        //consultarEstudiante();
        //modificarEstudiante();
        //eliminarEstudiante();
        //consultarEstudiantesFunciones();

        //agregarCliente();
        //consultarClientes();
        //consultarCliente();
        //modificarCliente();
        //eliminarCliente();
        //consultarClientesFunciones();
    }

    //agregar estudiante
    public static void agregarEstudiante()
    {
        Console.WriteLine("Metodo agregar estudiante");
        SchoolContext context = new SchoolContext();
        Student std = new Student();
        std.Name = "Pedro";
        context.Students.Add(std);
        context.SaveChanges();
      
        Console.WriteLine("Codigo: "+ std.StudentId + " Nombre: "+ std.Name);

    }

    public static void consultarEstudiantes()
    {
        Console.WriteLine("Metodo consultar estudiantes");
        SchoolContext context = new SchoolContext();
        List<Student> listEstudiantes= context.Students.ToList() ;

        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.StudentId + " Nombre: " + item.Name);
        }
        
    }

    public static void consultarEstudiante()
    {
        Console.WriteLine("Metodo consultar estudiante por Id");
        SchoolContext context = new SchoolContext();
        Student std = new Student();
        std = context.Students.Find(11);

       Console.WriteLine("Codigo: " + std.StudentId + " Nombre: " + std.Name);
      
    }

    public static void modificarEstudiante()
    {
        Console.WriteLine("Metodo modificar estudiante");
        SchoolContext context = new SchoolContext();
        Student std = new Student();
        std = context.Students.Find(1);

        std.Name = "Anahi";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.StudentId + " Nombre: " + std.Name);

    }

    public static void eliminarEstudiante()
    {
        Console.WriteLine("Metodo eliminar estudiante");
        SchoolContext context = new SchoolContext();
        Student std = new Student();
        std = context.Students.Find(5);
        context.Remove(std);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + std.StudentId + " Nombre: " + std.Name);

    }
    public static void consultarEstudiantesFunciones()
    {
        Console.WriteLine("Metodo consultar estudiantes con el uso de funciones");
        SchoolContext context = new SchoolContext();
        List<Student> listEstudiantes;

        Console.WriteLine("Cantidad de registros: " + context.Students.Count());
        Student std = context.Students.First();

        Console.WriteLine("Primer elemento de la tabla:" +  std.StudentId +"-" +std.Name);

        //listEstudiantes = context.Students.Where(s => s.StudentId > 2 && s.Name == "Anita").ToList();

        //listEstudiantes = context.Students.Where(s => s.Name == "Patty" || s.Name == "Anita").ToList();

        listEstudiantes = context.Students.Where(s => s.Name.StartsWith("A")).ToList();
        
        /*
        var query = context.Students.GroupBy( s => s.Name) 
        .Select(g => new
        {
            Nombre = g.Key,
            Cantidad = g.Count()
        }). ToList();

        foreach (var result in query)
        {
            Console.WriteLine($"Nombre: {result.Nombre}, Cantidad: {result.Cantidad}");
        }
        */
        
        
        foreach (var item in listEstudiantes)
        {
            Console.WriteLine("Codigo: " + item.StudentId + " Nombre: " + item.Name);
        }
        

    }

    #region Tarea Metodos CRUD
    // Añadir cliente
    public static void agregarCliente()
    {
        Console.WriteLine("Metodo agregar cliente");
        SchoolContext context = new SchoolContext();
        Cliente cli = new Cliente();
        cli.Nombre = "Amelia";
        cli.Apellido = "Sanchez";
        cli.Dirección = "Al fondo a la derecha";
        cli.Teléfono = "091456874";
        cli.FechaNacimiento = new DateTime(2000, 5, 16);
        cli.Estado = "Activo";
        context.Clientes.Add(cli);
        context.SaveChanges();
        Console.WriteLine("Nuevo cliente añadido con exito");
    }

    // Consultar clientes
    public static void consultarClientes()
    {
        Console.WriteLine("Metodo consultar clientes");
        SchoolContext context = new SchoolContext();
        List<Cliente> listClientes = context.Clientes.ToList();
        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Nombre: " + item.Nombre + " Apellido: " + item.Apellido);
            
        }
    }

    // Consultar cliente
    public static void consultarCliente()
    {
        Console.WriteLine("Metodo consultar cliente por Id");
        SchoolContext context = new SchoolContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(11);
        Console.WriteLine("Codigo: " + cli.Id + " | Nombre: " + cli.Nombre + " | Apellido: " + cli.Apellido + " | Dirección: " + cli.Dirección + " | Teléfono: " + cli.Teléfono + " | Fecha Nacimiento: " + cli.FechaNacimiento + " | Estado: " + cli.Estado);
    }  

    // Modificar cliente
    public static void modificarCliente()
    {
        Console.WriteLine("Metodo modificar cliente");
        SchoolContext context = new SchoolContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(1);
        cli.Nombre = "Ambrosio";
        cli.Apellido = "Cañizares";
        cli.Dirección = "Al fondo a la izquierda";
        cli.Teléfono = "091456874";
        cli.FechaNacimiento = new DateTime(1984, 5, 16);
        cli.Estado = "Inactivo";
        context.SaveChanges();
        Console.WriteLine("Codigo: " + cli.Id + " | Nombre: " + cli.Nombre + " | Apellido: " + cli.Apellido + " | Dirección: " + cli.Dirección + " | Teléfono: " + cli.Teléfono + " | Fecha Nacimiento: " + cli.FechaNacimiento + " | Estado: " + cli.Estado);
    }

    // Eliminar cliente
    public static void eliminarCliente()
    {
        Console.WriteLine("Metodo eliminar cliente");
        SchoolContext context = new SchoolContext();
        Cliente cli = new Cliente();
        cli = context.Clientes.Find(2);
        context.Remove(cli);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + cli.Id + " Nombre: " + cli.Nombre);
    }

    #endregion
    public static void consultarClientesFunciones()
    {
        Console.WriteLine("Metodo consultar clientes con el uso de funciones");
        SchoolContext context = new SchoolContext();
        List<Cliente> listClientes;
        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente cli = context.Clientes.First();
        Console.WriteLine("Primer elemento de la tabla:" + cli.Id + "-" + cli.Nombre);
        //listClientes = context.Clientes.Where(s => s.Id > 2 && s.Nombre == "Anita").ToList();
        //listClientes = context.Clientes.Where(s => s.Nombre == "Patty" || s.Nombre == "Anita").ToList();
        listClientes = context.Clientes.Where(s => s.Nombre.StartsWith("A")).ToList();
        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " | Nombre: " + item.Nombre + " | Apellido: " + item.Apellido + " | Dirección: " + item.Dirección + " | Teléfono: " + item.Teléfono + " | Fecha Nacimiento: " + item.FechaNacimiento + " | Estado: " + item.Estado);
        }
    }
}