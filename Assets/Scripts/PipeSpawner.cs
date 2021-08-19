using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 5;
    private float timer = 0;

    // Reference to Pipe
    public GameObject bigpipe;
    public float height;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject newbigpipe = Instantiate(bigpipe);
        newbigpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newbigpipe = Instantiate(bigpipe);
            newbigpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newbigpipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
