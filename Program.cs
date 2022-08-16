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
            //list.Add(56);
            //list.Add(70);
            //list.DeleteFirstNode();
            //list.Display();

            //UC6
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.RemoveLastNode();
            //list.Display();

            //UC7
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Search(30);

            //UC8
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //int newNode = list.Search(30);
            //list.InsertAtParticularPosition(newNode + 1, 40);
            //list.Display();

            //UC9
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //int node = list.Search(30);
            //list.InsertAtParticularPosition(node + 1, 40);
            //list.Display();
            //Console.WriteLine("\n\nElement Delete SuccessFully");
            //list.DeleteNodeAtParticularPosition(node + 1);
            //list.Display();

            //UC10
            SortingList<int> sortingList = new SortingList<int>();
            sortingList.AddNode(56);
            sortingList.AddNode(30);
            sortingList.AddNode(40);
            sortingList.AddNode(70);
            Console.WriteLine("Original List: ");
            sortingList.DisplaySort();
            sortingList.SortOrderedList();
            Console.WriteLine("Final Sorted List: ");
            sortingList.DisplaySort();
        }
    }
}