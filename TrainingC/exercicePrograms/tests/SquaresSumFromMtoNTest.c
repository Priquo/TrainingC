#include "MainHeader.h"

void SquaresSumFromMtoNTest()
{
	int flag[] = { 0, 0, 0, 0 };
	int a, b;
	a = 1;
	b = 5;
	if (SumSqrtOrSqrtSum(a, b) != 45)
	{
		printf("\n����������� ��������� �� ��������� � ���������.");
		printf("\n������� ���������:\na = %d\tb = %d\t", a, b);
	}
	else
		flag[0] = 1;
	a = -5;
	b = -3;
	if (SumSqrtOrSqrtSum(a, b) != 50)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ����� ��������� �������.");
		printf("\n������� ���������:\na = %d\tb = %d\t", a, b);
	}
	else
		flag[1] = 1;
	a = 0;
	b = 1;
	if (SumSqrtOrSqrtSum(a, b) != 1)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ����� ��������� �������.");
		printf("\n������� ���������:\na = %d\tb = %d\t", a, b);
	}
	else
		flag[2] = 1;
	a = 15;
	b = 20;
	if (SumSqrtOrSqrtSum(a, b) != 1855)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ����� ��������� �������.");
		printf("\n������� ���������:\na = %d\tb = %d\t", a, b);
	}
	else
		flag[3] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1 && flag[3] == 1)
		printf("\n��������� ������ ��� �������� �������!");
}