using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamerProfile.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var perfilJogadorService = new PerfilJogadorService();
            
            string tagUsuario = perfilJogadorService.GerarTagUsuario("Leandro", "1234");
            int xpTotal = perfilJogadorService.CalcularXPTotal(500, 300);
            bool isEligivelRanked = perfilJogadorService.isElegivelParaRanked(15);
            
            Console.WriteLine("Tag Usuario: " + tagUsuario);  
            
            Console.WriteLine("Nivel Jogador: " + xpTotal);          
            
            if (isEligivelRanked)
            { Console.WriteLine("Jogador Elegivel para Ranked."); } 
            else 
            { Console.WriteLine("Jogador não é Elegivel para Ranked."); }
        }
    }
}