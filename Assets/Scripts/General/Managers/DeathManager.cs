using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Mover mover;

    public void Kill()
    {
        animator.SetBool("dead", true);
        mover.dead = true;
    }
}
