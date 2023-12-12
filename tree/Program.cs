namespace tree
{
    class Program
    {  
        class Node<T>  // Generic, Basic Node
        {
            public T Data;
            public Node<T> left, right; // left child, right child
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
