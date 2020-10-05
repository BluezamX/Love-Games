using UnityEngine;

public class KillOnTouch2D : MonoBehaviour
{
    [SerializeField]
    private bool destroySelf;

    /// <summary>
    /// Destroy an enemy or player on touch. TODO: Possibly split into two to allow unique cases if needed? Maybe work with Serialized variables.
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<DeathManager>().Kill();
            if (destroySelf)
                Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().Die();
            if (destroySelf)
                Destroy(gameObject);
        }
    }
}
