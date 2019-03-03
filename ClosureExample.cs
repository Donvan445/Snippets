using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosureExample
{
    class ClosureExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press g for good or b for bad");

            var readLine = Console.ReadLine();

            while (readLine != "g" && readLine != "b")
            {
                readLine = Console.ReadLine();
            }

            if (readLine == "g")
                PrintNumbersCorrect();
            else if (readLine == "b")
                PrintNumbers();

            Console.ReadKey();
        }

        private static void PrintNumbers()
        {
            List<Action> actionList = new List<Action>();

            for (int i = 0; i < 10; i++)
            {
                actionList.Add(() => Console.WriteLine(i));
            }

            foreach (Action print in actionList)
            {
                print();
            }
        }

        private static void PrintNumbersCorrect()
        {
            List<Action> actionList = new List<Action>();

            for (int i = 0; i < 10; i++)
            {
                var correct = i;
                actionList.Add(() => Console.WriteLine(correct));
            }

            foreach (Action print in actionList)
            {
                print();
            }
        }
    }
}
