using UnityEngine;

public class InputMover2D : Mover
{
    [SerializeField]
    private int stepDistance;

    [SerializeField]
    private int totalMoves;

    [SerializeField]
    private Animator animator;

    /// <summary>
    /// Moves a set distance each step. Used by TargetMover.
    /// </summary>
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (totalMoves <= 0 || dead)
            return;

        if (input.y > 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + stepDistance);
        }
        else if (input.x < 0)
        {
            transform.position = new Vector2(transform.position.x - stepDistance, transform.position.y);
        }
        else if (input.x > 0)
        {
            transform.position = new Vector2(transform.position.x + stepDistance, transform.position.y);
        }
        else if (input.y < 0)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - stepDistance);
        }
        else
        {
            return;
        }

        animator.SetBool("moving", true);
        animator.SetFloat("horizontal", input.x);
        animator.SetFloat("vertical", input.y);
        totalMoves--;
    }
}
