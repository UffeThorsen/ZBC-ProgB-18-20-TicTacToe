using System;
namespace TicTacToe
{
    class Game
    {
        //int der hjælper med tur-bestemmelse. Denne int vil enten være 1 eller 2. Dette indikerer spiller 1's tur og spiller 2's tur.
        int currentPlayer = 1;

        //Bool der skal blive True hvis kryds vinder. Kryds har turen 1
        bool harKrydsVundet = false;
        //Bool der skal blive true hvis bolle vinder. Bolle har tur 2
        bool harBolleVundet = false;

        Board spillebraet = new Board();

        /// <summary>
        /// Udfører en tur (En tur består af at placere en brik, tjekke om spilleren har vundet og skifte spiller)
        /// </summary>
        /// <param name="hor"> Hvor playeren vil placere på den horizontale akse </param>
        /// <param name="ver"> Hvor playeren vil placere på den vertikale akse </param>
        public void Tur(int hor, int ver)
        {
            spillebraet.Place(hor,ver,currentPlayer);
            
            if (HasPlayerWon(currentPlayer))
            {
                if (currentPlayer == 1)
                {
                    harKrydsVundet = true;
                }
                else if (currentPlayer == 2)
                {
                    harBolleVundet = true;
                }
            }
            Turskift();
        }

        //Skifter tur
        void Turskift()
        {
            if (currentPlayer == 1)
            {
                currentPlayer++;
            }
            else if (currentPlayer == 2)
            {
                currentPlayer--;
            }
        }
        bool HasPlayerWon(int player)
        {
            if (spillebraet.ThreeInARow(player))
            {
                return true;
            }
            return false;
        }

        string 
    }
}
