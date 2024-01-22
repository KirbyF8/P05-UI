using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_sc : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI points;
    [SerializeField] private TextMeshProUGUI lives;
    [SerializeField] private TextMeshProUGUI time;

    private void Start()
    {
        points.text = "Score\r\n\r\n0000000";
    }
    /*
    public void LostLive()
    {
        
    }
    */
}
