using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    //To do make an option menu
    //[SerializeField]
    //private UnityEvent _options = new UnityEvent();   



    public void Play()
    {
        //_play.Invoke();
        SceneManager.LoadScene(sceneName: "main_game");
    }

    public void Options()
    {
        //_options.Invoke();
    }

    public void Quit()
    {
        Application.Quit();
    }

}
