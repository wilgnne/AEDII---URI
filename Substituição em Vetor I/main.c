#include <stdio.h>

int main(int argc, char const *argv[])
{
    int vector[10];
    int i, auxVal;

    for (i = 0; i < 10; i++)
    {
        scanf("%d", &auxVal);
        if(auxVal > 0)
        {
            vector[i] = auxVal;
        }
        else
        {
            vector[i] = 1;
        } 
    }

    for (i = 0; i < 10; i++)
    {
        printf("X[%d] = %d\n", i, vector[i]);
    }

    return 0;
}
