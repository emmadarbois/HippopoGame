using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPositionManager : MonoBehaviour
{
    public HippoSpawn hippoSpawn;

    // Start is called before the first frame update
    void Start()
    {
        if (hippoSpawn == null)
        {
            Debug.Log("pas là");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hippoSpawn.lastHighestPosition);
        gameObject.transform.position = new Vector3(0, hippoSpawn.lastHighestPosition + 5, 0);
    }
}
