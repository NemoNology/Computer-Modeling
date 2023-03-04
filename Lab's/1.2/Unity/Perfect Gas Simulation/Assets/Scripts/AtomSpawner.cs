using UnityEngine;
using Random = UnityEngine.Random;

public class AtomSpawner : MonoBehaviour
{
    /// <summary>
    /// x - Width
    /// y - Height
    /// </summary>
    public Vector2 MinSize
    {
        get
        {
            var position = SpawnZone.position;
            var localScale = SpawnZone.localScale;
            MinSize.Set(position.x - localScale.x / 2,
                position.y - localScale.y / 2
                );
            
            return MinSize;
        }
    }
    public Vector2 MaxSize
    {
        get
        {
            var position = SpawnZone.position;
            var localScale = SpawnZone.localScale;
            MaxSize.Set(position.x + localScale.x / 2,
                position.y + localScale.y / 2
            );
            
            return MaxSize;
        }
    }
    public Transform SpawnZone { get; set; }
    public GameObject SpawnObject { get; set; }

    public void Spawn()
    {
        var tP = SpawnZone.position;
        tP.Set(
            Random.Range(MinSize.x, MaxSize.x),
            Random.Range(MinSize.y, MaxSize.y), 
            tP.z);
        
        Instantiate(SpawnObject, tP, Quaternion.identity);
    }

    private void Start()
    {
        // SimulationController.
    }
}
