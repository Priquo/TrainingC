#include "MainHeader.h"

void MaxNumberFromThreeNumbersTest()
{
	int flag[] = {0, 0, 0, 0};
	double a, b, c;
	a = 10;
	b = 11;
	c = 10;	
	if (MaxNumberFromThreeNumbers(a, b, c) != b)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� �� ���������� ����� ��� ������� �����.");
		printf("\n������� ���������:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[0] = 1;
	a = 5.2;
	b = 5;
	c = 5.8;
	if (MaxNumberFromThreeNumbers(a, b, c) != c)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� �� ���������� ����� � ������� ������.");
		printf("\n������� ���������:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[1] = 1;
	a = 10;
	b = 10;
	c = 10;
	if (MaxNumberFromThreeNumbers(a, b, c) != c)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� �� ���������� �����, ������ �� ��������");
		printf("\n������� ���������:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[2] = 1;
	a = -5;
	b =-10;
	c = -11.1;
	if (MaxNumberFromThreeNumbers(a, b, c) != a)
	{
		printf("\n����������� ��������� �� ��������� � ���������. ��������� �� ���������� ������������� �����");
		printf("\n������� ���������:\na = %5.2f\tb = %5.2f\tc = %5.2f", a, b, c);
	}
	else
		flag[3] = 1;
	if (flag[0] == 1 && flag[1] == 1 && flag[2] == 1 && flag[3] == 1)
		printf("\n��������� ������ ��� �������� �������!");
}