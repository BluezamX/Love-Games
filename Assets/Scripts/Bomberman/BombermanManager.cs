using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombermanManager : LevelManager
{
    #region Singleton
    public static BombermanManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion

    [SerializeField]
    private GameObject bombPrefab;

    [SerializeField]
    private List<Vector2> spawnPositions;

    public override void Start()
    {
        base.Start();
        Spawn();
    }

    /// <summary>
    /// Spawns 3 bombs at different random locations.
    /// </summary>
    private void Spawn()
    {
        List<Vector2> spawns = spawnPositions;
        for (int i = 0; i < 3; i++)
        {
            int positionNo = Random.Range(0, spawns.Count);
            GameObject bomb = Instantiate(bombPrefab);
            bomb.transform.position = spawns[positionNo];
            spawns.RemoveAt(positionNo);
        }
    }
}
