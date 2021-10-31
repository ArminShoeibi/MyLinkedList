using MyLinkedList;

MyLinkedList.LinkedList<int> linkedList = new();
linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(30);

var indexOfTen = linkedList.IndexOf(10);
var indexOfTwenty = linkedList.IndexOf(20);

Console.WriteLine($"Contains 10? {linkedList.Contains(10)}");

linkedList.RemoveFirst();
Console.WriteLine($"Contains 10? {linkedList.Contains(10)}");

Console.WriteLine();

