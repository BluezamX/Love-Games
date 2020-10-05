using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDestroy : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnPrefab;

    private void OnDestroy()
    {
        GameObject spawn = Instantiate(spawnPrefab);
        spawn.transform.position = transform.position;
    }
}
