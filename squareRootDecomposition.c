#include <stdio.h>
#include <math.h>
#include <stdlib.h>

int main()
{
    int n;
    int a;
    int b;
    int aDiff;
    int bDiff;
    
    scanf("%d", &n);
    scanf("%d", &a);
    scanf("%d", &b);
    
    a = pow(a, 2);
    b = pow(b, 2);
    
    aDiff = abs(n - a);
    bDiff = abs(n - b);
    
    if (aDiff < bDiff) {
        printf("1\n");
    }
    else {
        printf("2\n");
    }

    return 0;
}
