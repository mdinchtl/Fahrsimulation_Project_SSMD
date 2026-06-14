using UnityEngine;
using TMPro;
using System.Collections;

public class OnTrack : MonoBehaviour
{
    public TextMeshProUGUI Text;

    private Coroutine clearRoutine;
    private bool isOffRoad = false;
    public ScoreSystem scoreSystem;

    void Update()
    {
        bool onRoad = Physics.Raycast(transform.position, Vector3.down, 2f);

        if (!onRoad && !isOffRoad)
        {
            isOffRoad = true;
            ShowMessage();
        }
        else if (onRoad && isOffRoad)
        {
            isOffRoad = false;
        }
    }

    void ShowMessage()
    {
        Text.text = "Du bist von der Fahrbahn abgekommen";
        scoreSystem.score += 4;

        if (clearRoutine != null)
            StopCoroutine(clearRoutine);

        clearRoutine = StartCoroutine(ClearAfterTime());
    }

    IEnumerator ClearAfterTime()
    {
        yield return new WaitForSeconds(3f);
        Text.text = "";
    }
}