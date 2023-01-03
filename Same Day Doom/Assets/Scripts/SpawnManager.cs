using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
      public GameObject Target;
       public float xRange = 5;
        public float yRange = 2.56f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private Vector2 GenerateSpawnPosition()
    {
        float spawnXPos = Random.Range(-xRange , xRange);
        float spawnYPos = Random.Range(-yRange, yRange);
        Vector2 randomPos = new Vector2(spawnXPos, spawnYPos);
        return randomPos;
    }
}
