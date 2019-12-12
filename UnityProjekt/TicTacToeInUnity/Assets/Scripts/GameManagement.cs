using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TicTacToe;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    Game currentGame;
    IPlayer playerOne;
    IPlayer playerTwo;
    Text[,] playingFieldText = new Text[3, 3];
    Placement lastPlacePressed;
    bool userHasPressed = false;
    bool someoneHasWon = false;
    bool xIsAI = false;
    public Text currentPlayerText;
    public GameObject playingBoard;
    public Dropdown playerOneDropdown;
    public Dropdown playerTwoDropdown;
    public GameObject playingScreen;
    public GameObject choosingScreen;
    public List<Dropdown.OptionData> IPlayerList;

    void Start()
    {
        playerOneDropdown.ClearOptions();
        playerTwoDropdown.ClearOptions();
        playerOneDropdown.AddOptions(IPlayerList);
        playerTwoDropdown.AddOptions(IPlayerList);

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
        if (currentGame != null && !someoneHasWon)
        {
            currentPlayerText.text = "Current player: " + currentGame.CurrentPlayer.ToString();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(currentGame[i,j] == Symbol.N)
                    {
                        playingFieldText[i, j].text = "";
                    }
                    else
                    {
                        playingFieldText[i, j].text = currentGame[i, j].ToString();
                    }
                }
            }
        }
        if (currentGame != null)
        {
            if (currentGame.IsGameDone)
            {
                someoneHasWon = true;
                if (currentGame.WhoWon() == null)
                {
                    currentPlayerText.text = "The game was a tie";
                }
                else
                {
                    IPlayer winningPlayer = currentGame.WhoWon();
                    if (winningPlayer == playerOne)
                    {
                        currentPlayerText.text = "X has won the game";
                    }
                    else
                    {
                        currentPlayerText.text = "O has won the game";
                    }
                }
            }
        }
    }

    public void StartGame()
    {
        currentGame = MakeNewGame();
        choosingScreen.SetActive(false);
        playingScreen.SetActive(true);
        NextMove(xIsAI);
    }

    public void RestartGame()
    {
        userHasPressed = false;
        someoneHasWon = false;
        currentGame = MakeNewGame();
        NextMove(xIsAI);
    }
    
    Game MakeNewGame()
    {
        if (playerOneDropdown.value == 0)
        {
            playerOne = new UiIplayer(this);
        }
        else
        {
            playerOne = new UffeAIPlayer();
            xIsAI = true;
        }
        if (playerTwoDropdown.value == 0)
        {
            playerTwo = new UiIplayer(this);
        }
        else
        {
            playerTwo = new UffeAIPlayer();
        }
        return new Game(playerOne, playerTwo);
    }
    


    public Placement LastValidButtonPress()
    {
        userHasPressed = false;
        new WaitWhile(() => !userHasPressed);
        return lastPlacePressed;
    }

    public void BoardPressed(Button b)
    {
        Placement p = new Placement(int.Parse(b.tag[0].ToString()), int.Parse(b.tag[1].ToString()));
        if (currentGame.IsLegalMove(p))
        {
            lastPlacePressed = p;
            userHasPressed = true;
            StartCoroutine(AutoNextMove());
        }
    }

    void NextMove(bool isAi = false)
    {
        if (userHasPressed || isAi)
        {
            if (!currentGame.IsGameDone)
            {
                currentGame.NextMove();
                if (currentGame.CurrentPlayer == Symbol.X && playerOneDropdown.value == 1)
                {
                    NextMove(true);
                }
                else if (currentGame.CurrentPlayer == Symbol.O && playerTwoDropdown.value == 1)
                {
                    NextMove(true);
                }
            }
        }
    }

    IEnumerator AutoNextMove()
    {
        new WaitForSeconds(0.5f);
        NextMove();
        yield return new WaitForSeconds(0.5f);
    }
}
