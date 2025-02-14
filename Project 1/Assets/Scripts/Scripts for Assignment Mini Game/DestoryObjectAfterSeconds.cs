﻿/*Julian Avila
 * Project 1
 * Destroys the object after some time
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObjectAfterSeconds : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyObject()
    {
        while (true)
        {
            if (GameManager.currentLevel == 1)
                yield return new WaitForSeconds(5.0f);
            if (GameManager.currentLevel == 2)
                yield return new WaitForSeconds(4.0f);
            if (GameManager.currentLevel == 3)
                yield return new WaitForSeconds(3.0f);
            if (GameManager.currentLevel == 4)
                yield return new WaitForSeconds(2.0f);

            Destroy(gameObject);
          
            AssignmentMiniGameManager.missedHits++;
            AssignmentMiniGameManager.assignmentsRemaining-- ;

        }
    }

}
