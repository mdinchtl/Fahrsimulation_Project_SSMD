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
}