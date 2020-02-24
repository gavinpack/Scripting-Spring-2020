using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextBehavior : MonoBehaviour
{
    private Text textObj;
    public IntData dataObj;
    void Start()
    {
        textObj = GetComponent<Text>();
    }
    
    void Update()
    {
        textObj.text = dataObj.value.ToString();
    }
}
