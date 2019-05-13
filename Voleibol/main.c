#include <stdio.h>

int main(int argc, char const *argv[])
{
    float perSaque, perBloqueio, perAtaque;

    int auxTentSaque, auxTentBloqueio, auxTentAtaque;
    int auxSussSaque, auxSussBloqueio, auxSussAtaque;

    int tentSaque, tentBloqueio, tentAtaque;
    int sussSaque, sussBloqueio, sussAtaque;

    int i, totalJogadores;
    char nome[50];

    tentSaque = tentBloqueio = tentAtaque = 0;
    sussSaque = sussBloqueio = sussAtaque = 0;

    scanf("%d", &totalJogadores);

    for (i = 0; i < totalJogadores; i++)
    {
        scanf("%s", nome);
        scanf("%d %d %d", &auxTentSaque, &auxTentBloqueio, &auxTentAtaque);
        scanf("%d %d %d", &auxSussSaque, &auxSussBloqueio, &auxSussAtaque);

        tentSaque += auxTentSaque;
        tentBloqueio += auxTentBloqueio;
        tentAtaque += auxTentAtaque;

        sussSaque += auxSussSaque;
        sussBloqueio += auxSussBloqueio;
        sussAtaque += auxSussAtaque;
    }

    perSaque = ((float)sussSaque/tentSaque) * 100;
    perBloqueio = ((float)sussBloqueio/tentBloqueio) * 100;
    perAtaque = ((float)sussAtaque/tentAtaque) * 100;

    printf("Pontos de Saque: %.2f %%.\n", perSaque);
    printf("Pontos de Bloqueio: %.2f %%.\n", perBloqueio);
    printf("Pontos de Ataque: %.2f %%.\n", perAtaque);
    
    
    return 0;
}
