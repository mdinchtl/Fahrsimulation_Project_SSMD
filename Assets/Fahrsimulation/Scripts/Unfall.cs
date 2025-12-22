using Unity.Jobs;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unfall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MyCar"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
