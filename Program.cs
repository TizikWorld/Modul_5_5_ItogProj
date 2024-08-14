namespace Modul_5_5_ItogProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tuple = ReadData();





            static (string Name, string LName, int age, bool pet, int pet_num, string[] pet_list, int color_num, string[] color_list) ReadData()
            {
                (string Name, string LName, int age, bool pet, int pet_num, string[] pet_list, int color_num, string[] color_list) tuple;

                //Временно для наладки кода
                tuple.pet = false;
                tuple.pet_num = 0;
                tuple.pet_list = new string[1] ;
                tuple.color_num = 0;
                tuple.color_list = new string[1];

                Console.WriteLine("Введите свое имя:");
                tuple.Name = Console.ReadLine();

                Console.WriteLine("Введите свою фамилию:");
                tuple.LName = Console.ReadLine();

                do
                {
                    Console.WriteLine("Введите свой возраст:");
                    tuple.age = int.Parse(Console.ReadLine());
                } while (CheckAge(tuple.age));




                return tuple;
            }

            static bool CheckAge(int age)
            {
                bool check;

                if (age > 0)
                    return check = true;
                else return check = false;
            }






        }
    }
}
