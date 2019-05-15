using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Btn_keluar : MonoBehaviour {
    public Canvas start;
    public Button exit;

    public void keluar()
    {
        Application.Quit();
    }

}
