#include "MainHeader.h"

void SumSqrtOrSqrtSumTest()
{
	int flag[] = { 0, 0, 0, 0 };
	double a, b;
	a = 10;
	b = 11;
	if (SumSqrtOrSqrtSum(a, b) != 441)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Квадрат суммы оказался больше.");
		printf("\nВходные параметры:\na = %5.2d\tb = %5.2d\t", a, b);
	}
	else
		flag[0] = 1;
	a = -5;
	b = 8;
	if (SumSqrtOrSqrtSum(a, b) != 39)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Сумма квадратов оказалась больше.");
		printf("\nВходные параметры:\na = %5.2d\tb = %5.2d\t", a, b);
	}
	else
		flag[1] = 1;
	a = -7;
	b = -11;
	if (SumSqrtOrSqrtSum(a, b) != 324)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Квадрат суммы оказался больше.");
		printf("\nВходные параметры:\na = %5.2d\tb = %5.2d\t", a, b);
	}
	else
		flag[2] = 1;
	a = 0;
	b = 3;
	if (SumSqrtOrSqrtSum(a, b) != 9)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Программа не обработала одинаковый результат в обоих вычислениях");
		printf("\nВходные параметры:\na = %5.2d\tb = %5.2d\t", a, b);
	}
	else
		flag[3] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1 && flag[3] == 1)
		printf("\nПрограмма прошла все проверки успешно!");
}