using Question2.Models;

PerformRecursiveReverse();

PerformLoopsReverse();

void PerformRecursiveReverse()
{
   var linkedList = new LinkedList<int>();
   var linkedListHandler = new LinkedListHandler<int>();

   var current = linkedList.AddFirst(0);
   for (var i = 1; i < 5; i++)
   {
      current = linkedList.AddAfter(current, i);
   }

   Console.WriteLine("---------- Recursive ----------");

   Console.WriteLine("Before:");
   linkedListHandler.Log(linkedList);

   Console.WriteLine("After:");
   linkedListHandler.ReverseLinkedListWithRecursion(linkedList);
   linkedListHandler.Log(linkedList);
}

void PerformLoopsReverse()
{
   var linkedList = new LinkedList<string>();
   var linkedListHandler = new LinkedListHandler<string>();

   var current = linkedList.AddFirst("string-0");
   for (var i = 1; i < 5; i++)
   {
      current = linkedList.AddAfter(current, $"string-{i}");
   }

   Console.WriteLine("---------- Loops ----------");

   Console.WriteLine("Before:");
   linkedListHandler.Log(linkedList);

   Console.WriteLine("After:");
   linkedListHandler.ReverseLinkedListUsingLoops(linkedList);
   linkedListHandler.Log(linkedList);
}