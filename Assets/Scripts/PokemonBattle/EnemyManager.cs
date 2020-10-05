using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    #region Singleton
    public static EnemyManager instance;

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
    private List<Sprite> sprites = new List<Sprite>();

    [SerializeField]
    private GameObject enemy;

    public Element Spawn()
    {
        int rng = Random.Range(0, sprites.Count);
        enemy.GetComponent<SpriteRenderer>().sprite = sprites[rng];
        return (Element) rng;
    }

    public enum Element
    {
        Water, Fire, Grass, Normal
    }
}
