using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownerController : MonoBehaviour
{

    public GameObject[] ObjsToSpawn;
    public GameObject Bomb;
    public Transform[] spawnPlaces;
    public float minWait = 0.3f;
    public float maxWait = 1f;
    public float minForce = 12f;
    public float maxForce = 17f;
    public float timeDecrease;

    private float timeBtwSpawns;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruits());

        timeBtwSpawns = maxWait;
    }

    public void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            timeBtwSpawns = maxWait;
            if (maxWait > minWait)
            {
                maxWait -= timeDecrease;
            }
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));

            Transform t = spawnPlaces[Random.Range(0, spawnPlaces.Length)];

            GameObject go = null;
            float p = Random.Range(0, 100);

            if (p < 10)
            {
                go = Bomb;
            }
            else
            {
                go = ObjsToSpawn[Random.Range(0, ObjsToSpawn.Length)];
            }

            GameObject Debree = Instantiate(go, t.position, t.rotation);

            Debree.GetComponent<Rigidbody>().AddForce(-t.transform.up * Random.Range(minForce, maxForce), ForceMode.Impulse);

            Debug.Log("fruits are spawned");

            Destroy(Debree, 5);
        }
    }
}
