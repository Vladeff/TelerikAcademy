using System;
using System.Collections.Generic;


class collectionsDemo
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        HashSet<int> numbersHashSet = new HashSet<int>();
        numbersHashSet.Add(1);
        numbersHashSet.Add(1);
        numbersHashSet.Add(1);
        numbersHashSet.Add(1);          //Ne se znae kak sortira
        numbersHashSet.Add(2);          // Заема място в листа само прри НОВО число
        numbersHashSet.Add(3);
        numbersHashSet.Add(3);

        string a = "str123";
        string b = string.Empty;
        int val;

        for (int i = 0; i < a.Length; i++)
        {
            if (Char.IsDigit(a[i]))
                b += a[i];
        }

        if (b.Length > 0)
            val = int.Parse(b);

      SortedSet<int> sortedNum = new SortedSet<int>(); // Като горното но и ги сортира
   
    //   var dictionary = new Dictionary<string, int>();
    //   dictionary["Pesho"] = 2;                                //raboti kato masiv no s kliuch                                                            
    //   dictionary["Gosho"] = 15;
    //
    //   foreach (var item in dictionary)
    //   {
    //       Console.WriteLine(item.Key + item.Value);
    //
    //   }
    //
    //   // SortedDictionary
    //
    //
    //   var stack = new Stack<int>();               // mivka s chinii
    //   stack.Push(1);  //kato    .Add
    //   stack.Push(5);
    //
    //   int nextNumber = stack.Pop();
    //   Console.WriteLine(nextNumber);
    //   nextNumber = stack.Pop();                   // за да се погледне САМО кой е следващия  без да премахва 
    //   Console.WriteLine(nextNumber);
    //
    //
    //   // ОПАШКА - obratnoto na Stack 
    //   // Pyrviq element vkaran izliza pyrvi
    //   var quele = new Queue<int>();
    //   quele.Enqueue(555);
    //   quele.Enqueue(1055);
    //   quele.Enqueue(1155);
    //
    //   Console.WriteLine(quele.Dequeue());  // Dequeue Вади
    //
    //   while (quele.Count != 0)                               //Вади всички елементи
    //   {                                                      //Вади всички елементи
    //       Console.WriteLine(quele.Dequeue());                //Вади всички елементи
    //   }
    //
    //
    //  
    }
}

