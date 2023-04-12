Console.WriteLine(IsAnagram("Fried", "Fired"));
Console.WriteLine(IsAnagram("Gainly", "Laying"));
Console.WriteLine(IsAnagram("Listen", "Silent"));
Console.WriteLine(IsAnagram("test", "test"));
Console.WriteLine(IsAnagram("hello", "heLLO"));
Console.WriteLine(IsAnagram("Sadder", "Dreads"));
Console.WriteLine(IsAnagram("false", "fals"));

Console.WriteLine("Time complexity: 'O(n log n)'");
Console.WriteLine("Space complexity: 'O(n)'");

bool IsAnagram(string input1, string input2)
{ 
    if(string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
        return false;

    input1 = input1.ToLower();
    input2 = input2.ToLower();

    if(input1.Equals(input2))
        return true;
    
    var array1 = input1.ToCharArray();
    var array2 = input2.ToCharArray();
        
    Array.Sort(array1);
    Array.Sort(array2);

    var value1 = new string(array1);
    var value2 = new string(array2);

    return value1 == value2;
}