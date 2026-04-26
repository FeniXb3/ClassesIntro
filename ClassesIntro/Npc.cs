namespace ClassesIntro;

public class Npc : Character
{
    private List<Vector2> _availableDirections = [
        new Vector2(-1, 0),
        new Vector2(1, 0),
        new Vector2(0, -1),
        new Vector2(0, 1)
    ];
    
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
    }

    public override void ChooseAction()
    {
        int directionIndex = Random.Shared.Next(_availableDirections.Count);
        Vector2 direction = _availableDirections[directionIndex];
        ClearAtPosition();
        Move(direction);
    }
}