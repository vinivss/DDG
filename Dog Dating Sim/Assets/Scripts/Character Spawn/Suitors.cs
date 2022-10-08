using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Suitor", menuName = "DogDatingSim/Add A New Suitor", order = 0)]
public class Suitors : ScriptableObject
{
    public int ID;
    public string Name;
    public bool Dog;
    public GameObject Model;

    
}
