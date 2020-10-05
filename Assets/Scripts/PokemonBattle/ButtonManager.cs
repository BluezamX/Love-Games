using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static EnemyManager;

public class ButtonManager : MonoBehaviour
{
    #region Singleton
    public static ButtonManager instance;

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
    private GameObject buttonPrefab;

    [SerializeField]
    private List<Sprite> elementSprites = new List<Sprite>();

    [SerializeField]
    private List<Button> buttons = new List<Button>();

    // TODO: Find a way to clean this up! There must be a way to simplify this without ending up with more lines of code, as per below...
    /// <summary>
    /// Instantiate and position the buttons.
    /// </summary>
    public void Create()
    {
        buttons[0].image.sprite = elementSprites[0];
        buttons[0].onClick.AddListener(() => OnClick(0));
        buttons[1].image.sprite = elementSprites[1];
        buttons[1].onClick.AddListener(() => OnClick(1));
        buttons[2].image.sprite = elementSprites[2];
        buttons[2].onClick.AddListener(() => OnClick(2));
        buttons[3].image.sprite = elementSprites[3];
        buttons[3].onClick.AddListener(() => OnClick(3));

        /*
        numbers = numbers.OrderBy(x => Guid.NewGuid()).ToList();

        for (int i = 0; i < 4; i++)
        {
            GameObject buttonObject = Instantiate(buttonPrefab);
            buttonObject.transform.SetParent(parentPanel.transform);
            Button button = buttonObject.GetComponent<Button>();
            button.onClick.AddListener(() => OnClick(numbers[GetNumber()]));

            RectTransform rect = button.GetComponent<RectTransform>();
            rect.anchoredPosition = new Vector2(600 - i * 400, 0);
            buttonObject.transform.localScale = new Vector3(1, 1, 1);
            button.image.sprite = elementSprites[numbers[i]];
            counter++;
        }
        */
    }

    private void OnClick(int i)
    {
        PokemonBattleManager.instance.Attack((Element) i);
    }
}

public class ElementNumber
{
    public Sprite sprite;
    public int number;
}
