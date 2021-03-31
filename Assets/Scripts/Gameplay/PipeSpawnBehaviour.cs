using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnBehaviour : MonoBehaviour
{
    //the lowest Y
    public float yMin;
    //the highest Y
    public float yMax;
    //Time between pipe spawn
    public float TimeInterval;
    public bool GameOver = false;
    //pipe reference
    public GameObject PipeRef;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    public IEnumerator SpawnPipes()
    {
        float randY;
        while(!GameOver)
        {
            //find a random spawn position for pipes
            randY = Random.Range(yMin, yMax);
            Vector3 spawnPosition = new Vector3(transform.position.x  , randY, transform.position.z);
            //spawn in an instance of the pipe at the given position
            GameObject pipe = Instantiate(PipeRef.gameObject, spawnPosition, new Quaternion());
            //get the movement compound attatched to the spawned object
            MovementBehaviour moveScript = pipe.GetComponent<MovementBehaviour>();
            //set the starting cosine to be a random value
            moveScript.StartCos = Random.Range(-1, 1);

            //Wait for the given time interval before resuming the function
            yield return new WaitForSeconds(TimeInterval);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
