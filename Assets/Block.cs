using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var position = gameObject.transform.localPosition;
        position.x += 0.001f;
        gameObject.transform.localPosition = position;
    }
}
