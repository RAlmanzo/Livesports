using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace NewFeatures.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primary constructors
            Console.WriteLine("Primary constructors");
            var person = new Person("John", "Doe");
            Console.WriteLine($"Name: {person.Firstname} {person.Lastname}");

            // Collection expressions (met spread operator)
            Console.WriteLine("Collection expressions (met spread operator)");
            // Een array met enkele waarden
            int[] a1 = [1, 2, 3];

            // Een lijst met andere waarden
            List<int> a2 = [4, 5, 6];

            // Een span met nog meer waarden
            Span<int> a3 = [7, 8, 9];

            // Combineer alle waarden in één collectie met de spread operator
            Collection<int> mergedList = [.. a1, .. a2, .. a3];
            foreach (var number in mergedList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Default lambda parameters in csharp12");
            // Lambda-expressie met een standaardwaarde voor de parameter 'addTo'
            var addWithDefault = (int addTo = 2) => addTo + 1;

            // Roep de lambda aan zonder argument (gebruikt de standaardwaarde)
            Console.WriteLine(addWithDefault()); // Uitvoer: 3

            // Roep de lambda aan met een argument (overschrijft de standaardwaarde)
            Console.WriteLine(addWithDefault(5)); // Uitvoer: 6
        }
    }
}

// Definieer een klasse met een primaire constructor
public class Person
{
    // Primaire constructor met parameters
    public Person(string firstname, string lastname)
    {
        Firstname = firstname;
        Lastname = lastname;
    }

    // Auto-implementatie-eigenschappen
    public string Firstname { get; }
    public string Lastname { get; }

    // Aangepaste ToString-methode
    public override string ToString() => $"{Firstname} {Lastname}";
}

