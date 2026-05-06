using DoubleList;

var list = new DoubleLinkedList<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1": // Adicionar (ordenado ascendente)
            Console.Write("Enter a value: ");
            var newVal = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(newVal))
                list.InsertOrdered(newVal);
            else
                Console.WriteLine("Invalid value.");
            break;

        case "2": // Mostrar hacia adelante
            Console.WriteLine("Forward: " + list.ToString());
            break;

        case "3": // Mostrar hacia atrás
            Console.WriteLine("Backward: " + list.ToStringReverse());
            break;

        case "4": // Ordenar descendentemente
            list.Sort();
            Console.WriteLine("List sorted descending:");
            Console.WriteLine(list.ToString());
            break;

        case "5": // Mostrar la(s) moda(s)
            var modes = list.GetModes();
            if (modes.Count == 0)
                Console.WriteLine("The list is empty.");
            else if (modes.Count == 1)
                Console.WriteLine($"Mode: {modes[0]}");
            else
                Console.WriteLine("Modes: " + string.Join(", ", modes));
            break;

        case "6": // Mostrar gráfico
            Console.WriteLine("Chart. ");
            list.PrintChart();
            break;

        case "7": // Existe
            Console.Write("Enter a value to search: ");
            var searchVal = Console.ReadLine() ?? string.Empty;
            bool found = list.Contains(searchVal);
            Console.WriteLine(found
                ? $"Value '{searchVal}' EXISTS in the list."
                : $"Value '{searchVal}' does NOT exist in the list.");
            break;

        case "0":
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Add (ordered ascending)");
    Console.WriteLine("2. Show forward");
    Console.WriteLine("3. Show backward");
    Console.WriteLine("4. Sort descending");
    Console.WriteLine("5. Show mode(s)");
    Console.WriteLine("6. Show chart");
    Console.WriteLine("7. Exists");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your option: ");
    return Console.ReadLine() ?? string.Empty;
}