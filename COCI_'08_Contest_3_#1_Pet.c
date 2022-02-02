#include <stdio.h>

int main(void) {
    int s1, s2, s3, s4;
    int sum;
    int largestSum = 0;
    int winner;

    for (int i = 1; i < 6; i++) {
        scanf("%d %d %d %d", &s1, &s2, &s3, &s4);

        sum = s1 + s2 + s3 + s4;

        if (sum > largestSum) {
            largestSum = sum;
            winner = i;
        }
    }

    printf("%d %d\n", winner, largestSum);

}
