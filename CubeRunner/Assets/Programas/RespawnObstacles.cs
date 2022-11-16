using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObstacles : MonoBehaviour
{
    public GameObject obs;
    public float timeIstantiate;
    public Vector3 offsetPosition;


    void Start()
    {
        InvokeRepeating("CreateObataculo", timeIstantiate, timeIstantiate);
    }

    void CreateObataculo()
    {
        Instantiate(obs, offsetPosition, Quaternion.identity);
    }
}
