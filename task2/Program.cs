Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int numberA)
{
	int counter = Convert.ToString(numberA).Length;
	int achieve = 0;
	int result = 0;

	for (int i = 0; i < counter; i++)
	{
		achieve = numberA - numberA % 10;
		result = result + (numberA - achieve);
		numberA = numberA / 10;
	}

	return result;
}

int numberSum = SumOfNumbers(number);
Console.WriteLine("Сумма числен равна " + numberSum);