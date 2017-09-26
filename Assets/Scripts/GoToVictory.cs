using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToVictory : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Victory");
    }

}
