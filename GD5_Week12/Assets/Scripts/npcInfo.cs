using UnityEngine;

[CreateAssetMenu(menuName ="NPC Information", fileName ="New NPC Info")]
public class npcInfo : ScriptableObject
{
    public string npcName;
    public string catchphrase;
    public Sprite npcSprite;

    public int armourLevel;
    public float npcSpeed;

    public bool isFriendly;
}

public class potionInfo : ScriptableObject
{
    public Color potionColour;
    public string description;
    public int healthModifier;
}
