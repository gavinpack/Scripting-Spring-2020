using UnityEngine;

public class InstancingBehaviour : MonoBehaviour
{
    public GameObject prefab;

    public void InstanceAtTransform()
    {
        Instantiate(prefab, transform);
    }
}
