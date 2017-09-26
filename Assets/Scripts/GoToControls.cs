using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToControls : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Controls");
    }

}
