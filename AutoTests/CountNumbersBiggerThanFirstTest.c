#include "MainHeader.h"

void CountNumbersBiggerThanFirstTest()
{
	double example[15] = { 5.1, 15, 3.25, -4.3, 7, 2.38, -9, 0, 2.4, 11, 13, 9.1, 3.5, 1, -2 };
	int count = CountNumbersBiggerThanFirst(example);
	if  (count != 5)
		printf("\n���������� ���������, ������� �� �������� ������ �������, ���������� �� ����������. � ��� %d", count);
	else
		printf("\n���������� ���������, ������� �� �������� ������ �������, ��������� �����! ��� �����: %d", count);
	printf("\n�������� ������:\n5.1, 15, 3.25, -4.3, 7, 2.38, -9, 0, 2.4, 11, 13, 9.1, 3.5, 1, -2\n");
	

	double example1[15] = { 16, 16, 10, -20, 21, 30, 21.5, 18.32, 5, 14, 8, 2.7, 17, 16.11, -26 };
	count = CountNumbersBiggerThanFirst(example1);

	if (count != 6)
		printf("\n���������� ���������, ������� �� �������� ������ �������, ���������� �� ����������. � ��� %d", count);
	else
		printf("\n���������� ���������, ������� �� �������� ������ �������, ��������� �����! ��� �����: %d", count);
	printf("\n�������� ������:\n16, 16, 10, -20, 21, 30, 21.5, 18.32, 5, 14, 8, 2.7, 17, 16.11, -26\n");
	
}