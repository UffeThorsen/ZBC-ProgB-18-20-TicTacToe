using System;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using TicTacBæver_Hasp.NET.co.uk;
using TicTacBæver_Hasp.NET.co.uk.Shared;
using TicTacToe;

namespace TicTacBæver_Hasp.NET.co.uk
{
    public static class BeaverUI
    {

        public static IPlayer a;
        public static IPlayer b;
        public static Game game;
        public static Placement nextPlayerMove;
        public static Action pageUpdate = null;
        public static IPlayer[] AIs =
        {
            new BeaverPlayer(),
            new AntonAI(),
            new BirksVeryBadAI(),
            new DanielsEpicAI(),
            new JacobIAI(),
            new JacobAAI(),
            //new JannieAIPlayer(),
            //new KarlGustavAI(),
            new KasperAI(),
            new MFBadAI(),
            new PoppeAi(),
            new RasmusAI(),
            new StigAI(),
            new ThomasAIPlayer(),
            new UffeAIPlayer(),
            new UffeSmarterAIPlayer()
        };

        static bool timerStarted = false;
        static bool hasClicked = false;

        public static string SymbolToImage(Symbol s)
        {
            if (s == Symbol.X) return "/beaver.png";
            if (s == Symbol.O) return "/baevreasp.png";
            return "/aa.png";
        }

        public static void MakeMove(int i, int j)
        {
            nextPlayerMove = new Placement(i, j);
            hasClicked = true;
        }

        public static void StartNewGame()
        {
            if (!timerStarted)
            {
                game = new Game(a, b);
                timerStarted = true;
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Timer));
                thread.Start();
            }
        }

        public static void Timer()
        {
            while (!game.IsGameDone)
            {
                // TO DO : ADD COMMENTS
                if (game.CurrentPlayer == Symbol.X && a.GetType() == typeof(BeaverPlayer) || (game.CurrentPlayer == Symbol.O && b.GetType() == typeof(BeaverPlayer)))
                {
                    hasClicked = false;
                    while (!hasClicked)
                    {

                    }
                    hasClicked = false;
                    BeaverPlayer.nextMove = nextPlayerMove;
                    if (game.IsLegalMove(BeaverPlayer.nextMove))
                    {
                        game.NextMove();
                    }
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    game.NextMove();
                }
                pageUpdate.Invoke();
            }
            timerStarted = false;
        }
    }
}
