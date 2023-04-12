namespace Question2.Models;

public class LinkedListHandler<T>
{
    public void Log(LinkedList<T>? genericList)
    {
        var current = genericList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    public void ReverseLinkedListWithRecursion(LinkedList<T> list)
    {
        if (list == null || list.First == null) return;

        var reversedList = new LinkedList<T>();
        ReverseLinkedListRecursive(list.First, reversedList);

        list.Clear();
        foreach (var node in reversedList)
        {
            list.AddLast(node);
        }
    }

    public void ReverseLinkedListUsingLoops(LinkedList<T> list)
    {
        if (list == null || list.First == null) return;

        var reversedList = new LinkedList<T>();

        var currentNode = list.First;
        while (currentNode != null)
        {
            reversedList.AddFirst(currentNode.Value);
            currentNode = currentNode.Next;
        }
        
        list.Clear();

        foreach (var node in reversedList)
        {
            list.AddLast(node);
        }
    }

    
    #region Private
    private void ReverseLinkedListRecursive(LinkedListNode<T> currentNode, LinkedList<T> reversedList)
    {
        if (currentNode == null) return;

        ReverseLinkedListRecursive(currentNode.Next, reversedList);
        reversedList.AddLast(currentNode.Value);
    }

    #endregion
}