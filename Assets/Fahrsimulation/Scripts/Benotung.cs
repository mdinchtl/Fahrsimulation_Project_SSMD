using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Benotung : MonoBehaviour
{
    public int punkte = 5;
    private bool gameEnded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (gameEnded) return;

        if (other.CompareTag("Falschestraße"))
        {
            punkte -= 1;
            Debug.Log("Falsch ");
        }

        if (other.CompareTag("Ziel") && punkte > 3)
        {
            gameEnded = true;
            Debug.Log("Success");
            StartCoroutine(Success(3f));
        }
    }

    void Update()
    {
        if (gameEnded) return;

        if (punkte < 2)
        {
            gameEnded = true;
            Debug.Log("Fail");
            StartCoroutine(Fail(3f));
        }
    }

    private IEnumerator Fail(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Fail");
    }

    private IEnumerator Success(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Success");
    }
}
