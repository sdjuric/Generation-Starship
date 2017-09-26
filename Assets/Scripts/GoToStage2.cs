using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToStage2 : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Stage2");
    }

}
