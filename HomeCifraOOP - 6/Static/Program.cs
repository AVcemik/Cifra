// Домашняя работа
// 1. Напишите программу со статическим методом, аргументом которому передается целочисленный массив,
// а результатом возвращается среднее значение для элементов массива
// (сумма значений элементов, деленная на количество элементов в массиве).

// 2. Напишите программу со статическим методом, аргументом которому передается одномерный символьный массив.
// В результате вызова метода элементы массива попарно меняются местами:
// первый - с последним, второй - с предпоследним и так далее.

int[] masiv1 = new int[] { 2, 5, 9, 4, 3 };
int[] masiv2 = new int[] { 5, 8, 3};

char[] masiv3 = new char[] { 'a', 'b', 'c', 'd' };
char[] masiv4 = new char[] { 'z', 'g', 'u', 's','j','d','j','p' };

Console.WriteLine("Среднее значение массива1: {0:F2}", AverageArray(masiv1));
Console.WriteLine("Среднее значение массива2: {0:F2}", AverageArray(masiv2));
Console.WriteLine("----------------------------------------------");
Console.WriteLine("Зеркальный массив3: {0}", SwapSymbol(masiv3));
Console.WriteLine("Зеркальный массив4: {0}", SwapSymbol(masiv4));
static double AverageArray(int[] masiv)
{
	double result = 0;
	for (int i = 0; i < masiv.Length; i++)
	{
		result += masiv[i];
	}
	result /= masiv.Length;
	return result;
}

static string SwapSymbol(char[] masiv)
{
	string result = null;
	char temp;
	for (int i = 0, j = masiv.Length-1; i < masiv.Length/2; i++, j--)
	{
		temp = masiv[i];
		masiv[i] = masiv[j];
		masiv[j] = temp;
	}
	for (int i = 0; i < masiv.Length; i++)
	{
		result += masiv[i];
	}
	return result;
}
