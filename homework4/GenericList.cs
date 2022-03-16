class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }
            int sum = 0;
            int max = 0;
            int min = 0;
            intlist.ForEach((m) =>
            {
                Console.WriteLine(m + " ");
                sum = sum + m;
                max = Math.Max(max, m);
                min = Math.Min(min, m);
            });
            Console.WriteLine("Max:" + max);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("Sum:" + sum);
            Console.ReadLine();
        }

        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set;}
            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }

        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public GenericList()
            {
                tail = head = null;
            }
            public Node<T> Head
            {
                get => head;
            }
            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
            public void ForEach(Action<T> action)
            {
                Node<T> n = head;
                while (n != null)
                {
                    action(n.Data);
                    n = n.Next;
                }
            }
        }
    }
