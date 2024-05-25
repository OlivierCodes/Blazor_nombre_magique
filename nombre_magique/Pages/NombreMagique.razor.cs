using Microsoft.AspNetCore.Components;
using System;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;

namespace nombre_magique.Pages
{
    public partial class NombreMagiqueBase : ComponentBase
    {

        protected const int NbLifesMax = 5;
        protected const int NbMax = 20;
        protected int nbMagic;
        protected int nbRemaningLifes;
        protected bool? gameWon;
        protected int value;

        protected override void OnInitialized()
        {
            ReinitGame();
            base.OnInitialized();
        }

        protected void ReinitGame()
        {
            var random = new Random();

            nbMagic = random.Next(NbMax);
            nbRemaningLifes = NbLifesMax;
            gameWon = null;
            value = 0;
        }

        // Methode pour tester la valeur de l'utilisateur
        protected void TestNumber()
        { 
        
            if(value == nbMagic)
            {
                gameWon = true;
            }else
            {
                nbRemaningLifes--;
                if(nbRemaningLifes == 0)
                {
                    gameWon = false;
                }
            }
        
        }


    }
}
