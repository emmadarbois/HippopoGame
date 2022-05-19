using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HippoSpawn : MonoBehaviour
{
    public GameObject prefab;
    private GameObject hippo;
    private Hippo hippoScript;
    private List<GameObject> HippoList = new List<GameObject>();
    public float lastHighestPosition = 0f;
    public float lastHighestHitPoint = 0f;

    // Start is called before the first frame update
    void Start()
    {
        this.spawnWaitingHippo();
    }

    // Update is called once per frame
    void Update()
    {
        this.checkHighestHippo();

        if (Input.GetButtonDown("Fire1"))
        {
            this.dropHippo();
        }

        if (hippoScript.hasLanded)
        {
            this.spawnWaitingHippo();

            this.checkHighestHippoTouchingDown();
        }
    }

    void spawnWaitingHippo()
    {
        hippo = Instantiate(prefab, transform);
        hippoScript = hippo.GetComponent<Hippo>();
    }

    void dropHippo()
    {
        hippo.GetComponent<Rigidbody>().isKinematic = false;
        hippo.transform.parent = null;
        HippoList.Add(hippo);
    }

    void checkHighestHippo()
    {
        float lastPosition = 0f;

        if (this.HippoList.Count == 0)
        {
            return;
        }

        for(int i = 0; i<this.HippoList.Count; ++i)
        {
            GameObject currentHippo = this.HippoList[i];

            if (lastPosition < currentHippo.transform.position.y)
            {
                lastPosition = currentHippo.transform.position.y;
            }
        }

        this.lastHighestPosition = lastPosition;
    }

    void checkHighestHippoTouchingDown()
    {
        float lastPosition = 0f;

        if (this.HippoList.Count == 0)
        {
            return;
        }

        for (int i = 0; i < this.HippoList.Count; ++i)
        {
            GameObject currentHippo = this.HippoList[i];

            if (lastPosition < currentHippo.transform.position.y)
            {
                lastPosition = currentHippo.transform.position.y;
            }
        }

        this.lastHighestHitPoint = lastPosition;
    }
}
