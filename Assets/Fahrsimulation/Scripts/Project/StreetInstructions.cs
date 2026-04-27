using UnityEngine;
using TMPro;

public class StreetInstructions : MonoBehaviour
{
    public TextMeshProUGUI textField;

    private void OnTriggerEnter(Collider other)
    {
        if (textField == null)
        {
            Debug.LogError("TextField nicht gesetzt!");
            return;
        }

        if (other.CompareTag("rechts"))
        {
            textField.text = "Biegen Sie rechts ab.";
        }
        else if (other.CompareTag("links"))
        {
            textField.text = "Biegen Sie links ab.";
        }
    }
}