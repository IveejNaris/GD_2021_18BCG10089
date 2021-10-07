using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideEnd : MonoBehaviour
{
    int score = 0;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Finish")
        {
            Debug.Log("HIT");
            SceneManager.LoadScene("End");
        }

        if(col.gameObject.tag == "SpawnLand")
        {
            Debug.Log(score);
            score += 1;
        }
    }
}
