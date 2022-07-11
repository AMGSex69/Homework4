int Degree(int numA, int numB)
{
	int result = 1;
	for (int i = 1; i <= numB; i++)
	{
		result = result * numA;
	}
	return result;
}

Console.WriteLine("Введите целое А ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

int destination = Degree(numberA, numberB);
Console.WriteLine("Число А в степени В равно " + destination);
