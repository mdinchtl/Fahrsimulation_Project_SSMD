using UnityEngine;

public class Quit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
