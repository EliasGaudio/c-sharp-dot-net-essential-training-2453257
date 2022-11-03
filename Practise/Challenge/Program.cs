String respuesta = "";
DateTime result;
DateTime hoy = DateTime.Today;

while (respuesta != "exit")
{
    Console.WriteLine("Inserte una fecha, por favor.");
    respuesta = Console.ReadLine();
    if (respuesta == "exit"){
        break;
    }
    if (DateTime.TryParse(respuesta, out result)){
        if (DateOnly.FromDateTime(result) > DateOnly.FromDateTime(hoy))
        {
            Console.WriteLine($"Faltan {(result - hoy):dddd} dias");            
        }
        else if(DateOnly.FromDateTime(result) < DateOnly.FromDateTime(hoy)){
            Console.WriteLine($"Fue hace {(hoy - result):dddd} dias");            

        }
        else
        {
            Console.WriteLine("Es hoy");
        }
    }
    else{
        Console.WriteLine($"could not parse '{respuesta}'");
    }
}