#include <stdio.h>
#include <math.h>

int main(int argc, char const *argv[])
{
    int tamanho, pares, i, j, aux, par;

    while (1)
    {
        scanf("%d", &tamanho);
        if (tamanho == 0)
            break;
        
        pares = (int)ceil(tamanho/2.0f);


        for (i = 0; i < tamanho; i++)
        {
            for (j = 0; j < tamanho; j++)
            {
                for (par = pares-1; par >= 0; par--)
                {
                    if (i == par || i == tamanho - par -1 || j == tamanho - par -1 || j == par)
                    {
                        aux = par +1;
                    }
                }
                if (j != 0)
                    printf(" ");
                if (aux < 10)
                    printf(" ");
                printf(" ");
                printf("%d", aux);
            }
            printf("\n");
        }
        printf("\n");
    }

    return 0;
}
