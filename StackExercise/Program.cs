namespace StackExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("Rayyan");
            stack.Push("is");
            stack.Push("The");
            stack.Push("Goat");
            Console.WriteLine(stack.Peak());
            Console.WriteLine(stack.Pop());
            stack.Push("Fluent in Yoda, I am");
            stack.Print();
            stack.Clear();
            Console.ReadLine();

        }
    }
}