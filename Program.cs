using Tareas;

//Creo unas 5 tareas
Tarea tarea1 = new Tarea(1, 'a', 3);
Tarea tarea2 = new Tarea(2, 'b', 5);
Tarea tarea3 = new Tarea(3, 'c', 1);
Tarea tarea4 = new Tarea(4, 'd', 2);
Tarea tarea5 = new Tarea(5, 'e', 4);

//Creo la lista de pendientes y le agrego las tareas
List<Tarea> tareasPendientes = new List<Tarea>() { tarea1, tarea2, tarea3, tarea4, tarea5 };
//tambien se puede crear la lista vacia y agregar cada tarea con el tareasPendientes.Add(tarea1)
//Creo la lista de tareas realizadas
List<Tarea> tareasRealizadas = new List<Tarea>();

//Muestro las listas de tareas con un foreach
Console.WriteLine(">>>TAREAS PENDIENTES<<<");
foreach (var tarea in tareasPendientes)
{
    Console.WriteLine("----------");
    Console.WriteLine("ID: " + tarea.Id);
    Console.WriteLine("Descripcion: " + tarea.Descripcion);
    Console.WriteLine("Duracion: " + tarea.Duracion);
}
Console.WriteLine(">>>----------------<<<");
Console.WriteLine(">>>TAREAS REALIZADAS<<<");
foreach (var tarea in tareasRealizadas)
{
    Console.WriteLine("----------");
    Console.WriteLine("ID: " + tarea.Id);
    Console.WriteLine("Descripcion: " + tarea.Descripcion);
    Console.WriteLine("Duracion: " + tarea.Duracion);
}
Console.WriteLine(">>>----------------<<<");

Console.WriteLine("Ingrese el id de la tarea que desea mover a realizadas");
string idIngresado = Console.ReadLine();
int idMover;
if (int.TryParse(idIngresado, out idMover))
{
    Tarea tareaMover = null;//guardo aqui una copia de la tarea a mover
    foreach (var tarea in tareasPendientes)
    {
        if (tarea.Id == idMover)
        {
            tareaMover = tarea;
        }
    }
    if (tareaMover != null)
    {
        tareasPendientes.Remove(tareaMover);
        tareasRealizadas.Add(tareaMover);
    }
    else
    {
        Console.WriteLine("No se encontro la tarea con el id especificado");
    }
}
else
{
    Console.WriteLine("No se pudo realizar el ingreso del id");
}



Console.WriteLine(">>>TAREAS PENDIENTES<<<");
foreach (var tarea in tareasPendientes)
{
    Console.WriteLine("----------");
    Console.WriteLine("ID: " + tarea.Id);
    Console.WriteLine("Descripcion: " + tarea.Descripcion);
    Console.WriteLine("Duracion: " + tarea.Duracion);
}
Console.WriteLine(">>>----------------<<<");
Console.WriteLine(">>>TAREAS REALIZADAS<<<");
foreach (var tarea in tareasRealizadas)
{
    Console.WriteLine("----------");
    Console.WriteLine("ID: " + tarea.Id);
    Console.WriteLine("Descripcion: " + tarea.Descripcion);
    Console.WriteLine("Duracion: " + tarea.Duracion);
}
Console.WriteLine(">>>----------------<<<");

Console.WriteLine("Ingrese la descripcion de la tarea a buscar");
char desIngresada = Console.ReadKey().KeyChar;
bool bandera = true;
foreach (var tarea in tareasPendientes)
{
    if (desIngresada == tarea.Descripcion)
    {
        Console.WriteLine("-----Tarea encontrada-----");
        Console.WriteLine("ID: " + tarea.Id);
        Console.WriteLine("Descripcion: " + tarea.Descripcion);
        Console.WriteLine("Duracion: " + tarea.Duracion);
        bandera = false;
        break;
    }
}
foreach (var tarea in tareasRealizadas)
{
    if (desIngresada == tarea.Descripcion)
    {
        Console.WriteLine("-----Tarea encontrada-----");
        Console.WriteLine("ID: " + tarea.Id);
        Console.WriteLine("Descripcion: " + tarea.Descripcion);
        Console.WriteLine("Duracion: " + tarea.Duracion);
        bandera = false;
        break;
    }
}
if(bandera){
    Console.WriteLine("No se encontro la tarea con esa descripcion");
}