using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    #region Singleton
    public static TimeManager instance;

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
    private float timer;

    private bool triggered = true;

    private UnityEvent timerEvent;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && !triggered)
        {
            timerEvent.Invoke();
            triggered = true;
        }
    }

    public void SetTimer(float t, UnityEvent e)
    {
        timer = t;
        timerEvent = e;
        triggered = false;
    }
}
