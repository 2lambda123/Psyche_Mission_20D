using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour
{

    private static float volume = 5.0f;
    public static ArrayList questionList = new ArrayList();

    void Start()
    {
        GameObject.Find("Main Camera").GetComponent<AudioSource>().volume = GameSettings.GetVolume() / 10;
    }

    public static void MainMenu()
    {
        SceneManager.LoadScene("Scenes/StartScene");
    }

    public static void AdvanceGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public static void SetVolume(float newVolume)
    {
        volume = newVolume;
    }

    public static float GetVolume()
    {
        return volume;
    }

}