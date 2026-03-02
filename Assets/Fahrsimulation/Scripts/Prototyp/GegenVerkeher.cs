using UnityEngine;

public class GegenVerkeher : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string trigger;

    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VorrangZone"))
        {
            triggered = true;
            animator.SetTrigger(trigger);

        }
    }
}
