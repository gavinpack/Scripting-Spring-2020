using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera cameraObj;
    private void Start()
    {
        cameraObj = GetComponent<Camera>();
        cameraObj.depth = 1f;
    }
    
    void Update()
    {
        
    }
}
