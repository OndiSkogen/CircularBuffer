using System;

namespace CircularBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue;
            bool quit = false;
            int temp = 0;

            Console.WriteLine("How big do you want your buffer to be?");
            try
            {
                temp = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please use numericals. " + ex);
            }

            queue = new Queue(temp);

            do
            {                
                Console.WriteLine("1. Add data to buffer.\n" +
                                "2. Remove data from buffer.\n" +
                                "3. Quit.\n" +
                                "Enter your choice(1-3): ");
                int input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        if (queue.Full())
                        {
                            Console.WriteLine("Buffer is full.");
                        }
                        else
                        {
                            Console.WriteLine("Enter a number to add to the buffer.");
                            try
                            {
                                int addNumber = Int32.Parse(Console.ReadLine());
                                queue.Enqueue(addNumber);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Please use numericals. " + ex);
                            }
                        }                        
                        break;
                    case 2:
                        if (queue.Empty())
                        {
                            Console.WriteLine("No data in the buffer yet.");
                        }
                        else
                        {
                            queue.Dequeue();
                        }
                        break;
                    case 3:
                        quit = true;
                        break;
                    default:
                        break;
                }
            }while(quit == false);                        
        }
    }
}
