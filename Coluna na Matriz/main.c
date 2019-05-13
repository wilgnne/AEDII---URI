#include <stdio.h>
#define leng 12

int main(int argc, char const *argv[])
{
    float matriz[leng][leng];
    float aux, result;
    int col, i, j;
    char op;

    scanf("%d", &col);
    scanf(" %c", &op);

    i = j = result = 0;
    for (i = 0; i < leng; i++)
    {
        for (j = 0; j < leng; j++)
        {
            scanf("%f", &aux);
            matriz[i][j] = aux;
        }
    }

    if (op == 'S')
    {
        for (i = 0; i < leng; i++)
        {
            result += matriz[i][col];
        }
    }
    else if (op == 'M')
    {
        for (i = 0; i < leng; i++)
        {
            result += matriz[i][col];
        }

        result /= leng;
    }

    printf("%.1f\n", result);

    return 0;
}
