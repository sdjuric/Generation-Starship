using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToCombat1 : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Combat1");
    }

}
