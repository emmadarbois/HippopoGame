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

    // Start is called before the first frame update
    void Start()
    {
        this.spawnWaitingHippo();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.dropHippo();
        }

        if (hippoScript.hasLanded)
        {
            this.checkHighestHippo();
            this.spawnWaitingHippo();
        }
    }

    void spawnWaitingHippo()
    {
        hippo = Instantiate(prefab, transform);
        hippoScript = hippo.GetComponent<Hippo>();

        HippoList.Add(hippo);
    }

    void dropHippo()
    {
        hippo.GetComponent<Rigidbody>().isKinematic = false;
        hippo.transform.parent = null;
    }

    void checkHighestHippo()
    {
        float lastPosition = 0f;
        for(int i = 0; i<HippoList.Count; ++i)
        {
            GameObject currentHippo = HippoList[i];

            if (lastPosition < currentHippo.transform.position.y)
            {
                lastPosition = currentHippo.transform.position.y;
            }

        }

        this.lastHighestPosition = lastPosition;
    }
}
