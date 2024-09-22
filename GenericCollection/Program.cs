namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating generic queue
            Queue<string> qNumbers = new Queue<string>(); 

            qNumbers.Enqueue("One");
            qNumbers.Enqueue("Two");
            qNumbers.Enqueue("Three");
            qNumbers.Enqueue("Four");
            qNumbers.Enqueue("Five");

            foreach(String number in qNumbers.ToArray()) 
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Dequieing {0}", qNumbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", qNumbers.Peek());
            Console.WriteLine("Dequieing {0}", qNumbers.Dequeue());

            //array of strings
            String[] arrNumbers =  {"one", "two", "three"};

            //assiging data to new queue, parsing string from string array to queue
            Queue<string> qnewNumbers = new Queue<string>(arrNumbers);

            foreach(string number in qNumbers.ToArray())
            {
                Console.WriteLine(number);
            }

            //testing data to see if it is contained in queue | should return true if found, false if not
            Console.WriteLine("Does Three Exist in Queue: {0}", qNumbers.Contains("three"));

            //clearing the queue
            Console.WriteLine("Clearing the Queue");

            qnewNumbers.Clear();


            Console.WriteLine("New Que: {0}", qnewNumbers.Count());

        }
    }
}
