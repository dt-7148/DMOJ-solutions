#include <stdio.h>

int main()
{
    int a, b, c;
    
    scanf("%d", &a);
    scanf("%d", &b);
    scanf("%d", &c);
    
    if (a + (2 * b) + (3 * c) >= 10) {
        printf("happy");
    }
    else 
    {
        printf("sad");
    }

    return 0;
}
