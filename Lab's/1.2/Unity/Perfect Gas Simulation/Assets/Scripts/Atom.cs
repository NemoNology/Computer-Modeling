using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Atom : MonoBehaviour
{
    public Vector2 Coordinates { get; set; }
    public Vector2 Movement { get; set; }

    public Atom(Vector2 coordinates, Vector2 movement)
    {
        Coordinates = coordinates;
        Movement = movement;
    }
    public void Move()
    {
        Coordinates.Set(Coordinates.x + Movement.x,
            Coordinates.y + Movement.y);
    }
}
