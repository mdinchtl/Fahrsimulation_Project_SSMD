using UnityEngine;
using TMPro;
using System.Collections;

public class StreetInstructions : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textField;

    private Coroutine currentRoutine;

    private void OnTriggerEnter(Collider other)
    {
        if (!textField) return;

        string message = "";

        if (other.CompareTag("rechts"))
        {
            message = "Biegen Sie rechts ab.";
        }
        else if (other.CompareTag("links"))
        {
            message = "Biegen Sie links ab.";
        }
        else if (other.CompareTag("gerade"))
        {
            message = "Fahren Sie geradeaus.";
        }
        else if (other.CompareTag("linie"))
        {
            message = "Bleiben Sie in Ihrer Fahrspur!";
        }
        else if (other.CompareTag("Ground"))
        {
            message = "Fahren Sie auf der Straße!.";
        }
        // wenn nicht strasse dann soll warnung kommen das sie auf der strasse bleiben sollen
        else if (!other.CompareTag("Strasse"))
        {
            message = "Fahren Sie auf der Straße!.";
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