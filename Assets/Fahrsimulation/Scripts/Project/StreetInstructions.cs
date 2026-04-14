using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class StreetInstructions : MonoBehaviour
{

    public string[] instruction;
    public TextMeshProUGUI textField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        instruction = new string[5];
        instruction[0] = "Fahren Sie geradeaus weiter.";
        instruction[1] = "Biegen Sie rechts ab.";
        instruction[2] = "Biegen Sie links ab.";
        instruction[3] = "Folgen Sie dem Straßenverlauf der Vorrangstraße.";
        instruction[4] = "Halten Sie vor dem Park an.";
    }

    void Start()
    {
        textField.text = instruction[0];
    }

    // Update is called once per frame
    void Update()
    { 

        
    }
}
