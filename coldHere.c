#include <stdio.h>
#include <string.h>

#define bool int
#define TRUE 1
#define FALSE 0

int main()
{
    bool canContinue = TRUE;
    int temp;
    char buf[256];
    
    int coldestTemp = 0;
    char coldestPlace[256];
    
    
    while (canContinue) {
        scanf("%s %d", buf, &temp);
        
        if (temp < coldestTemp) {
            strcpy(coldestPlace, buf);
            coldestTemp = temp;
        }
        
        if (strcmp(buf, "Waterloo") == 0) {
            canContinue = FALSE;
        }
    }
    
    printf("%s", coldestPlace);

    return 0;
}
