#include "MainHeader.h"

double* SortDescArray(double a[15]) {
	return a;
}

void SortDescArrayTest()
{
	double example[15] = { 5.1, 15, 3.25, -14.3, 0, 8.88, 9, 0, 2.4, -4, 103, 2.2, 3.5, 1, -2 };
	double expected[15] = { -2, 1, 3.5, -2.2, 103, -4, 2.4, 0, 9, 8.88, 0, -14.3, 3.25, 15, 5.1 };
	double* a = SortDescArray(example);
	int flag = 0;
	for (int i = 0; i < 15; i++) 
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
	printf("\nИсходный массив:\n5.10, 15.00, 3.25, -14.30, 0.00, 8.88, 9.00, 0.00, 2.40, -4.00, 103.00, 2.20, 3.50, 1.00, -2.00\n\nВаш массив:\n");
	for (int i = 0; i < 15; i++)
	{
		if (i != 14)
			printf("%.2f, ", a[i]);
		else
			printf("%.2f\n", a[i]);
	}

	double example1[15] = { 16, 1, 10, -20, 21, 30, 21.5, 1.32, 5, 14, 8, 2.7, 17, 3.11, -26 };
	double expected1[15] = { -26, 3.11, 17, 2.7, 8, 14, 5, 1.32, 21.5, 30, 21, -20, 10, 1, 16 };
	double* b = SortDescArray(example1);
	int flag1 = 0;
	for (int i = 0; i < 15; i++)
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
	printf("\nИсходный массив:\n16.00, 1.00, 10.00, -20.00, 21.00, 30.00, 21.50, 1.32, 5.00, 14.00, 8.00, 2.70, 17.00, 3.11, -26.00\n\nВаш массив:\n");
	for (int i = 0; i < 15; i++)
	{
		if (i != 14)
			printf("%.2f, ", b[i]);
		else
			printf("%.2f\n", b[i]);
	}
}