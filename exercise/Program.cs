using System.Diagnostics;

/*
 * Безусловно, скорость обработки структур и классов отличается, и заключается это главным образом в том, что класс представляет собой ссылочный
 * тип данных, а структура значимый. К примеру, при передаче структуры в качестве параметра какого-нибудь метода скорость работы будет меньше(фиксится
 * передачей по ссылке ref, out, in), чем если бы мы передавалм класс, т.к. поля, свойства и тд. из структуры полностью копировались в новую, в отличие 
 * от класса, который передаёт значение по ссылке. Также при заполнении массива скорость выше у структур, т.к. значение сразу же присваивается элементу
 * массива, классу же необходимо время для выделения памяти в управляемой куче,также у классов, как у ссылочных типов присутствует сборщик мусора,
 * который также тормозит работу. При получении и изменении значений в массиве происходит та же картина: массиву необходимо получить ссылку на 
 * объект класса, а объект в свою очередь тоже является ссылкой, по которой уже находятся значения.
 */
namespace exercise
{
    class SampleClass
    {
        public int intValue;
        public bool boolValue; 

        public SampleClass()
        {
            Random random = new Random();
            intValue = random.Next(100);
            if (intValue % 2 != 0)
                boolValue = true;
            else
                boolValue = false;
        }
    }
    struct SampleStruct
    {
        public int intValue;
        public bool boolValue;

        public SampleStruct()
        {
            Random random = new Random();
            intValue = random.Next(100);
            if (intValue % 2 != 0)
                boolValue = true;
            else
                boolValue = false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Замер скорости создания массива объектов класса

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            SampleClass[] classArray = new SampleClass[10000];

            for (int i = 0; i < classArray.Length; i++)
                classArray[i] = new SampleClass();

            stopwatch.Stop();
            Console.WriteLine("Скорость создания массива объектов класса:" + stopwatch.ElapsedMilliseconds);

            //Замер скорости создания массива объектов структуры

            stopwatch.Restart();
            stopwatch.Start();
            SampleStruct[] structsArray = new SampleStruct[10000];

            for (int i = 0; i < classArray.Length; i++)
                structsArray[i] = new SampleStruct();

            stopwatch.Stop();
            Console.WriteLine("Скорость создания массива объектов структуы:" + stopwatch.ElapsedMilliseconds);

            // Изменение полей объектов класса в массиве

            stopwatch.Restart();
            stopwatch.Start();

            for (int i = 0; i < classArray.Length; i++)
            {
                Random random = new Random();
                classArray[i].intValue = random.Next(100);
                if (classArray[i].boolValue == true)
                    classArray[i].boolValue = false;
                else
                    classArray[i].boolValue = true;
            }

            stopwatch.Stop();
            Console.WriteLine("Скорость изменения полей объектов класса в массиве:" + stopwatch.ElapsedMilliseconds);

            // Изменение полей объектов структуре в массиве

            stopwatch.Restart();
            stopwatch.Start();

            for (int i = 0; i < structsArray.Length; i++)
            {
                Random random = new Random();
                structsArray[i].intValue = random.Next(100);
                if (structsArray[i].boolValue == true)
                    structsArray[i].boolValue = false;
                else
                    structsArray[i].boolValue = true;
            }

            stopwatch.Stop();
            Console.WriteLine("Скорость изменения полей объектов структуре в массиве:" + stopwatch.ElapsedMilliseconds);
        }
    }
}