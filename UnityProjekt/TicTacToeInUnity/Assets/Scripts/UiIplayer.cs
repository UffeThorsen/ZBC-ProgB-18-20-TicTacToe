using TicTacToe;


public class UiIplayer : IPlayer
{
    GameManagement manager;

    public UiIplayer(GameManagement m)
    {
        manager = m;
    }

    public Placement NextMove(Game gameState)
    {
        return manager.LastValidButtonPress();   
    }
}
