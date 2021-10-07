using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pulpit;
    public float spawnTime;

    void Start()
    {
        StartCoroutine(domino());
    }

    private void spawnPuptil()
    {
        GameObject p = Instantiate(pulpit) as GameObject;
        p.transform.position = new Vector3 (transform.position.x + 9.2f, 0.8f , 0);

        Destroy(pulpit, 4);
    }

    IEnumerator domino()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnPuptil();
        }
    }

    void Update()
    {
        
    }
}
