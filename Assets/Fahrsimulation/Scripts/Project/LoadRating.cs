using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadRating : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            Debug.Log("Goal reached!");
            StartCoroutine(LoadGameWithDelay(1.5f));
        }
    }
    private IEnumerator LoadGameWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Rating");
    }
}
