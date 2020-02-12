using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightController : MonoBehaviour
{
   private Light lightObj;

   private void Start()
   {
      lightObj = GetComponent<Light>();
      lightObj.intensity = 0f;
   }
}
