using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public int PipesToSpawn = 10;
    public int PipeDistance = 3;
    public GameObject Pipe;
    public Transform Pipes;
    public float MinY;
    public float MaxY;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<PipesToSpawn; i++)
        {
            GameObject pipe = Instantiate(Pipe) as GameObject;
            Transform pipeTransform = pipe.transform;
            pipeTransform.transform.position = new Vector3(pipeTransform.transform.position.x + ((i+1)*PipeDistance), Random.Range(MinY,MaxY),  pipeTransform.transform.position.z);
            pipeTransform.parent = Pipes;
            pipe.GetComponent<Movement>().PipeGenerator = this;
        }
    }

    public Vector2 GetNextPosition()
    {
        return new Vector2(PipesToSpawn * PipeDistance, Random.Range(MinY, MaxY));
    }
}
