using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Characters")]
public class CharacterClass : ScriptableObject
{
    [field: SerializeField]
    public float Speed { get; private set; }

    [field: SerializeField]
    public BulletClass Bullet { get; private set; }

    [field: SerializeField]
    public float FireRate { get; private set; }
}
