using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public HippoSpawn hippoSpawn;
    public Vector3 PositionGoal;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-10, 8, 0);
    }

    // Update is called once per frame
    void Update()
    {
        PositionGoal = new Vector3(-10, hippoSpawn.lastHighestPosition + 2, 0);

        transform.position = Vector3.MoveTowards(transform.position, PositionGoal, 1f * Time.deltaTime);
    }
}
