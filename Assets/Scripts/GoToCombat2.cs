using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToCombat2 : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Combat2");
    }

}
