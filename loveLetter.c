// #include <stdio.h>
// #include <ctype.h>

// void readnLines(char word[], int size);

// int main(void) {

//     //have a for loop go forwards, if it is z, loop back to a
//     //this will involve having a nested for loop, have the inner one run only if the cahr si an alphabet letter with isalpha()


//     int length;
//     int key;

//     scanf("%d", &length);
//     scanf("%d", &key);

//     char letter[length + 1];
//     readnLines(letter, length + 1);

//     for (int i = 0; letter[i] != '\0'; i++) {
//         if (isalpha(letter[i])) {

//             char ch = letter[i];
            
//             for (int j = 0; j < key; j++) {
//                 if (ch == 'z') {
//                     ch = 'a';
//                 }
//                 else {
//                     ch++;
//                 }
//             }
            
//             letter[i] = ch;
//         }

//     }

//     printf("%s", letter);

//     return 0;
// }

// void readnLines(char word[], int size) {
//     char ch;

//     for (int i = 0; i < size; i++) {
//             ch = getchar();
//             word[i] = ch;
//     }

//     word[size] = '\0';

// }