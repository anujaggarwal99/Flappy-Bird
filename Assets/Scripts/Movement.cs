using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public PipeGenerator PipeGenerator;
    private Transform cameraTransform = null;
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.isAlive)
        {
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
            if (transform.position.x < cameraTransform.position.x)
            {
                var nextPos = PipeGenerator.GetNextPosition();
                transform.position = new Vector3(nextPos.x, nextPos.y, transform.position.z);
            }
        }
    }
}
