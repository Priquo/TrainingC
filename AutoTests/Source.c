#include "MainHeader.h"

void main()
{
	system("chcp 1251>nul");
	double temp = MaxSumFromThreeNumbers(5, 5, 5);
	if (temp != 10)
		printf("���� ������� �������� ����������� � �����������: 5, 5, 5");
	else
		printf("���� ������� �������� ��������� � �����������: 5, 5, 5");
	temp = MaxSumFromThreeNumbers(5.5, 5, 5.56);
	double result = 11.06;
	if (temp != 5.5 + 5.56)
		printf("\n���� ������� �������� ����������� � �����������: 5.5, 5, 5.56");
	else
		printf("\n���� ������� �������� ��������� � �����������: 5.5, 5, 5.56");
	temp = MaxSumFromThreeNumbers(0, 0.3, -5);
	if (temp != (double)(0.3))
		printf("\n���� ������� �������� ����������� � �����������: 0, 0.3, -5");
	else
		printf("\n���� ������� �������� ��������� � �����������: 0, 0.3, -5");
}