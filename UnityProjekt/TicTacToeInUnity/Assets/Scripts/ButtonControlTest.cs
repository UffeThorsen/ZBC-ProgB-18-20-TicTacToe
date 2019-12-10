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
    public Text currentPlayerText;
    public Text[,] playingFieldText = new Text[3,3];
    public Transform[,] playingFieldButtons = new Transform[3,3];
    public GameObject playingBoard;
    public Placement lastPlacePressed;
    public bool userHasPressed = false;
    bool someoneHasWon = false;

    void Start()
    {
        int k = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                playingFieldText[i, j] = playingBoard.transform.GetChild(k).GetChild(0).GetComponent<Text>();
                playingFieldButtons[i, j] = playingBoard.transform.GetChild(k);
                k++;
            }
        }
    }

    void Update()
    {
        if (currentGame != null && !someoneHasWon)
        {
            currentPlayerText.text = "Current player: " + currentGame.CurrentPlayer.ToString();
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
        /*player1 = new UffeAIPlayer();
        player2 = new UffeAIPlayer();*/
        player1 = new UiIplayer(this);
        player2 = new UiIplayer(this);
        currentGame = new Game(player1,player2);
        DoNextMove();
    }

    
    public Placement LastValidButtonPress()
    {
        userHasPressed = false;
        new WaitWhile(() => !userHasPressed);
        //StartCoroutine(AutoNextMove());
        return lastPlacePressed;
    }

    public void BoardPressed(Button b)
    {
        Placement p = new Placement(int.Parse(b.tag[0].ToString()), int.Parse(b.tag[1].ToString()));
        if (currentGame.IsLegalMove(p))
        {
            lastPlacePressed = p;
            userHasPressed = true;
        }
    }

    public void DoNextMove()
    {
        if (userHasPressed)
        {
            if (!currentGame.IsGameDone)
            {
                currentGame.NextMove();
            }
            else
            {
                someoneHasWon = true;
                if (currentGame.WhoWon() == null)
                {
                    currentPlayerText.text = "The game was a tie";
                }
                else
                {
                    currentPlayerText.text = "Winning player: " + currentGame.WhoWon();
                }
            }
        }
    }

    IEnumerator AutoNextMove()
    {
        new WaitForSeconds(0.5f);
        DoNextMove();
        yield return new WaitForSeconds(0.5f);
    }

    /*
    public int x;
    public int y;
    public void PlaceTest()
    {
        currentGame[x,y] = currentGame.CurrentPlayer; 
    }*/
}
