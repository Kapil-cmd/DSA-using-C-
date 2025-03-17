using System.Security.Cryptography;

namespace DSA
{
    public class Queue
    {
        public int MaxSize { get; set; } // Number of elements
        public int[] QueueArray { get; set; } // Actual array
        public int Front { get; set; } //front of queue
        public int Rear { get; set; } //back of queue
        public int NItems { get; set; } // keep track of length

        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front = 0;
            Rear = -1; //rear even doesn't exists
        }

        public void Enqueue(int item)
        {
            //Increment our pointer 
            Rear++;
            //insert into where the rear was incremented
            QueueArray[Rear] = item;
            //Increment
            NItems++;
        }
        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek() 
        {
            return QueueArray[Front];
        }
    }
}
