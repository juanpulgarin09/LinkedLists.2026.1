# LinkedLists - Taller 5

A C# implementation of a generic doubly linked list with ordered insertion,
sorting, mode detection, occurrence chart, and full CRUD operations.

## Project Structure
LinkedLists/
├── Shared/                  # Shared interface and contracts
│   └── ILinkedList.cs       # Generic interface for linked list operations
├── SimpleList/              # Singly linked list implementation
│   ├── Node.cs
│   └── SinglyLinkedList.cs
├── DoubleList/              # Doubly linked list implementation
│   ├── Node.cs
│   └── DoubleLinkedList.cs
└── LinkedLists.Console/     # Console application with menu
└── Program.cs

## Features

- **Ordered insertion** — Elements are automatically inserted in ascending order
- **Bidirectional traversal** — Show the list forward and backward
- **Descending sort** — Reorders the list using bubble sort
- **Mode detection** — Finds the most frequent element(s) in the list
- **Occurrence chart** — Displays a visual chart of element frequencies
- **Search** — Checks if an element exists in the list
- **Remove one** — Deletes the first occurrence of an element
- **Remove all** — Deletes all occurrences of an element

## Menu Options

| Option | Description |
|--------|-------------|
| 1 | Add element (inserted in ascending order) |
| 2 | Show list forward |
| 3 | Show list backward |
| 4 | Sort descending |
| 5 | Show mode(s) |
| 6 | Show occurrence chart |
| 7 | Check if element exists |
| 8 | Remove first occurrence |
| 9 | Remove all occurrences |
| 0 | Exit |

## Example Usage

**Inserting:** Blanco, Azul, Amarillo, Verde, Negro

**Forward:**
Amarillo -> Azul -> Blanco -> Negro -> Verde -> null

**Backward:**
Verde -> Negro -> Blanco -> Azul -> Amarillo -> null

**After sort descending:**
Verde -> Negro -> Blanco -> Azul -> Amarillo -> null

**Mode example** — inserting: 1, 2, 3, 3, 2, 5, 6, 6, 6, 3, 6
Mode: 6

**Occurrence chart:**
1 *
2 **
3 ***
5 *
6 ****

## Technical Details

- Built with **.NET 10**
- Uses **generics** with `IComparable<T>` constraint for ordering
- `Node<T>` holds references to both `Next` and `Previous` nodes
- `RemoveNode()` private method handles all 4 removal cases safely:
  single node, head, tail, and middle

## Requirements

- .NET 10 SDK or higher
- Visual Studio 2022 or VS Code

## Repository

GitHub: https://github.com/juanpulgarin09
