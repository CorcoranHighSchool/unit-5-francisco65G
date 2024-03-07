using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public float targetTime = 50.0f;
    private float time;
    public TextMeshProUGUI timeText;
    private GameManagerX gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManagerX>();
    }
    public void UpdateTime()
    {
        time += Time.deltaTime; 
        timeText.text = "Time: " + Mathf.Round(time);
        if (time>=targetTime)
        {
            gameManager.GameOver();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (gameManager.isGameActive)
        {
            UpdateTime();
        }
    }
}
