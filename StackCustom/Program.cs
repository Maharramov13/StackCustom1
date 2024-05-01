internal class Program
{
    public static void Main(string[] args)
    {
        // Stack<int> stack = new Stack<int>();

        // stack.Push(1);
        // stack.Push(2);
        // stack.Push(3);
        // stack.Push(4);
        // stack.Push(5);


        //// Console.WriteLine("Stack peek: " + stack.Peek());  
        // Console.WriteLine("Popping: " + stack.Pop());      
        // Console.WriteLine("Stack peek: " + stack.Peek());

        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(8); 
        stack.Push(9);
        stack.Push(10);
        stack.Push(11);
        stack.Push(12);

        

          Console.WriteLine("Stack count: " + stack.Count);    
          Console.WriteLine("Stack capacity: " + stack.EnsureCapacity(stack.Count)); 

            Console.WriteLine("Stack peek: " + stack.Peek());  
            Console.WriteLine("Popping: " + stack.Pop());      

          Console.WriteLine("Stack count: " + stack.Count);     
        //   Console.WriteLine("Stack capacity: " + stack.Capacity);


        Console.WriteLine("Stack pop is: "+stack.Pop());

    }
}