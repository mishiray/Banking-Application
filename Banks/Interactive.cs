using System;
using System.Threading;

namespace Banks
{
    /// <summary>
    /// Interactive class uses threads to vary computation speed
    /// </summary>
    public  class Interactive 
    {
        /// <summary>
        /// The think method uses thread class to create a form of animation 
        /// </summary>
        public void think()
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                }
                Console.Write("\b\b\b");
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Uses thread class to slow down the print function..making it like an animation
        /// </summary>
        public void load()
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("..");
                    Thread.Sleep(500);
                    Console.Write("\b\b");
                }
            }
            catch (Exception) { }
        }


    }
}
