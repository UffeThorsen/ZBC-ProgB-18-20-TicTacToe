﻿using TicTacToe;


public class UiIplayer : IPlayer
{

    ButtonControlTest but;

    public UiIplayer(ButtonControlTest b)
    {
        but = b;
    }

    public Placement NextMove(Game gameState)
    {
        return but.LastValidButtonPress();   
    }

}