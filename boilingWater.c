#include <stdio.h>

int main(void) {

    int temp;

    scanf("%d", &temp);

    int pressure = 5 * temp - 400;

    printf("%d\n", pressure);

    if (pressure > 100) {
        printf("-1");
    }
    else if (pressure < 100) {
        printf("1");
    }
    else {
        printf("0");
    }


    return 0;
}