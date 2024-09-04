using System.Diagnostics;

Console.WriteLine("aik eller djurgården");
string lag = Console.ReadLine();

if (lag.ToLower() == "aik" || lag.ToLower() == "gnaget")
{
    Console.WriteLine("Helt rätt klapp på axeln!");
    Console.WriteLine("vill du ha glass eller saft =D");
    string snack = Console.ReadLine();
    if (snack.ToLower() == "glass")
    {
        Console.WriteLine("chockolad eller vanlj?");
        string smak = Console.ReadLine();
        Console.WriteLine("gott!");
    }
    if (snack.ToLower() == "saft")
    {
        Console.WriteLine("jordgubbssaft eller äppelsaft?");
        string saftsmak = Console.ReadLine();
        Console.WriteLine("gott!");
    }
}
else if (lag.ToLower() == "djurgården")
{
    Console.WriteLine("fel svar! Vill du välja svar igen?!");
    Console.WriteLine("Ja eller nej");
    String Ja = Console.ReadLine();
    if (Ja.ToLower() == "ja")
    {
        Console.WriteLine("aik eller djurgården");
    }
    else if (Ja.ToLower() == "nej")
    {
        Console.WriteLine("Tyvär du har inget val aik eller djurgården");
    }
    string aiik = Console.ReadLine();
if (aiik.ToLower() == "ja")
{
    Console.WriteLine("äntligen är du smart tumme up");
}
else if (aiik.ToLower() == "djurgården")
{
    Console.WriteLine("du är död tyvärr");
}

}

Console.ReadLine();



// Console.WriteLine("Är du lång?");
// string tall = Console.ReadLine();

// if (tall == "ja" || tall == "JA" || tall == "jA" || tall == "jA")
// {
//     Console.WriteLine("Kul för dig?");
// }
// else if (tall == "kanske")
// {
//     Console.WriteLine("okej?");
// }
//     else
// {
//     Console.WriteLine("trist...");
// }
// Console.ReadLine();