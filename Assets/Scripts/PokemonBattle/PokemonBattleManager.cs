using UnityEngine;
using static EnemyManager;

public class PokemonBattleManager : LevelManager
{
    #region Singleton
    public static PokemonBattleManager instance;

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

    #region Startup
    private Element enemy;

    public override void Start()
    {
        base.Start();
        Debug.Log("PokemonBattleManager present");
        enemy = EnemyManager.instance.Spawn();
        ButtonManager.instance.Create();
    }
    #endregion

    #region Game Loop
    public void Attack(Element attack)
    {
        if ((int) attack == 3)
        {
            Lose();
        }
        else if ((int) attack == 2 && enemy == 0)
        {
            Win();
        }
        else if ((int) attack == (int) enemy - 1)
        {
            Win();
        }
        else
        {
            Lose();
        }
    }
    #endregion
}
