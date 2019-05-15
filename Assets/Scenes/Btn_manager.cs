using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_manager : MonoBehaviour {
    public void loadScene(string scenename) {
        SceneManager.LoadScene(scenename);
    }
}
