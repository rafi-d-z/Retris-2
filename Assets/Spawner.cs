using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] groups;

    public void spawnNext()
    {
        // Random Index
        int i = Random.Range(0, groups.Length);

        // Spawn Group at current Position
        Instantiate(groups[i], transform.position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawn initial group
        spawnNext();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
