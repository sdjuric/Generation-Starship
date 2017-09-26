using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToCredits : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Credits");
    }

}
