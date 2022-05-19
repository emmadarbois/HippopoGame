using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public HippoSpawn hippoSpawn;
    public TextMeshPro text;

    public Vector3 PositionGoal;
    public float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PositionGoal = new Vector3(transform.position.x, this.hippoSpawn.lastHighestPosition + 10, transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, PositionGoal, 2f * Time.deltaTime);

        float newScore = ((int)(this.hippoSpawn.lastHighestHitPoint*100));

        if (newScore > this.score)
        {
            text.SetText(newScore.ToString());

            this.score = newScore;
        }

    }
}
