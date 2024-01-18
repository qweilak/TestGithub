using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    SpriteRenderer _sp;
    void Start()
    {
        _sp.GetComponent<SpriteRenderer>();
        _sp.color = Color.white;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _sp.color = Color.white;
        else if (Input.GetKeyDown(KeyCode.Alpha0))
                _sp.color = Color.red;
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            _sp.color = Color.green;
    }
}
