namespace tree
{
    class Program
    {  
        class Node<T>  // Generi, Basic Node
        {
            public T Data; // Data
            public Node<T> next; // Next Node
            public Node(T data) // Node Innitialization
            {
                this.Data = data; 
            }
        }     
        static void Main(string[] args)
        {
            Node<string> ndString = new Node<string>("string");
            Console.WriteLine(ndString.Data);
        }
    }
}
