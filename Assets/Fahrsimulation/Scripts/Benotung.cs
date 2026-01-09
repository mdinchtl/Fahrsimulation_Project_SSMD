using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Benotung : MonoBehaviour
{
    public int punkte = 5;
    private bool gameEnded = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (gameEnded) return;

        if (collision.gameObject.CompareTag("Falschestraße"))
        {
            punkte -= 1;
        }

        if (collision.gameObject.CompareTag("Ziel") && punkte > 3)
        {
            gameEnded = true;
            StartCoroutine(Success(3f));
        }
    }

    void Update()
    {
        if (gameEnded) return;

        if (punkte < 2)
        {
            gameEnded = true;
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
