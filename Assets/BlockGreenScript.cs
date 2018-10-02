using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockGreenScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
    {
        //gameObject - это тот объект, на котором находится скрипт
        //здесь это блок
        //col.gameObject - это тот, кто врезался или наложился
        //здесь это мячик
        MainCameraScript.score++;
        Destroy(gameObject);
        if(MainCameraScript.score == 38)
        {
            string sceneName = "MainScene";
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
