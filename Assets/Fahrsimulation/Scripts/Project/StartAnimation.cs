using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public Animator car1Animator;
    public Animator car2Animator;
    public Animator car3Animator;
    public Animator car4Animator;
    public Animator car5Animator;
    public Animator car6Animator;
    public Animator car7Animator;
    public Animator car8Animator;
    public Animator car9Animator;
    public Animator car10Animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColliderCar1_3"))
        {
            if (car1Animator != null)
                car1Animator.SetTrigger("On");

            if (car3Animator != null)
                car3Animator.SetTrigger("On");
        }

        if (other.CompareTag("ColliderCar2_4"))
        {
            if (car2Animator != null)
                car2Animator.SetTrigger("On");

            if (car4Animator != null)
                car4Animator.SetTrigger("On");
        }

        if (other.CompareTag("ColliderCar5"))
        {
            if (car5Animator != null)
                car5Animator.SetTrigger("On");
        }

        if (other.CompareTag("ColliderCar6"))
        {
            if (car6Animator != null)
                car6Animator.SetTrigger("On");
        }

        if (other.CompareTag("ColliderCar7_9"))
        {
            if (car7Animator != null)
                car7Animator.SetTrigger("On");

            if (car9Animator != null)
                car9Animator.SetTrigger("On");
        }

        if (other.CompareTag("ColliderCar8"))
        {
            if (car8Animator != null)
                car8Animator.SetTrigger("On");
        }

        if (other.CompareTag("ColliderCar9"))
        {
            if (car9Animator != null)
                car9Animator.SetTrigger("On");
        }

        if (other.CompareTag("ColliderCar10"))
        {
            if (car10Animator != null)
                car10Animator.SetTrigger("On");
        }
    }
}