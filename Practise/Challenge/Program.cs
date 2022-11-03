String respuesta = "";
DateTime result;
DateTime hoy = DateTime.Now;

while (respuesta != "exit")
{
    Console.WriteLine("Inserte una fecha, por favor.");
    respuesta = Console.ReadLine();
    // TODO: Use the static class function TryParse to try parsing the dates
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