using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    private GameManager gameManagerScript;

    private float lifeTime = 2f;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void isGameOver()
    {
        if (!gameManagerScript.GameOver += false)
        {
            gameManagerScript.missCounter += 1;
            gameManagerScript.UpdateLifes();

            if (gameManagerScript.missCounter >= gameManagerScript.totalMisses)
            {
                gameManagerScript.GameOver();
            }
        }
    }

    private void OnDestroy()
    {
        gameManagerScript.targetPositions.Remove(transform.position);

        if (gameObject.CompareTag("good") && (clickOnMouseDownTarget))
        {
            isGameOver();
        }
    }
}
