using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class HoldCoroutine : MonoBehaviour
{
    private float holdTime = 2f;
    private WaitForSeconds waitObj;
    public UnityEvent holdEvent;

    private void Start()
    {
        waitObj = new WaitForSeconds(holdTime);
    }

    public void RunCoroutine()
    {
        StartCoroutine(Run());
    }

    private IEnumerator Run()
    {
        yield return waitObj;
        holdEvent.Invoke();
    }
}
