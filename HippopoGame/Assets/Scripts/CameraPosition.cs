using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public HippoSpawn hippoSpawn;
    public Vector3 PositionGoal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            PositionGoal = new Vector3(0, hippoSpawn.lastHighestPosition + 4, -27);

            transform.position = Vector3.MoveTowards(transform.position, PositionGoal, 2.5f * Time.deltaTime);
    }
}
