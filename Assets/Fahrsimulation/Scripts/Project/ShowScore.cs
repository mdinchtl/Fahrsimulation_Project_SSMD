using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI errorList;
    public Image passed;
    public Image failed;
    public ScoreManager scoreSystem;

    private void Update()
    {
        score.text = "Score: " + scoreSystem.score;
        
        for (int i = 0; i < scoreSystem.typOfError.Count; i++)
        {
            errorList.text = "Errors: " + string.Join(" \n ", scoreSystem.typOfError);
        }

        if (scoreSystem.score <= 15)
        {
            passed.gameObject.SetActive(true);

        }
        else
        {
            failed.gameObject.SetActive(true);
        }
    }
}
