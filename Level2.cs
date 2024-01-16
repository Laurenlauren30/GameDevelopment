using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour {

   void Start () {
      
   }
   public void OpenScene(){
    SceneManager.LoadSceneAsync(3);
   }
}

