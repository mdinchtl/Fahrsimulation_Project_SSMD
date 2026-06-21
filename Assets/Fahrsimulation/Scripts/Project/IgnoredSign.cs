using UnityEngine;

public class IgnoredSign : MonoBehaviour
{
    public ScoreManager scoreSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wrong"))
        {
            scoreSystem.score += 3;
            scoreSystem.typOfError.Add("Ignored Sign");
        }

        if (other.CompareTag("WrongPath"))
        {
            scoreSystem.score += 1;
            scoreSystem.typOfError.Add("Drove Wrong Path");
        }
    }
    
}
