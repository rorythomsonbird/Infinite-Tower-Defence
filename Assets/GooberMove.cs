using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooberMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(100, -50, -1), 10f * Time.deltaTime);
    }
}
