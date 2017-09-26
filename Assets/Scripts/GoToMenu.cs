using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
