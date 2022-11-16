using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Item;
    public int WaveIndex = 25;
    public float TimeOfWaves = 6.5f;
    public float Timer = 2.5f;
    public Transform[] points;

    private void Awake()
    {
        Debug.Log("Amount of Childs: " + transform.childCount);
        points = new Transform[transform.childCount];

        for (int i = 0; i< points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (WaveIndex != 25)
        {
            if(Timer <= 0.0f)
            {
                //New wave
                SpawItem();
                Timer = TimeOfWaves;
            }
        }
        Timer -= Time.deltaTime;
    }

    public IEnumerator Wave()
    {
        yield return new WaitForSeconds(0.0f);
    }

    public void SpawItem()
    {
        int randomPoint = Random.Range(0, points.Length);
        var Obj = Instantiate(Item, points[randomPoint].position, transform.rotation);
    }


}
