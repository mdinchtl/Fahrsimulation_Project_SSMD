using UnityEngine;

public class IgnoredSign : MonoBehaviour
{
    public ScoreSystem scoreSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wrong"))
        {
            scoreSystem.score += 3;
        }

        if (other.CompareTag("WrongPath"))
        {
            scoreSystem.score += 1;
        }
    }
    
}
