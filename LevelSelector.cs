using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour {

   void Start () {
      
   }
   public void OpenScene(){
    SceneManager.LoadScene("LevelSelector");
   }
}

