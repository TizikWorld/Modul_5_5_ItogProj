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

                //Что бы компилятор не жаловался на переменные которые внутри циклов if
                tuple.pet_num = 0;
                tuple.pet_list = new string[1];
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

                Console.WriteLine("Есть ли у вас животные?");
                if("Да"== Console.ReadLine())
                    tuple.pet = true;else
                    tuple.pet = false;

                if (tuple.pet) {
                    do
                    {
                        Console.WriteLine("Введите количество питомцев:");
                        tuple.pet_num = int.Parse(Console.ReadLine());
                    } while (CheckAge(tuple.pet_num));

                    tuple.pet_list = new string[tuple.pet_num];
                    tuple.pet_list = ReadPet(tuple.pet_num);
                }

                do
                {
                    Console.WriteLine("Сколько у вас любимых цветов?");
                    tuple.color_num = int.Parse(Console.ReadLine());
                } while (CheckAge(tuple.color_num));

                if(tuple.color_num>0)
                    tuple.color_list = ReadColor(tuple.color_num);

                return tuple;
            }

            static bool CheckAge(int age)
            {
                bool check;

                if (age > 0)
                    return check = false;
                else return check = true;
            }

            static string[] ReadPet(int num_pet)
            {
                string[] arr = new string[num_pet];

                for(int i  = 0; i < num_pet; i++)
                {
                    Console.WriteLine("Введите имя питомца №{0}:",i+1);
                    arr[i] = Console.ReadLine();
                }

                return arr;
            }

            static string[] ReadColor(int num_color)
            {
                string[] arr = new string[num_color];

                for (int i = 0; i < num_color; i++)
                {
                    Console.WriteLine("Введите название цвета №{0}:", i + 1);
                    arr[i] = Console.ReadLine();
                }

                return arr;
            }

            static void Answer(string Name, string LName, int age, bool pet, int pet_num, string[] pet_list, int color_num, string[] color_list)
            {

            }


        }
    }
}
