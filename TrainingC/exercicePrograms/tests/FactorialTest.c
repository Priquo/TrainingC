#include "MainHeader.h"

void FactorialTest()
{
	int flag[] = { 0, 0, 0, 0 };
	int a;
	a = 1;
	if (Factorial(a) != 1)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� ������� �� ��������");
		printf("\n������� ���������:\na = %d", a);
	}
	else
		flag[0] = 1;
	a = 0;
	if (Factorial(a) != 0)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� ���� �� ��������");
		printf("\n������� ���������:\na = %d", a);
	}
	else
		flag[1] = 1;
	a = 7;
	if (Factorial(a) != 5040)
	{
		printf("\n����������� ��������� �� ��������� � ���������.");
		printf("\n������� ���������:\na = %d", a);
	}
	else
		flag[2] = 1;
	a = 9;
	if (Factorial(a) != 362880)
	{
		printf("\n����������� ��������� �� ��������� � ���������.");
		printf("\n������� ���������:\na = %d", a);
	}
	else
		flag[3] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1 && flag[3] == 1)
		printf("\n��������� ������ ��� �������� �������!");
}