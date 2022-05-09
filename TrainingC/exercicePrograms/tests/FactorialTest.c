#include "MainHeader.h"

void FactorialTest()
{
	int flag[] = { 0, 0, 0, 0 };
	int a;
	a = 1;
	if (Factorial(a) != 1)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Факториал единицы не вычислен");
		printf("\nВходные параметры:\na = %d", a);
	}
	else
		flag[0] = 1;
	a = 0;
	if (Factorial(a) != 0)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Факториал нуля не вычислен");
		printf("\nВходные параметры:\na = %d", a);
	}
	else
		flag[1] = 1;
	a = 7;
	if (Factorial(a) != 5040)
	{
		printf("\nФактический результат не совпадает с ожидаемым.");
		printf("\nВходные параметры:\na = %d", a);
	}
	else
		flag[2] = 1;
	a = 9;
	if (Factorial(a) != 362880)
	{
		printf("\nФактический результат не совпадает с ожидаемым.");
		printf("\nВходные параметры:\na = %d", a);
	}
	else
		flag[3] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1 && flag[3] == 1)
		printf("\nПрограмма прошла все проверки успешно!");
}