using UnityEngine;

[CreateAssetMenu]
public class Stats : ScriptableObject
{
    [Header("HP/Energy")]
    public int hp = 100;
    public int maxhp = 100;

    public int energy = 2;
    public int maxEnergy = 2;

    [Header("Combat")]
    public int attack = 1;
    public int defense = 1;

    [Header("Movement")]
    public int speed = 4;
}

