using System;

public class Class1
{
	// this is the constructor of the class Class1
	public Class1()
	{
	}

	public static void Ex1()
	{
		int[] lst = new int[100];

		for (int i = 0; i < 100; i++)
		{
            Random rd = new Random();
			lst[i] = rd.Next(0, 100);
        }

		int largest = lst[0];
		for (int i = 1; i < 100; i++)
		{
			if (largest < lst[i])
			{
				largest = lst[i];
			}
		}

		Console.WriteLine(largest);
	}

	public static void Ex2()
	{
		int[] lst = new int[10];
		for (int i = 0; i < 10; i++)
		{
			lst[i] = i;
		}

		for (int i = 0; i < 10; i++)
		{
			Console.Write(lst[i] + " ");
		}

		for (int i = 0; i < 5; i++)
		{
			int temp = lst[i];
			lst[i] = lst[9 - i];
			lst[9 - i] = temp;
		}

		Console.WriteLine();

        for (int i = 0; i < 10; i++)
        {
            Console.Write(lst[i] + " ");
        }
    }
}
