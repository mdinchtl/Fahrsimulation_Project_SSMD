using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    public void Close()
    {
        Application.Quit();
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("City");
    }
}

