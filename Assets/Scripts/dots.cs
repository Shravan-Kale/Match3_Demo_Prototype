using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dots : MonoBehaviour
{
    public Vector3 FirstDot;
    public Vector3 SecondDot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void OnMouseDown()
    {
        FirstDot = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(FirstDot);
    }

    void OnMouseUp()
    {
        FirstDot = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(FirstDot);
    }
}
