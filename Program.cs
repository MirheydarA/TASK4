int[] numbers = { 4, 2, 3, 1 };
int k; 
for (int i = 0; i < numbers.Length; i++)
{
	for (int j = i; j < numbers.Length; j++)
	{
		if (numbers[i] > numbers[j] )
		{
			k = numbers[i];
			numbers[i] = numbers[j];
			numbers[j] = k;
		}
	}
}
for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine(numbers[i]);

}





////task 2
//int[] numbers = { 4, 2, 3, 1 };
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//sum = sum + numbers[i];
//}
//sum = sum / numbers.Length;
//Console.WriteLine(sum);



//task 3
int[] numbers = { 4, 2, 3, 1 };
for (int i = numbers.Length - 1; i >= 0; i--)
{
	Console.Write(numbers[i]+ " ");
	
}
