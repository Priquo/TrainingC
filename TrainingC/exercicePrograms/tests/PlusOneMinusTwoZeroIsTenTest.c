#include "MainHeader.h"

void PlusOneMinusTwoZeroIsTenTest()
{
	int flag[] = { 0, 0, 0};
	int a, b, c;
	a = 10;
	if (PlusOneMinusTwoZeroIsTen(a) != a + 1)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� �� ���������� ������������� �����.");
		printf("\n������� ���������:\na = %5.2d", a);
	}
	else
		flag[0] = 1;
	a = 0;
	if (PlusOneMinusTwoZeroIsTen(a) != 10)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� �� ���������� �����, ������ ����.");
		printf("\n������� ���������:\na = %5.2d", a);
	}
	else
		flag[1] = 1;
	a = -13;
	if (PlusOneMinusTwoZeroIsTen(a) != a - 2)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� �� ���������� ������������� �����");
		printf("\n������� ���������:\na = %5.2d", a);
	}
	else
		flag[2] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1)
		printf("\n��������� ������ ��� �������� �������!");
}