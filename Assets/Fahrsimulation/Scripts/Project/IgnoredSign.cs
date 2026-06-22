using UnityEngine;

public class IgnoredSign : MonoBehaviour
{
    public ScoreManager scoreSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NoRightTurn"))
        {
            scoreSystem.score += 3;
            scoreSystem.typOfError.Add("turned into a prohibited street.");
        }

        if (other.CompareTag("Wrong"))
        {
            scoreSystem.score += 3;
            scoreSystem.typOfError.Add("Did not yield the right of way");
        }

        if (other.CompareTag("PassBy"))
        {
            scoreSystem.score += 3;
            scoreSystem.typOfError.Add("A car overtook in a no-overtaking zone.");
        }

        if (other.CompareTag("WrongPath"))
        {
            scoreSystem.score += 1;
            scoreSystem.typOfError.Add("Drove Wrong Path");
        }


    }
    
}
