using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LearBorder : MonoBehaviour
{
    public int puntos = 0;
    public string logros;

    public TMP_Text TextPuntos;
    public TMP_Text TextLogors;
    // Start is called before the first frame update
    void Start()
    {
        puntos = PlayerPrefs.GetInt("Puntos");
        logros = PlayerPrefs.GetString("Logros");
        TextPuntos.text = puntos.ToString();
        TextLogors.text = logros;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
