#include <stdio.h>

int main(int argc, char const *argv[])
{
    int cont;
    int i;

    char cpf[14];

    char init[3]; 
    char mid[3];
    char and[3];
    char id[2];

    scanf("%s", cpf);

    for (i = 0; i <= 2; i++)
    {
        printf("%c", cpf[i]);
    }
    printf("\n");
    for (i = 4; i <= 6; i++)
    {
        printf("%c", cpf[i]);
    }
    printf("\n");
    for (i = 8; i <= 10; i++)
    {
        printf("%c", cpf[i]);
    }
    printf("\n");
    for (i = 12; i <= 13; i++)
    {
        printf("%c", cpf[i]);
    }
    printf("\n");
    
    return 0;
}
