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
    Console.WriteLine("0. Exit");
    Console.Write("Enter your option: ");
    return Console.ReadLine() ?? string.Empty;
}