using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame() {
        Debug.Log("Oyundan Çıktık");
        Application.Quit();
    }

    public void OpenMenu(GameObject menu) {
        menu.SetActive(!menu.activeSelf);
    }

    public void SetTimeScale(float newTimeScale) => Time.timeScale = newTimeScale;

    public void OpenScene(string sceneName) => SceneManager.LoadScene(sceneName);
}