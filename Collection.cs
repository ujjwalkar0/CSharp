using System.Collections.Generic;
namespace Program
{
class MyList{
    internal MyList(){
        List<string> name = new List<string>(){"Intern wala baccha's are..."};
        name.Add("Ujjwal");
        name.Add("Neha");
        name.Add("Disha");
        name.Add("Ashish");
        name.Add("Avisekh");
        name.Add("Kritti");
        name.Add("Aishik");
        name.Add("Soham");

        foreach(string i in name){
            Console.WriteLine(i);
        }
    }
}

class MyHashSet{
    internal MyHashSet(){
        HashSet<Int32> nums = new HashSet<int>();
        nums.Add(4);
        nums.Add(4);
        nums.Add(5);
        nums.Add(7);

        foreach(int i in nums){
            Console.WriteLine(i);
        }

    }
}

class MySortedSet{
    internal MySortedSet(){
        SortedSet<string> set = new SortedSet<string>();
        set.Add("Ujjwal");
        set.Add("Neha");
        set.Add("Disha");
        set.Add("Ashish");
        set.Add("Avisekh");
        set.Add("Kritti");
        set.Add("Aishik");
        set.Add("Soham");

        Console.WriteLine("Intern wale baccha's are...");

        foreach(string i in set){
            Console.WriteLine(i);
        }
    }
}

class MyStack{
    internal MyStack(){
        Stack<int> st = new Stack<int>();

        st.Push(3);
        st.Push(5);
        st.Push(6);
        st.Push(9);
        st.Push(8);
        st.Push(2);
        st.Push(1);

        foreach (int item in st)
        {
            Console.Write(item);
        }

        Console.WriteLine();
        Console.WriteLine(st.Peek());
        Console.WriteLine(st.Pop());
        Console.WriteLine(st.Peek());
    }
}

class MyDictionary{
    public MyDictionary(){
        Dictionary<int, string> dc = new Dictionary<int, string>();
        dc.Add(1, "hello");
        dc.Add(2, "clinisys");

        foreach(KeyValuePair<int, string> kv in dc) {
            Console.WriteLine(kv.Key+" "+kv.Value);  
        }
    }
}

class MySortedDictionary{
    public MySortedDictionary(){
        SortedDictionary<int, string> dc = new SortedDictionary<int, string>();
        dc.Add(1, "hello");
        dc.Add(2, "clinisys");

        foreach(KeyValuePair<int, string> kv in dc) {
            Console.WriteLine(kv.Key+" "+kv.Value);  
        }
    }
}

class MyConsDest{
    public MyConsDest(){
        Console.WriteLine("Constructed Called");
    }

    public static void hello(){
        Console.WriteLine("Hello World");
    }
    ~MyConsDest(){
        Console.Write("Distractor Called");
    }
}
enum Level
    {
        Low=0,
        Medium=1,
        High='8'
    }

}


// class Hello{

//     public static void Main(string[] args){
        
//         Console.WriteLine((int)Level.High);
//         // new MyList();
//         // new MyHashSet();
//         // new MySortedSet();
//         // new MyStack();
//         // new MyDictionary();
//         // new MySortedDictionary();
//         // int i = 0;
//         // Func<int, string> square = x => Convert.ToString(x * x);

//         // Console.WriteLine(square(7));

//         // hello:
//         //     i=1;
//         //     Console.Write("Hello World");
        
//         // if (i==0)
//         //     goto hello;

//         MyConsDest.hello();

//         MyConsDest a = new MyConsDest();

//     }
// }