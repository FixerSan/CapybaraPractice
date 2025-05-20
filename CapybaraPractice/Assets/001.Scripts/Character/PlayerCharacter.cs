using UnityEngine;

public class PlayerCharacter : Character
{
    public PlayerData playerData;
}


[System.Serializable]
public class PlayerData
{
    public int hp;
    public int attackForce;
    public int defenceForce;
}
