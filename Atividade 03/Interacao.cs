using System;

namespace Atividade_03
{
    interface Interacao
    {
        void Usar();
        void Carregar(string CCor, int CCarga);
        void TrocarCor(string CCor);
        void TrocarTexto(string TTexto);
    }
}