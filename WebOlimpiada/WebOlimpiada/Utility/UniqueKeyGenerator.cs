using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;

namespace WebOlimpiada.Utility
{
    public class UniqueKeyGenerator
    {
        private static UniqueKeyGenerator Instance = new UniqueKeyGenerator();
        private Stack stack = null;

        private UniqueKeyGenerator()
        {
            InitStack();
        }

        public static UniqueKeyGenerator GetInstance()
        {
            if (Instance == null)
            {
                Instance = new UniqueKeyGenerator();
            }
            Guid.NewGuid().ToString();

            return Instance;
        }

        private void InitStack()
        {
            stack = new Stack();

            for (int i = 99; i > -1; i--)
            {
                stack.Push((decimal)i);
            }
        }

        //[MethodImpl(MethodImplOptions.Synchronized)]	
        public object GetUniqueKey()
        {
            decimal key = GetMillisecondsPortion();
            string keyString = key.ToString();
            string stackNumber = GetNextNumberFromStack().ToString();

            if (stackNumber.Length == 1)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("0");
                sb.Append(stackNumber);

                stackNumber = sb.ToString();
            }

            keyString += stackNumber;

            return Convert.ToDecimal(keyString);
        }

        public object GetUniqueKeyId()
        {
            return GetMillisecondsPortion();
        }

        private decimal GetNextNumberFromStack()
        {
            decimal numberFromStack = 0;

            try
            {
                if (stack.Count == 0)
                {
                    InitStack();
                }

                numberFromStack = (decimal)stack.Pop();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return numberFromStack;
        }

        private decimal GetMillisecondsPortion()
        {
            decimal milliseconds = 0;

            try
            {
                Thread.Sleep(10);
                DateTime currentTime = DateTime.Now;
                int year = DateTime.Now.Year;
                DateTime time = new DateTime(year, 1, 1);
                long longMilliseconds = currentTime.Ticks - time.Ticks;

                milliseconds = Convert.ToDecimal(longMilliseconds);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            return milliseconds;
        }
    }
}