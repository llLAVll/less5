namespace less5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Добро пожаловать на работу по курсу №5 \n введитие номер задания 1 - 3");
            int numTask = Convert.ToInt32(Console.ReadLine());
            switch (numTask)
            {

                case 1:
                    Console.WriteLine("Напишите набор данных:");
                    string text = Console.ReadLine();
                    File.WriteAllText(@"D:\\LAV\\Files\\Programming\\Plan\\less5\\textfiles\text.txt", text, System.Text.Encoding.UTF8);
                    break;
                case 2:
                    Console.WriteLine("Откройте файл startup.txt");
                    var dt_h = DateTime.Now.Hour;
                    var dt_m = DateTime.Now.Minute;
                    var dt_s = DateTime.Now.Second;
                    File.WriteAllText(@"D:\\LAV\\Files\\Programming\\Plan\\less5\\textfiles\startup.txt", dt_h.ToString() + ":" + dt_m.ToString() + ":" + dt_s.ToString(), System.Text.Encoding.UTF8);
                    break;
                case 3:
                    byte[] bytesArr = new byte[10];
                    Console.WriteLine("процедура ввода данных, вводите только числа от 0 до 255!");
                    for (int i = 0; i < bytesArr.Length; i++)
                    {
                        bytesArr[i] = Convert.ToByte(Console.ReadLine());
                    }
                    File.WriteAllBytes(@"D:\\LAV\\Files\\Programming\\Plan\\less5\\textfiles\byteARR.bin", bytesArr);
                    break;
                default:
                    Console.WriteLine("[sys_mes]: Нет такого номера задания!");
                    break;
            }

        }

    }

}


