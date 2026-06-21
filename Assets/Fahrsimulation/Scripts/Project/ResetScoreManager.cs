using UnityEngine;

public class ResetScoreManager : MonoBehaviour
{
    public ScoreManager scoreManager;

    void Awake()
    {
        scoreManager.score = 0;
        scoreManager.typOfError.Clear();
    }
}
