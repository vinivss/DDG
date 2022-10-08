using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Suitor", menuName = "DogDatingSim/Suitor Dictionary", order = 0)]
public class DictionarySuitors : ScriptableObject
{
    public List<ScriptableObject> Dictionary = new List<ScriptableObject>();
}
