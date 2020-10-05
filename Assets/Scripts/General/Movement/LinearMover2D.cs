using UnityEngine;

public class LinearMover2D : MonoBehaviour
{
    [SerializeField]
    private new Rigidbody2D rigidbody2D;

    [SerializeField]
    private Vector2 direction;

    [SerializeField]
    private float speed;

    /// <summary>
    /// Constantly moves in a given direction. Used by bullets, e.g..
    /// </summary>
    void Update()
    {
        rigidbody2D.velocity = direction * speed * Time.deltaTime;
    }
}
