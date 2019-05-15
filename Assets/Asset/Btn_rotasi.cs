using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_rotasi : MonoBehaviour {
  //Membuat variabel untuk resize layar 
  public GUISkin guiSkin;
  private float guiRatio;
  private float sWidth;
  private Vector3 GUIsF;

  public string scenename;
  public GameObject sphereK;
  public GameObject sphereU;
  public GameObject sphereD;
  public GameObject sphereA;
  public GameObject sphereKUDA;
  public float kecepatanRotasi = 50f;
  bool statusRotasi = false;

  void Awake(){
    sWidth = Screen.width;
    guiRatio = sWidth/1920;
    GUIsF = new Vector3(guiRatio,guiRatio,1);
  }

  void OnGUI(){
    GUI.skin = guiSkin;
    //letakkan function disini
    Rotasi();
  }

  void Rotasi(){
    //Meletakkan tombol dipojok kanan atas
    //GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width-258*GUIsF.x,GUIsF.y,0),Quartenion.identity,GUIsF);
      GUI.matrix = Matrix4x4.TRS(new Vector3(Screen.width-258*GUIsF.x,GUIsF.y,0), Quaternion.identity,GUIsF);

    if (statusRotasi==false){
      if(GUI.Button(new Rect(-208,10,238,59),"Rotasi")){
      statusRotasi = true;
      }
    }else{
      if(GUI.Button(new Rect(-208,10,238,59),"Berhenti")){
      statusRotasi = false;
     }			
    }

    if(GUI.Button(new Rect(40,10,208,59),"Kembali")){
        SceneManager.LoadScene(scenename);
    }
  }

  void Update(){
    if(statusRotasi==true){
      sphereK.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
      sphereU.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
      sphereD.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
      sphereA.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
      sphereKUDA.transform.Rotate(Vector3.up, kecepatanRotasi * Time.deltaTime);
    }
  }
}