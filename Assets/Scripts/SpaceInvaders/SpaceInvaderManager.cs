using System;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaderManager : LevelManager
{
    #region Singleton
    public static SpaceInvaderManager instance;

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
    private GameObject profGame;

    [SerializeField]
    private List<GameObject> enemyPrefabs;

    [SerializeField]
    private EnemySpawner spawner;

    private int enemyAmount;

    // TODO: Work out the formulas for spawning enemies.
    public override void Start()
    {
        base.Start();
        lost = true;
        Debug.Log("SpaceInvaderManager present");

        float difficulty = DifficultyManager.instance.difficulty;
        int enemyAmount = EnemyFormula(difficulty);
        int bullets = BulletFormula(difficulty, enemyAmount);

        this.enemyAmount = enemyAmount;
        profGame.GetComponent<Shooter>().ammo = bullets;
        spawner.Spawn(enemyPrefabs[UnityEngine.Random.Range(0, enemyPrefabs.Count)], enemyAmount);
    }

    private int EnemyFormula(float difficulty)
    {
        return UnityEngine.Random.Range(1, 4); // (int) Math.Ceiling(1 / difficulty * UnityEngine.Random.Range(1, difficulty));
    }

    private int BulletFormula(float difficulty, int enemyAmount)
    {
        return enemyAmount + 1; // (int) Math.Floor(enemyAmount + (2 / difficulty));
    }

    public void EnemyKilled()
    {
        enemyAmount--;
        if (enemyAmount <= 0)
        {
            lost = false;
        }
    }
}
