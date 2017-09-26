using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToStage3 : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Stage3");
    }

}
