using System.Threading;
using UnityEngine;

public class SimulationController : MonoBehaviour
{
    // Thread 
    
    public float TimeMultiplier { get; set; }
    public int AtomsAmount { get; set; }
    public int AtomsSize { get; set; }
    public string Status { get; }

    public delegate void SomeAction();
    public event SomeAction LetsMove;
    public event SomeAction Spawn;


    public void SpawnAtoms()
    {
        
    }
    
    private void Update()
    {
        
    }
}
