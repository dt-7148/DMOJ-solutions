#include <stdio.h>
#include <math.h>

int main(void) {
    int n;
    scanf("%d", &n);
    int dataArray[n][3];

    for (int i = 0; i < n; i++) {
        scanf("%d %d %d", &dataArray[i][0], &dataArray[i][1], &dataArray[i][2]);
    }

    for (int i = 0; i < n; i++) {
        int s1 = dataArray[i][0];
        int s2 = dataArray[i][1];
        int s3 = dataArray[i][2];
        

        int c;
        int a, b;

        //find the largest, which will be c
        if (s1 >= s2 && s1 >= s3) {
            c = s1;
            b = s2;
            a = s3;
        }
        else if (s2 >= s3) {
            c = s2;
            b = s1;
            a = s3;
        }
        else {
            c = s3;
            b = s2;
            a = s1;
        }

        //then compare c^2 to a^ + b^2
        int ls = pow(c, 2);
        int rs = pow(a, 2) + pow(b, 2);
        if (ls > rs) {
            printf("O\n");
        }
        else if (ls < rs) {
            printf("A\n");
        }
        else {
            printf("R\n");
        }
    }
}

// last thing to do - store all of them in an array then iterate through the array