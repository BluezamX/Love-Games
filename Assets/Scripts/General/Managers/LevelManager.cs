using UnityEngine.Events;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private float timer = 3;

    public bool lost = true;

    public virtual void Start()
    {
        Debug.Log("LevelManager present");
        UnityEvent e = new UnityEvent();
        e.AddListener(() => Finish());
        TimeManager.instance.SetTimer(timer, e);
    }

    #region Finish
    // TODO: BombermanManager currently doesn't work with this
    /// <summary>
    /// Event added to every timer.
    /// </summary>
    public void Finish()
    {
        if (lost)
            Lose();
        else
            Win();
    }

    public void Lose()
    {
        Debug.Log("You lose!");
        SceneManager.instance.LoadScene(SceneManager.Scene.MainMenu);
    }

    public void Win()
    {
        Debug.Log("You win!");
        SceneManager.instance.LoadScene(SceneManager.Scene.MainMenu);
        DifficultyManager.instance.Increase();
    }
    #endregion
}
