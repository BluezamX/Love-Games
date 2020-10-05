using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    #region Singleton
    public static MainMenuManager instance;

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

    public void LoadScene(string scene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
    }
}
