using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventHandle : MonoBehaviour
{
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
     * Traté de encontrar el erro, pero no encontré la clase de cunado hicimos el código
    public void GivePont()
    {
        UpdateEvents();
        counter++;
        Debug.Log("New poit");
    }
    
    public void UpdateEvents()
    {
        if(counter == 15)
        {
            Notification.text = "New Goal 25 XP";
            Debug.Log("New 25 xp - Even Raeachad");
            PlayerPrefs.SetString("Logros", Notification.text);
        }
    }

    public void LeaveGame()
    {
        PlayerPrefs.SetString("points", counter);
        SceneManager.LoadScene("LeaderBoard");
    }
    */
}
