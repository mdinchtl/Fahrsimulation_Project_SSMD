using UnityEngine;
using TMPro;
using System.Collections;

public class StreetInstructions : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textField;

    public ScoreSystem scoreSystem;

    private Coroutine currentRoutine;

    private void OnTriggerEnter(Collider other)
    {
        if (!textField) return;

        string message = "";

        if (other.CompareTag("rechts"))
        {
            message = "Biegen Sie rechts ab.";
        }
        if (other.CompareTag("links"))
        {
            message = "Biegen Sie links ab.";
        }
        if (other.CompareTag("gerade"))
        {
            message = "Fahren Sie geradeaus.";
        }
        if (other.CompareTag("linie"))
        {
            message = "Bleiben Sie in Ihrer Fahrspur!";
            scoreSystem.score += 2;
        }

        if (!string.IsNullOrEmpty(message))
        {
            if (currentRoutine != null)
            {
                StopCoroutine(currentRoutine);
            }

            currentRoutine = StartCoroutine(ShowTextForSeconds(message, 3f));
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            {
            if (currentRoutine != null)
            {
                StopCoroutine(currentRoutine);
            }

            currentRoutine = StartCoroutine(ShowTextForSeconds("", 3f));
            
        }
    }

    private IEnumerator ShowTextForSeconds(string text, float duration)
    {
        textField.text = text;
        yield return new WaitForSeconds(duration);
        textField.text = "";
        currentRoutine = null;
    }

    void Start()
    {
        // bei start soll kurz fahren sie los angezeigt werden
        if (textField)
        {
            StartCoroutine(ShowTextForSeconds("Fahren Sie los.", 3f));
        }
    }
}