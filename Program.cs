namespace LinkedListProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");
            LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();

            //UC4
            //list.Add(56);
            //list.Add(70);
            //int a = list.Search(56);
            //list.InsertData(a + 1, 30);
            //list.Display();

            //UC5
            list.Add(56);
            list.Add(70);
            list.DeleteFirstNode();
            list.Display();
        }
    }
}