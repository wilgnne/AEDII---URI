#include <stdio.h>

int main(int argc, char const *argv[])
{
    int cont, quant, codAux, quantAux;
    float prices[5] = {1.5f, 2.5f, 3.5f, 4.5f, 5.5f};
    float val;

    scanf("%i", &quant);
    cont = 0;
    while (cont < quant)
    {
        scanf("%i %i", &codAux, &quantAux);
        codAux = codAux - 1001;
        val += quantAux * prices[codAux];

        cont++;
    }
    printf("%.2f\n", val);
    return 0;
}
