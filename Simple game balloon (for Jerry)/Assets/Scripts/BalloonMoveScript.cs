using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMoveScript : MonoBehaviour
{
    [SerializeField]
    float mSpeed = 0;
    int scoreValue;

    void Update()
    {
        if (mSpeed == 0)
        {
            mSpeed = Random.Range(2.0f, 3.5f);
        }
        transform.Translate(Vector3.up * Time.deltaTime * mSpeed);
    }
}
