using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TicTacToe;

public class ButtonControlTest : MonoBehaviour
{
    public Game currentGame;
    public IPlayer player1;
    public IPlayer player2;
    public Text currentPLayerText;
    public Text[,] playingFieldText = new Text[3,3];
    public GameObject playingBoard;
    public int x;
    public int y;

    void Start()
    {
        int k = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                playingFieldText[i, j] = playingBoard.transform.GetChild(k).GetChild(0).GetComponent<Text>();
                k++;
            }
        }
    }

    void Update()
    {
        if (currentGame != null)
        {
            currentPLayerText.text = "Current player: " + currentGame.CurrentPlayer.ToString();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    playingFieldText[i,j].text = currentGame[i, j].ToString();
                }
            }
        }
    }

    public void StartGame()
    {
        player1 = new UffeAIPlayer();
        player2 = new UffeAIPlayer();
        currentGame = new Game(player1,player2);
    }
    /*
    public void PlaceTest()
    {
        currentGame[x,y] = currentGame.CurrentPlayer; 
    }*/
}
