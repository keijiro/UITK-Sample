using UnityEngine;

[CreateAssetMenu]
public sealed class CharacterProfile : ScriptableObject
{
    public string displayName;
    public int life;
    public int strength;
    public Texture2D portrait;
}
