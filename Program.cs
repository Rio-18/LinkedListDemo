namespace LinkedListDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            linked.Add(20);
            linked.Add(20);
            linked.Add(60);
            linked.Add(80);

            linked.Display();
        }
    }
}
