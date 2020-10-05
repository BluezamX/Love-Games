using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float minX;

    [SerializeField]
    private float maxX;

    [SerializeField]
    private float minY;

    [SerializeField]
    private float maxY;

    [SerializeField]
    private float minZ;

    [SerializeField]
    private float maxZ;

    public void Spawn(GameObject prefab, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject spawn = Instantiate(prefab);
            spawn.transform.position = new Vector3(
                Random.Range(minX, maxX),
                Random.Range(minY -i, maxY -i),
                Random.Range(minZ, maxZ));
        }
    }
}
