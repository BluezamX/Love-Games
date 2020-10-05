using System.Collections.Generic;
using UnityEngine;

public class TargetMover: MonoBehaviour
{
    [SerializeField]
    private Vector3 start;

    public List<Vector3> goals;

    [SerializeField]
    private float speed;

    [SerializeField]
    private bool repeat;

    void Start()
    {
        transform.position = start;
        goals.Insert(0, start);
    }

    /// <summary>
    /// Moves a given step into a direction, similar to grid movement in RPG's.
    /// </summary>
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, goals[0], speed * Time.deltaTime);

        if (transform.position == goals[0] && goals.Count > 1)
        {
            start = goals[0];

            if (repeat)
                goals.Add(goals[0]);

            goals.RemoveAt(0);
        }
    }
}
