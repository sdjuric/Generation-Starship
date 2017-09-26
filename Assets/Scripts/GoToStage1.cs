using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToStage1 : MonoBehaviour {
    
    public AudioClip fanfareSound;

    private void MakeSound(AudioClip originalClip)
    {
        // As it is not 3D audio clip, position doesn't matter.
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }

    public void onClick()
    {
        MakeSound(fanfareSound);
        SceneManager.LoadScene("Stage1");
    }

}
