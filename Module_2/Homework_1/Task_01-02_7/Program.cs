using System;

namespace Task_01_02_7
{
    class Program
    {
        public static int GeneralQuantity(int[,] A)
        {
            int sum = 0;
            foreach (int a in A)
            {
                sum += a;
            }
            return sum;
        }

        public static void MAxQuantity(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Западный филиал");
                        break;
                    case 1:
                        Console.WriteLine("Центральный филиал");
                        break;
                    case 2:
                        Console.WriteLine("Восточный филиал");
                        break;

                }

                int max = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j]) max = A[i, j];
                }

                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max == A[i, j])
                    {
                        switch (j)
                        {
                            case 0:
                                Console.WriteLine("Квартал I");
                                break;
                            case 1:
                                Console.WriteLine("Квартал II");
                                break;
                            case 2:
                                Console.WriteLine("Квартал III");
                                break;
                            case 3:
                                Console.WriteLine("Квартал IV");
                                break;
                        }
                        Console.WriteLine($"Продано машин : {A[i, j]}");
                        break;
                    };
                }

            }
        }

        public static void OfficeMaxQuantityPerYear(int[,] A)
        {
            int[] quantity = new int[A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    sum += A[i, j];
                }
                quantity[i] = sum;
            }

            int max = 0, maxi = 0;
            for (int k = 0; k < quantity.Length; k++)
            {
                if (max < quantity[k])
                {
                    max = quantity[k];
                    maxi = k;
                }
            }

            switch (maxi)
            {
                case 0:
                    Console.WriteLine("Западный филиал");
                    break;
                case 1:
                    Console.WriteLine("Центральный филиал");
                    break;
                case 2:
                    Console.WriteLine("Восточный филиал");
                    break;
            }

            Console.WriteLine($"Максимальное количество машин проданных за год: {max}"); ;
        }

        public static void QuarterMaxQuantityPerYear(int[,] A)
        {
            int[] quantity = new int[A.GetLength(1)];
            for (int i = 0; i < A.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    sum += A[j, i];
                }
                quantity[i] = sum;
            }

            int max = 0, maxi = 0; ;
            for (int k = 0; k < quantity.Length; k++)
            {
                if (max < quantity[k])
                {
                    max = quantity[k];
                    maxi = k;
                }
            }

            Console.Write("Самый успешный квартал - ");
            switch (maxi)
            {
                case 0:
                    Console.WriteLine("Квартал I");
                    break;
                case 1:
                    Console.WriteLine("Квартал II");
                    break;
                case 2:
                    Console.WriteLine("Квартал III");
                    break;
                case 3:
                    Console.WriteLine("Квартал IV");
                    break;
            }
            Console.WriteLine($"Продано машин : {max}");
            return;
        }



        static void Main(string[] args)
        {
            int[,] arr =
            {
                { 20, 21, 23, 22 },
                { 24, 20, 27, 19 },
                { 25, 18, 24, 22 },
            };
            Console.WriteLine("1. Подсчитать общее количество автомобилей, проданных всеми филиалами компании за год.");
            Console.WriteLine("2. Вывести максимальное количество автомобилей, проданных филиалом за квартал, а также название филиала и номер квартала.");
            Console.WriteLine("3. Вывести название филиала, который продал максимальное количество автомобилей по результатам года, а также проданное филиалом количество автомобилей.");
            Console.WriteLine("4. Вывести наиболее успешный квартал, в котором компания показала наилучший результат по продажам (учитываются все филиалы), а также количество автомобилей проданное в нем.");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Console.WriteLine(GeneralQuantity(arr));
                    break;
                case "2":
                    MAxQuantity(arr);
                    break;
                case "3":
                    OfficeMaxQuantityPerYear(arr);
                    break;
                case "4":
                    QuarterMaxQuantityPerYear(arr);
                    break;


            }
        }
    }
}
