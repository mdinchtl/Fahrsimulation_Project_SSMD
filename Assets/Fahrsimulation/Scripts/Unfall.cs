using Unity.Jobs;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Unfall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MyCar"))
        {
            StartCoroutine(LoadGameWithDelay(2f));
        }
    }
    private IEnumerator LoadGameWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("GameOver");
    }
}
