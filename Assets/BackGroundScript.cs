using UnityEngine;
using UnityEngine.SceneManagement;

public class BackGroundScript : MonoBehaviour {

    public SimpleAds ads; //объект берём от MainCamera в редакторе Unity

    void OnCollisionEnter2D(Collision2D col)
    {
        //gameObject - это тот объект, на котором находится скрипт
        //здесь это блок
        //col.gameObject - это тот, кто врезался или наложился
        //здесь это мячик
        MainCameraScript.racket--;
        if(MainCameraScript.racket == 1)
        {
            if(ads != null)
            {
                ads.ShowAd();
            }
        }
        if(MainCameraScript.racket == 0)
        Destroy(col.gameObject);
        if(MainCameraScript.racket == 0)
        {
            string sceneName = "MainScene";
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
