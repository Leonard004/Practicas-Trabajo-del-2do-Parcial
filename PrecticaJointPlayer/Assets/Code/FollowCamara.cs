using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamara : MonoBehaviour
{
    public Transform Target;
    public float speed = 2f;
    public Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(Target.position.x, Target.position.y, -10f) + Offset;
        transform.position = Vector3.Slerp(transform.position, newpos, speed * Time.deltaTime);
    }
}
