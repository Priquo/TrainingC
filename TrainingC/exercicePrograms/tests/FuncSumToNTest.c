#include "MainHeader.h"

void FuncSumToNTest()
{
	int flag[] = { 0, 0, 0};
	double a;
	int b;
	a = 3;
	b = 5;
	if (FuncSumToN(a, b) != 364 && FuncSumToN(b, a) != 364)
	{
		printf("\nФактический результат не совпадает с ожидаемым.");
		printf("\nВходные параметры:\na = %5.2f\tb = %d\t", a, b);
	}
	else
		flag[0] = 1;
	a = 0;
	b = 8;
	if (FuncSumToN(a, b) != 1 && FuncSumToN(b, a) != 1)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Программа не обработала число, равное нулю.");
		printf("\nВходные параметры:\na = %5.2f\tb = %d\t", a, b);
	}
	else
		flag[1] = 1;
	a = 0.24;
	b = 2;
	if (FuncSumToN(a, b) != 0.0576 && FuncSumToN(b, a) != 0.0576)
	{
		printf("\nФактический результат не совпадает с ожидаемым. Программа не обработала число с дробной частью.");
		printf("\nВходные параметры:\na = %5.2f\tb = %d\t", a, b);
	}
	else
		flag[2] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1)
		printf("\nПрограмма прошла все проверки успешно!");
}