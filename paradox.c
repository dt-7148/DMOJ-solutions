// from https://dmoj.ca/problem/bts16p2

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int searchArray(char *ch[], char operation, char thing[5]);

char *ch[2];

int main(void) {

    int numOperations;
    scanf("%d", &numOperations);

    char curCommand[7];
    char operation;

    for (int i = 0; i < numOperations + 1; i++) {
        fgets(curCommand, 7, stdin);
        
        // t = true, f = false
        if (strlen(curCommand) == 1) {
            operation = 'a';
        }
        else {
            curCommand[2];
        }

        switch (curCommand[0]) {
            // check if doesnt exist, if it doesnt add it
            case '1':
                break;
            
            // check if it exists, and if it does, remove it
            case '2':
                break;
            // find the index of item
            case '3':
                break;
            // print out items going false -> true
            default:
                break;
        }
    } 
    return 0;
}

int searchArray(char *ch[], char operation, char thing[5]) {
    return -1;
}