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

    public Collider ColliderCar1;
    public Collider ColliderCar2;
    public Collider ColliderCar3;
    public Collider ColliderCar4;
    public Collider ColliderCar5;
    public Collider ColliderCar6;
    public Collider ColliderCar7;
    public Collider ColliderCar8;
    public Collider ColliderCar9;

    void Start()
    {
       
        car1Animator.SetTrigger("On");
        car2Animator.SetTrigger("On");
        car3Animator.SetTrigger("On");
        car4Animator.SetTrigger("On");
        car5Animator.SetTrigger("On");
        car6Animator.SetTrigger("On");
        car7Animator.SetTrigger("On");
        car8Animator.SetTrigger("On");
        car9Animator.SetTrigger("On");
    }
}
