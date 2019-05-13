#include <stdio.h>

int main(int argc, char const *argv[])
{
    int tam, i, pos, min, auxVal;

    scanf("%d", &tam);

    pos = 0;
    scanf("%d", &min);

    for (i = 1; i < tam; i++)
    {
        scanf("%d", &auxVal);
        if (auxVal < min)
        {
            min = auxVal;
            pos = i;
        }
    }
    
    printf("Menor valor: %d\nPosicao: %d\n", min, pos);

    return 0;
}
