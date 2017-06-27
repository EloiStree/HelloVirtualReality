using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour {


    public void Restart() {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name);
    }
}
