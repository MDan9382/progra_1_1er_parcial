int n=0, rn;
Random r = new Random();
rn = r.Next(1, 101);

Console.WriteLine("adivina un numero");
do
{
    
    n = Convert.ToInt32(Console.ReadLine());
    if (rn < n)
    {
        Console.WriteLine("el numero secreto es menor, intente otra vez");
    }
    else if (rn > n)
    {
        Console.WriteLine("el numero secreto es mayor, intente otra vez");
    }
    else
    {
        Console.WriteLine("¡correcto! \nel numero secreto es " + rn);
    }
} while (rn != n);
