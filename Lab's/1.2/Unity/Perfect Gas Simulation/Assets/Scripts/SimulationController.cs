using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Audio;
using UnityEngine.UI;

public class SimulationController : MonoBehaviour
{
    public float TimeMultiplier { get; set; }
    public int AtomsAmount { get; set; }
    public int AtomsSize { get; set; }
    public string Status { get; }

    public delegate void Move();
    public event Move LetsMove;
    
    
    private void Update()
    {
        
    }
}
