using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Atom : MonoBehaviour
{
    public int Size { get; set; }
    public int Speed { get; set; }
    public Vector2 Direction { get; set; }

    public Atom(int speed, Vector2 direction, int size)
    {
        Speed = speed;
        Direction = direction;
        Size = size;
    }
    
    private void FixedUpdate()
    {
        transform.Translate(Direction.x * Speed, Direction.y * Speed, 0);
    }
}
