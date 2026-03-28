using UnityEngine;

[CreateAssetMenu(
    fileName = "PlayerSettings", 
    menuName = "Player/Player Settings")]
public class PlayerSettings : ScriptableObject
{
    [Header("Player Settings")]
    public float Speed;

}
