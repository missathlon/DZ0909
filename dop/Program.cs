// В фермерском хозяйстве в Карелии выращивают чернику. Она растет на круглой грядке, 
// причем кусты высажены только по окружности. Таким образом, 
// у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.

// Эти кусты обладают разной урожайностью, поэтому ко времени сбора на них выросло 
// различное число ягод – на i-ом кусте выросло ai ягод.

// В этом фермерском хозяйстве внедрена система автоматического сбора черники. 
// Эта система состоит из управляющего модуля и нескольких собирающих модулей. 
// Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, 
// собирает ягоды с этого куста и с двух соседних с ним.

// Напишите программу для нахождения максимального числа ягод, 
// которое может собрать за один заход собирающий модуль, 
// находясь перед некоторым кустом заданной во входном файле грядки.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит целое число N (3 ≤ N ≤ 1000) – 
// количество кустов черники. 
// Вторая строка содержит N целых положительных чисел a1, a2, ..., aN – 
// число ягод черники, растущее на соответствующем кусте. Все ai не превосходят 1000.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите ответ на задачу.

Console.Write("Vvedite kolichestvo kustov = ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 3 || N > 1000)
{
    Console.Write("Vvedite kolichestvo kustov 3 <= N <= 1000 ");
    N = Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[N];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
int s1 = array[0] + array[N - 1] + array[N - 2];
int s2 = array[N - 1] + array[0] + array[1];
int max = s1;
if (s2 > s1) max = s2;
for (int i = 2; i < array.Length - 2; i++)
{
    int s3 = array[i] + array[i + 1] + array[i + 2];
    if (s3 > max)
    {
        max = s3;
        s3 = 0;
    }
    else s3 = 0;
}
Console.WriteLine("max = " + max);