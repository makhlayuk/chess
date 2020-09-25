using System;

namespace chess
{
    class Program
    {
        static void Check (char[] StartingCoordinate)
        {
            if ((StartingCoordinate[0] >= 'A')
                && (StartingCoordinate[0] <= 'H')
                && (StartingCoordinate[1] > '0')
                && (StartingCoordinate[1] <= '8'))
                Console.WriteLine(StartingCoordinate);
            else
                Console.WriteLine("Ошибка");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальную координату коня");
            string Starting = Console.ReadLine();
            char[] StartingCoordinate = Starting.ToCharArray();
            Check(StartingCoordinate);
           
            Console.WriteLine("Введите конечную координату коня");
            string Final = Console.ReadLine();
            char[] FinalCoordinate = Final.ToCharArray();
            Check(FinalCoordinate);

            if (Math.Abs(FinalCoordinate[0] - StartingCoordinate[0]) == 1 
               && Math.Abs(FinalCoordinate[1] - StartingCoordinate[1]) == 2)
                Console.WriteLine("Верно");
            else
                Console.WriteLine("Неверно");
            
            

        }
    }
}