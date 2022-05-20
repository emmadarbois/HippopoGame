using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public HippoSpawn hippoSpawn;
    public TextMeshProUGUI text;
    public bool isHighScore;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int newScore = ((int)(this.hippoSpawn.lastHighestHitPoint*100));

        if (newScore > this.score)
        {
            this.score = newScore;
        }

        if (!this.isHighScore)
        {
            text.SetText(newScore.ToString());

        }
        else if (this.isHighScore)
        {
            text.SetText(this.score.ToString());
        }

    }
}
