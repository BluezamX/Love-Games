using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    new private BoxCollider2D collider;

    public void Die()
    {
        animator.SetBool("dead", true);
        collider.enabled = false;
        SpaceInvaderManager.instance.EnemyKilled();
    }
}
