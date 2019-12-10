using TicTacToe;


public class UiIplayer : IPlayer
{

    GameManagement button;

    public UiIplayer(GameManagement b)
    {
        button = b;
    }

    public Placement NextMove(Game gameState)
    {
        return button.LastValidButtonPress();   
    }

}
