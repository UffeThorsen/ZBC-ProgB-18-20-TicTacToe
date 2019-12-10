using TicTacToe;

public class TestUIPlayer : IPlayer
{
    ButtonControlTest but;

    public TestUIPlayer(ButtonControlTest b)
    {
        but = b;
    }

    public Placement NextMove(Game gameState)
    {
        return but.LastValidButtonPress();
    }
}

