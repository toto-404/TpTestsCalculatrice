namespace TpTestsCalculatrice.App;

class Program
{
    static void Main(string[] args)
    {
        /*
        Ce test manuel n’est pas suffisant :
        Il ne couvre que quelques cas d’usage (2+3 et 10/2) et pas les cas limites (division par zéro, nombres négatifs, overflow, etc.).

        Il ne garantit pas de protection contre les régressions. Si on modifie le code plus tard, on ne saura pas automatiquement si ça casse quelque chose.
        */
        
        Calculatrice calc = new Calculatrice();
        Console.WriteLine(calc.Addition(2, 3));
        Console.WriteLine(calc.Division(10, 2));
    }
}
