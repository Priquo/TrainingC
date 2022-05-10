#include "MainHeader.h"

void ChangeEvenNumToMaxTest()
{
	int example[11] = { 11, -4, 6, 3, 26, 11, 5, 17, -3, 8, -8 };
	int expected[11] = { 11, 26, 26, 3, 26, 11, 5, 17, -3, 26, 26 };
	int* a = ChangeEvenNumToMax(example);
	int flag = 0;
	for (int i = 0; i < 11; i++)
	{
		if (a[i] != expected[i])
		{
			flag = 1;
			break;
		}

	}
	if (flag == 1)
		printf("\nСортировка не соответствует ожидаемой.");
	else
		printf("\nСортировка прошла успешно!");
	printf("\nИсходный массив:\n11, -4, 6, 3, 26, 11, 5, 17, -3, 8, -8\n\nВаш массив:\n");
	for (int i = 0; i < 11; i++)
	{
		if (i != 11)
			printf("%d, ", a[i]);
		else
			printf("%d\n", a[i]);
	}

	int example1[11] = { 1, 8, 2, 98, 55, 43, -25, 0, 1, -44, 13 };
	int expected1[11] = { 1, 98, 98, 98, 55, 43, -25, 98, 1, 98, 13 };
	int* b = ChangeEvenNumToMax(example1);
	int flag1 = 0;
	for (int i = 0; i < 11; i++)
	{
		if (b[i] != expected1[i])
		{
			flag1 = 1;
			break;
		}

	}
	if (flag1 == 1)
		printf("\nСортировка не соответствует ожидаемой.");
	else
		printf("\nСортировка прошла успешно!");
	printf("\nИсходный массив:\n1, 8, 2, 98, 55, 43, -25, 0, 1, -44, 13\n\nВаш массив:\n");
	for (int i = 0; i < 11; i++)
	{
		if (i != 11)
			printf("%d, ", b[i]);
		else
			printf("%d\n", b[i]);
	}
}