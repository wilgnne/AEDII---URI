#include <stdio.h>

int main(int argc, char const *argv[])
{
    int val, i, attVal;
    scanf("%d", &val);

    for (i = 0; i < 1000; i++)
    {
        attVal = i % val;
        printf("N[%d] = %d\n", i, attVal);
    }
    

    return 0;
}
