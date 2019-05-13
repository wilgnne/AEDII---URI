#include <stdio.h>

int main(int argc, char const *argv[])
{
    char op;
    double matriz [12][12];
    double aux;
    int i, j;


    int max = 10;
    int min = 1;
    int linha = 0;
    int coluna = min;

    double sum = 0;

    scanf("%c", &op);

    for (i = 0; i < 12; i++)
    {
        for (j = 0; j < 12; j++)
        {
            scanf(" %lf",&aux);
            matriz[i][j] = aux;
        }
    }
    

    while (max >= 2)
    {
        while (coluna <= max)
        {
            sum = sum + matriz[linha][coluna];
            coluna++;
        }
        coluna = ++min;
        linha++;
        max -= 1;
    }

    if (op == 'S')
    {
        printf("%.1lf\n", sum);
    }
    else if (op == 'M')
    {
        printf("%.1lf\n", sum/30.0f);
    }
    
    
    
    

    return 0;
}
