using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GamerProfile.App
{
    public class PerfilJogadorService
    {
        int bonusFixoXP = 100;
        int nivelMinimoRanked = 15;

        public string GerarTagUsuario(string nickname, string codigo)
        { return $"{nickname}#{codigo}"; }
        public int CalcularXPTotal(int xpFase1, int xpFase2)
        { return xpFase1 + xpFase2 + bonusFixoXP; }
        public bool isElegivelParaRanked(int nivelJogador)
        { return nivelJogador >= nivelMinimoRanked; }
    }
}