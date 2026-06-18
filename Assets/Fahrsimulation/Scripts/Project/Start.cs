using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start : MonoBehaviour
{
    public void ProjectStart()
    {
        SceneManager.LoadScene("City");
    }
}

