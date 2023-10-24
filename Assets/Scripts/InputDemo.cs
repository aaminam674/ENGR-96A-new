using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class InputDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue val)
    {
        Vector2 direction = val.Get<Vector2>();

        transform.position += new Vector3(direction.x, 0, direction.y);
    }
}
