#include <stdio.h>

int main(int argc, char const *argv[])
{
    int i;
    int vetor[20];

    for (i = 19; i >= 0; i--)
    {
        scanf("%d", &vetor[i]);
    }
    for (i = 0; i < 20; i++)
    {
        printf("N[%d] = %d\n", i, vetor[i]);
    }

    return 0;
}
