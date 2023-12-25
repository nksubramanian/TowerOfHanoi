namespace TowersOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Tower source = new Tower("source");
            source.tower.Push(3);
            source.tower.Push(2);
            source.tower.Push(1);
            Tower aux = new Tower("aux");
            Tower destination = new Tower("destination");
            TowerofHanoiSolver(source, aux, destination);
        }

        public static void basefunc(Tower a, Tower b, Tower c)
        {
            int x = a.tower.Pop();
            b.tower.Push(x);
            Console.WriteLine($"Move {x} from {a.Name} to {b.Name}");
            int y = a.tower.Pop();
            c.tower.Push(y);
            Console.WriteLine($"Move {y} from {a.Name} to {c.Name}");
            int z = b.tower.Pop();
            c.tower.Push(z);
            Console.WriteLine($"Move {z} from {b.Name} to {c.Name}");

        }

        public static void TowerofHanoiSolver(Tower a, Tower b, Tower c)
        {
            Action<Tower, Tower, Tower>[] myArray = new Action<Tower, Tower, Tower>[a.tower.Count+1];
            myArray[2] = basefunc;
            for (int i = 3; i < myArray.Length; i++)
            {


                myArray[i - 1](a, c, b);
                int temp = a.tower.Pop();
                c.tower.Push(temp);
                Console.WriteLine($"Move {temp} from {a.Name} to {c.Name}");
                myArray[i - 1](b, a, c);

            }


        }


    }
}