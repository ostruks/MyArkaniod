using UnityEngine;

public class MainCameraScript : MonoBehaviour {

	public static int score;
	public static int racket;
	// Use this for initialization
	void Start () {
		score = 0;
		racket = 5;
	}
	void OnGUI() //Для отладки игрового цикла
    {
		GUI.Label (new Rect(10, 20, 100, 25),  "Счет: " + score);
		GUI.Label (new Rect(10, 45, 100, 25),  "Жизни: " + racket);
	}
}
