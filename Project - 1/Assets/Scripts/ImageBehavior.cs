using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehavior : MonoBehaviour
{
    private Image imageObj;
    void Start()
    {
        imageObj = GetComponent<Image>();
    }
    
    void Update()
    {
        
    }
}
