using UnityEngine;
using UnityEngine.UI;

public class VisualDisplay : MonoBehaviour
{
    [SerializeField]
    private Text text;

    [SerializeField]
    public string value;

    void Update()
    {
        text.text = value;
    }
}
