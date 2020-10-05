using UnityEngine;

public class GridMover2D : Mover
{
    [SerializeField]
    private int stepDistance;

    [SerializeField]
    private int totalMoves;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private TargetMover mover;

    public float h;
    public float v;

    // TODO: Look into converting all mover scripts into a single file to reduce code duplication.
    /// <summary>
    /// Used for Top-down games.
    /// </summary>
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (totalMoves <= 0 || dead)
            return;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mover.goals.Add(new Vector3(mover.goals[mover.goals.Count - 1].x, mover.goals[mover.goals.Count - 1].y + stepDistance, mover.goals[mover.goals.Count - 1].z));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mover.goals.Add(new Vector3(mover.goals[mover.goals.Count - 1].x - stepDistance, mover.goals[mover.goals.Count - 1].y, mover.goals[mover.goals.Count - 1].z));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            mover.goals.Add(new Vector3(mover.goals[mover.goals.Count - 1].x + stepDistance, mover.goals[mover.goals.Count - 1].y, mover.goals[mover.goals.Count - 1].z));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            mover.goals.Add(new Vector3(mover.goals[mover.goals.Count - 1].x, mover.goals[mover.goals.Count - 1].y - stepDistance, mover.goals[mover.goals.Count - 1].z));
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
