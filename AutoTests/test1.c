#include "MainHeader.h"

double MaxSumFromThreeNumbers(double a, double b, double c)
{
	double result = 0;
	if (a >= b && b >= c)
		result = a + b;
	else if ((a >= c && c >= b) || (c >= a && a >= b))
		result = a + c;
	else if (b >= c && c >= a)
		result = b + c;
	return result;
}