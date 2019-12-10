using System;
using System.Collections;
using System.Collections.Generic;
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

        public static string a = "Human";
        public static string b = "Human";
        public static Game game;
        public static Placement nextPlayerMove;
        public static Action pageUpdate = null;
        public static Dictionary<string, IPlayer> PlayerA = makePlayerDictionary();
        public static Dictionary<string, IPlayer> PlayerB = makePlayerDictionary();

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
                game = new Game(PlayerA[a], PlayerB[b]);
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
                if (game.CurrentPlayer == Symbol.X && PlayerA[a].GetType() == typeof(BeaverPlayer) || (game.CurrentPlayer == Symbol.O && PlayerB[b].GetType() == typeof(BeaverPlayer)))
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

        public static Dictionary<string, IPlayer> makePlayerDictionary()
        {
            Dictionary<string, IPlayer> aIs = new Dictionary<string, IPlayer>();
            aIs.Add("Human", new BeaverPlayer());
            aIs.Add("AntonAI", new AntonAI());
            aIs.Add("BirksVeryBadAI", new BirksVeryBadAI());
            aIs.Add("DanielsEpicAI", new DanielsEpicAI());
            aIs.Add("DanielsEpicerAI", new DanielsEpicerAI());
            aIs.Add("JacobIAI", new JacobIAI());
            aIs.Add("JacobAAI", new JacobAAI());
            //aIs.Add("JannieAIPlayer", new JannieAIPlayer());
            //aIs.Add("KarlGustavAI", new KarlGustavAI());
            aIs.Add("KasperAI", new KasperAI());
            aIs.Add("MFBadAI", new MFBadAI());
            aIs.Add("PoppeAi", new PoppeAi());
            aIs.Add("RasmusAI", new RasmusAI());
            aIs.Add("StigAI", new StigAI());
            aIs.Add("ThomasAIPlayer", new ThomasAIPlayer());
            aIs.Add("UffeAIPlayer", new UffeAIPlayer());
            aIs.Add("UffeSmarterAIPlayer", new UffeSmarterAIPlayer());

            return aIs;
        }
    }
}
