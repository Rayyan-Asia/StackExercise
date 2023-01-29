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
            stack.Print();
            Console.WriteLine(stack.Pop());
            stack.Clear();
            stack.Print();

            Console.ReadLine();

        }
    }
}