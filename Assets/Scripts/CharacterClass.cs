using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Characters")]
public class CharacterClass : ScriptableObject
{
    [field: SerializeField]
    public float speed { get; private set; }

    [field: SerializeField]

    public GameObject bullet { get; private set; }
}
