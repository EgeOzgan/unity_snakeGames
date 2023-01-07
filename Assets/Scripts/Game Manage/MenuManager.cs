using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{

    private void Awake() {
        DontDestroyOnLoad(this);
    }

   public void OpenScene(string  sceneName) =>  SceneManager.LoadScene(sceneName);
}