#include "MainHeader.h"

void IsNumberToThirdPowerTest()
{
	int flag[] = { 0, 0, 0, 0 };
	int a, b, c;
	a = 10;
	if (IsNumberToThirdPower(a) != 0)
	{
		printf("\nФактический результат не совпадает с ожидаемым.");
		printf("\nВходные параметры:\na = %5.2d", a);
	}
	else
		flag[0] = 1;
	a = 81;
	if (IsNumberToThirdPower(a) != 1)
	{
		printf("\nФактический результат не совпадает с ожидаемым.");
		printf("\nВходные параметры:\na = %5.2d", a);
	}
	else
		flag[1] = 1;
	a = 3;
	if (IsNumberToThirdPower(a) != 1)
	{
		printf("\nФактический результат не совпадает с ожидаемым.");
		printf("\nВходные параметры:\na = %5.2d", a);
	}
	else
	a = 18;
	if (IsNumberToThirdPower(a) != 0)
	{
		printf("\nФактический результат не совпадает с ожидаемым.");
		printf("\nВходные параметры:\na = %5.2d", a);
	}
	else
		flag[2] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1 && flag[3] == 1)
		printf("\nПрограмма прошла все проверки успешно!");
}