Console.WriteLine("enter a number");
int number = int.Parse(Console.ReadLine()!);

int convert(int arg1)
{
int arraysize = 0;
int number = arg1;
for (int index = 0; arg1 > 0; index++)
{

arg1 = arg1 / 2;

arraysize++;

}

return arraysize;
}


int[] Fillarray(int size, int number)
{
int[] array = new int[size];

for (int index = 0; index < array.Length; index++)
{
// number = number % 2;
array[index] = number % 2;
number = number / 2;

}
return array;
}
int[] Reversearray(int[] array)
{
for (int index = 0; index < array.Length / 2; index++)
{
int temp = array[index];
array[index] = array[array.Length - 1 - index];
array[array.Length - 1 - index] = temp;


}

return array;

}

convert(number);
int[] array = Fillarray(convert(number), number);
Console.WriteLine(string.Join(" ,", Reversearray(array)));