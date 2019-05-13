#include <stdio.h>
#include <string.h>

int main(int argc, char const *argv[])
{
    char twitter[500];
    int len;
    scanf("%[^\n]", twitter);
    len = strlen(twitter);

    if (len > 140)
    {
        printf("MUTE\n");
    }
    else
    {
        printf("TWEET\n");
    }
    
    return 0;
}
