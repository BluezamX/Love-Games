using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    #region Singleton
    public static DifficultyManager instance;

    private void Awake()
    {
        DontDestroyOnLoad(this);

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

    public float difficulty { get; private set; }

    // TODO: Add difficulty to determine the amount of spawned enemies and game speed.
    private void Start()
    {
        difficulty = 1;
    }

    public void Increase()
    {
        difficulty = 1;
    }
}
