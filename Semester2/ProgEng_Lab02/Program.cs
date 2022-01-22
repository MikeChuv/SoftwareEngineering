using System;

namespace ProgEng_Lab02
{
    // Задан целочисленный одномерный массив A из n элементов.
    // Найти номер первого  максимального  элемента  среди  элементов,
    // меньших  t и расположенных после первого элемента, кратного k.
    // Если нет элементов кратных k, искать с начала массива.

    // видимо, если несколько максимальных, то взять первый

    class MyArray {
        protected int[] mas;
        public MyArray() {
            int size;
            Console.Write("Array size = ");
            size = Convert.ToInt32(Console.ReadLine());
            mas = new int[size];
        
        }


        public MyArray(int size) {
            mas = new int[size];
        }


        public int? this[int index]
        {
            get
            {
                if (index < 0 || index > mas.Length)
                    return null;
                else 
                    return mas[index];
            }
            set
            {
                mas[index] = (int)value;
            }
        }

        public int Length
        {
            get {
                return mas.Length;
            }
        
        }

        public void Input() {
            for (int i = 0; i < mas.Length; ++i) {
                Console.Write("A[" + i +"] = ");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void Output() {
            foreach (int el in mas)
                Console.Write(el + " ");
            Console.WriteLine();
        }

       
    }

    class ArrayTask : MyArray{
        public int? FindFirstMultiple(int k)
        {
            int? result = null;
            for (int i = 0; i < mas.Length; ++i)
            {
                if (mas[i] % k == 0)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public int? FindFirstMaxLess(int t, int start)
        {
            int max = int.MinValue;
            int? imax = null;
            if (start > mas.Length) return imax;
            for (int i = start + 1; i < mas.Length; ++i)
            {
                if (mas[i] > max && mas[i] < t)
                {
                    max = mas[i];
                    imax = i;
                }
            }
            return imax;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayTask A;
            A = new ArrayTask();
            A.Input();
            A.Output();
            int k;
            Console.Write("k = ");
            k = Convert.ToInt32(Console.ReadLine());
            int t;
            Console.Write("t = ");
            t = Convert.ToInt32(Console.ReadLine());

            int? firstMult = A.FindFirstMultiple(k);
            int? firstMaxIdx = null;
            if (firstMult != null)
            {
                firstMaxIdx = A.FindFirstMaxLess(t, (int)firstMult);
            }
            else {
                firstMaxIdx = A.FindFirstMaxLess(t, 0);
            }
            Console.WriteLine("Index of first multiple for k is [" + firstMult + "]");
            Console.WriteLine("Index of first max = " + firstMaxIdx);
            Console.WriteLine("Indexator usage: A[0] = " + A[0]);
            Console.WriteLine("Indexator usage: A[-1] = " + A[-1]);
            Console.WriteLine("Property usage: Length = " + A.Length);
        }
    }
}
