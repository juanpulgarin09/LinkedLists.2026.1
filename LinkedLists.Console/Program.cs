using DoubleList;

var list = new DoubleLinkedList<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1": // Add (ordered ascending)
            Console.Write("Enter a value: ");
            var newVal = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(newVal))
                list.InsertOrdered(newVal);
            else
                Console.WriteLine("Invalid value.");
            break;

        case "2": // Show forward
            Console.WriteLine("Forward: " + list.ToString());
            break;

        case "3": // Show backward
            Console.WriteLine("Backward: " + list.ToStringReverse());
            break;

        case "4": // Sort descending
            list.Sort();
            Console.WriteLine("List sorted descending:");
            Console.WriteLine(list.ToString());
            break;

        case "5": // Show mode(s)
            var modes = list.GetModes();
            if (modes.Count == 0)
                Console.WriteLine("The list is empty.");
            else if (modes.Count == 1)
                Console.WriteLine($"Mode: {modes[0]}");
            else
                Console.WriteLine("Modes: " + string.Join(", ", modes));
            break;

        case "6": // Show chart
            Console.WriteLine("Chart. ");
            list.PrintChart();
            break;

        case "7": // Exists
            Console.Write("Enter a value to search: ");
            var searchVal = Console.ReadLine() ?? string.Empty;
            bool found = list.Contains(searchVal);
            Console.WriteLine(found
                ? $"Value '{searchVal}' EXISTS in the list."
                : $"Value '{searchVal}' does NOT exist in the list.");
            break;

        case "8": // Remove one occurrence
            Console.Write("Enter a value to remove (first occurrence): ");
            var removeOne = Console.ReadLine() ?? string.Empty;
            list.Remove(removeOne);
            Console.WriteLine(list.ToString());
            break;

        case "9": // Remove all occurrences
            Console.Write("Enter a value to remove (all occurrences): ");
            var removeAll = Console.ReadLine() ?? string.Empty;
            list.RemoveAll(removeAll);
            Console.WriteLine(list.ToString());
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
    Console.WriteLine("\n===== DOUBLE LINKED LIST MENU =====");
    Console.WriteLine("1. Add (ordered ascending)");
    Console.WriteLine("2. Show forward");
    Console.WriteLine("3. Show backward");
    Console.WriteLine("4. Sort descending");
    Console.WriteLine("5. Show mode(s)");
    Console.WriteLine("6. Show chart");
    Console.WriteLine("7. Exists");
    Console.WriteLine("8. Remove one occurrence");
    Console.WriteLine("9. Remove all occurrences");
    Console.WriteLine("0. Exit");
    Console.Write("Enter your option: ");
    return Console.ReadLine() ?? string.Empty;
}