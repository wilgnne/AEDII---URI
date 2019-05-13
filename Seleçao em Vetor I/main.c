#include <stdio.h>

int main(int argc, char const *argv[])
{
    float vector[100];
    int i;
    float auxVal;

    for (i = 0; i < 100; i++)
    {
        scanf("%f", &auxVal);
        vector[i] = auxVal;
    }

    for (i = 0; i < 100; i++)
    {
        if (vector[i] <= 10)
        {
            printf("A[%d] = %.1f\n", i, vector[i]);
        }
    }

    return 0;
}
