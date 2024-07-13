IEnumerable<int> GetValues()
{
    return new List<int>() { 1, 2, 3, 4, 5, 6 };
}

#region Foreach
foreach (var i in GetValues())
{
    Console.WriteLine(i);
}

#region Foreach logic manually written
// e is collections it's contains values
IEnumerable<int> e = GetValues();

// 'enumerator' enumerator for this collections, initally positined before the first element.
IEnumerator<int> enumerator = e.GetEnumerator();

try
{
  //[ , 1, 2, 3, 4, 5, 6]
 // ^
//(Enumerator positioned before the first element)
// when we do movenext then it will move to value 1
    while (enumerator.MoveNext())
    {
        int i = enumerator.Current;
        Console.WriteLine(i);
    }
}
finally
{
    enumerator.Dispose();
}

#endregion

#endregion
