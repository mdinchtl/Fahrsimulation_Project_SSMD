using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;     
    public TextMeshProUGUI displayScore;

    void Update()
    {
        displayScore.text = "Score: " + score.ToString();
    }
}
