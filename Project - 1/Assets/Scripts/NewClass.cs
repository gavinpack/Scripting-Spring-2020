using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    // Start is called before the first frame update

    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    
    private void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum);
        print(gameObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
