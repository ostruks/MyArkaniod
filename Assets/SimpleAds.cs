using UnityEngine;
using UnityEngine.Advertisements; //доступен после подключения учётной записи с рекламным пакетом

public class SimpleAds : MonoBehaviour {
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        { 
            //if(PlayerPrefs.GetInt("noads")!=1) 
            {
                Advertisement.Show();
                //PlayerPrefs.SetInt("DC",0); 
            }
        }
    }
}
