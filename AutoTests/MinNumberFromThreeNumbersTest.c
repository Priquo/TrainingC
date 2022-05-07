#include "MainHeader.h"

void MinNumberFromThreeNumbersTest()
{
	int flag[] = { 0, 0, 0, 0 };
	double a, b, c;
	a = 10;
	b = 11;
	c = 9;
	if (MinNumberFromThreeNumbers(a, b, c) != c)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Программа не обработала числа без дробной части.");
		printf("\nВходные параметры:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[0] = 1;
	a = 5.2;
	b = 5.0;
	c = 5.8;
	if (MinNumberFromThreeNumbers(a, b, c) != b)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Программа не обработала числа с дробной частью.");
		printf("\nВходные параметры:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[1] = 1;
	a = 10;
	b = 10;
	c = 10;
	if (MinNumberFromThreeNumbers(a, b, c) != c)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Программа не обработала числа, равные по значению");
		printf("\nВходные параметры:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[2] = 1;
	a = -5;
	b = -10;
	c = -11.1;
	if (MinNumberFromThreeNumbers(a, b, c) != c)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Программа не обработала отрицательные числа");
		printf("\nВходные параметры:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[3] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1 && flag[3] == 1)
		printf("\nПрограмма прошла все проверки успешно!");
}