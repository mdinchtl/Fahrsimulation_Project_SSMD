using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "Scriptable Objects/ScoreManager")]
public class ScoreManager : ScriptableObject
{
    public int score = 0;
    public List<string> typOfError = new List<string>();
}
