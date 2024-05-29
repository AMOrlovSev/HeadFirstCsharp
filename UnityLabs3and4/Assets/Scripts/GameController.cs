using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;
    void Start()
    {
        InvokeRepeating("AddABall", 1.5F, 1);
    }
    void AddABall()
    {
        Instantiate(OneBallPrefab);
    }
}
