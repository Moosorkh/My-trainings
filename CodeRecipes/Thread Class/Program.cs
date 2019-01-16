using System;
using System.Threading;

namespace Thread_Class
{

    public class MXThread
    {
        //Non-Static method
        public void mythr()
        {
            for (int J = 0; J < 2; J++)
            {
                Console.WriteLine("My thread is" + " in progress...!!");
            }
        }
    }
   public class GFG
    {
        static void Main()
        {
            //Creating object of ExThread class
            MXThread obj = new MXThread();
            //Creating and initializing thread
            //Using thread class and 
            //ThreadStart constructor
            Thread t = new Thread(new ThreadStart(obj.mythr));
            t.Start();
        }
    }
}
