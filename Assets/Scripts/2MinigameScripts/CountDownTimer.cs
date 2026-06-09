using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    
    public string levelToLoad;
    [SerializeField] private float timer = 30f;
    [SerializeField] private TextMeshPro timerSeconds;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if(timer <= 0)
        { 
           SceneManager.LoadScene("EndOfDemo");
        }
    } 


}

