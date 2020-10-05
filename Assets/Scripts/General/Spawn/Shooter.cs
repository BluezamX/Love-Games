using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletObject;

    [SerializeField]
    public int ammo;

    [SerializeField]
    private Vector3 relativeSpawn;

    [SerializeField]
    private VisualDisplay ammoDisplay;

    private void Start()
    {
        ammoDisplay.value = ammo.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0)
        {
            GameObject bullet = Instantiate(bulletObject);
            bullet.transform.position = new Vector3(transform.position.x + relativeSpawn.x, transform.position.y + relativeSpawn.y, transform.position.z + relativeSpawn.z);
            ammo--;
            ammoDisplay.value = ammo.ToString();
        }
    }
}
