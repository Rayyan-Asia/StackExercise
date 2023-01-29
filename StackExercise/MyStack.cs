namespace StackExercise
{
    public class MyStack<T>
    {
        private Node? head;
        public void Push(T item)
        {
            var node = new Node(item);
            if (head != null)
                node.previous = head;
            head = node;
        }
        public T Pop()
        {
            if (head != null)
            { 
                T node= head.data;
                head = head.previous;
                return node;
            }else
            {
                throw new Exception("No Objects left in the stack");
            }
        }
        public void Clear()
        {
            head = null;
        }

        public T Peak()
        {
            if (head == null)
                throw new Exception("No Objects in Stack");
            return head.data;
        }

        public void Print()
        {
            if(head == null)
            {
                throw new Exception("No Objects in Stack");
            }
            else
            {
                PrintRecursive(head);
            }
            
        }

        public void PrintRecursive(Node node)
        {
            if(node.previous != null)
            {
                PrintRecursive(node.previous);  
            }
            Console.WriteLine(node.data);
        }
        public class Node
        {
            public T data { get; set; }
            public Node? previous { get; set;}
            public Node(T data)
            {
                this.data = data;
            }
        }
    }
}
