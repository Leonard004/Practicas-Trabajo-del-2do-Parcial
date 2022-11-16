using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static int score = 0;
    public string scoreString = "socre";

    public static GameControler Gamecontroller;
    public Text textScore;


    private void Awake()
    {
        Gamecontroller = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textScore != null)
        {
            textScore.text = scoreString + score.ToString();
        }
    }
}
