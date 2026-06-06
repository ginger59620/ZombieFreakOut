using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Options()
    {

        SceneManager.LoadScene("Options");
    }
    public void FistNarrative()
    {
        SceneManager.LoadScene("FistNarrative");
    }
    public void CharacterSelector()
    {
        SceneManager.LoadScene("CharacterSelector");
    }
    public void FistMinigame()
    {
        SceneManager.LoadScene("FistMinigame");
    }
    /*public void SecondNarrative()
    {
        SceneManager.LoadScene("SecondNarrative");
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("SecondNarrative");
    }
    public void SecondMinigame()
    {
        SceneManager.LoadScene("SecondMinigame");
    }
    public void ThirdNarrative()
    {
        SceneManager.LoadScene("ThirdNarrative");
    }
    public void ControlsTut()
    {
        SceneManager.LoadScene("ControlsTut");
    }
    public void EndOfDemo()
    {
        SceneManager.LoadScene("EndOfDemo");
    }
}
