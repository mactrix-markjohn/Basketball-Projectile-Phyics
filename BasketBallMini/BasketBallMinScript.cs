using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BasketBallMinScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI PointText;

    private int point = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        PointText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePoint()
    {
        point++;
        PointText.text = $"{point}";
    }
}
