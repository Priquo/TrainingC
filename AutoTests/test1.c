#include "MainHeader.h"

int MaxNumberFromThreeNumbers(int a, int b, int c)
{
	int result = 0;
	if (a >= b && a >= c)
		result = a;
	else if (b >= c && b >= a)
		result = b;
	else if (c >= b && c >= a)
		result = c;
	return result;
}