using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NewFeatures.Cons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primary constructors
            //Primaire constructors centraliseren de parameters die nodig zijn om een object te maken.Je hoeft niet langer meerdere constructors te definiëren met verschillende sets parameters.
            //Dit maakt het gemakkelijker om te zien welke waarden nodig zijn om een object te initialiseren
            //De parameters van de primaire constructor zijn beschikbaar in het hele lichaam van de klasse.
            //Dit betekent dat je ze kunt gebruiken om andere leden(zoals eigenschappen of velden) te initialiseren.
            //Door een primaire constructor toe te voegen, voorkom je dat de compiler een impliciete parameterloze constructor genereert.
            //Dit dwingt je om expliciet de parameters te specificeren bij het maken van een object.
            //Kortom, primaire constructors bieden een gestroomlijnde manier om objecten te initialiseren en bevorderen een beter begrip van de benodigde parameters.
            //Ze zijn vooral handig bij het gebruik van complexe klassen of structs
            Console.WriteLine("Primary constructors");
            var person = new Person("John", "Doe");
            Console.WriteLine($"Name: {person.Firstname} {person.Lastname}");



            // met csharp12 kan je nu lijsten gemakkelijker initializer en kan je door middel van een
            // spread operator gemakkelijk de verschillende collections(Arrays, list, span) met elkaar toevoegen mits ze 
            // dezelfde type hebben.
            // Collection expressions (met spread operator)
            // in mijn project lijkt mij dit niet nuttig omdat ik op geen enkele plaatsen verschillende listen met elkaar moet optellen
            //maar ik denk dat het gemakkelijker initializeren van collections wel een meerwaarde is om korte code te schrijven, ik zou
            //dit zelf ook kunnen gebruiken op alle lists die ik in mijn project heb.
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


            // in csharp12 kan je nu default waarden meegegeven in lamba parameters
            // als je de lamba oproept zonder parameter dan zal de default waarde gegeven worden
            //bij het wel opgeven van een parameter zal de default waarde overschreven worden door de
            //parameter die meegegeven is.
            // in mijn project lijkt dit niet nodig omdat ik nergens een default waarde nodig heb in 
            // mijn lamba functions.

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

