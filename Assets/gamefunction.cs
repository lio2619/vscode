using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamefunction : MonoBehaviour {
	
	// Use this for initialization
	
	public GameObject ementy;
	public Text ScoreText;
	public int Score = 0;
	public int game = 0;
	public static gamefunction Instance;
	public GameObject GameTitle;
	public GameObject GameOverTitle;
	public GameObject PlayButton;
	public bool Isplaying = false;
	public GameObject RestartButton;
	public GameObject QuitButton;
	public Text LevelText;
	public int Level = 1;

	public float time;
	void Start () {
		Instance = this;

		GameOverTitle.SetActive(false);		//不顯示

		RestartButton.SetActive(false);		//不顯示
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time>0.5f && Isplaying){		//怪物何時出現
			Vector3 pos = new Vector3(Random.Range(-2.5f, 2.5f), 4.5f, 0);		//位置隨機
			Instantiate(ementy,pos,transform.rotation);
			time = 0f;
		}
		
		//按下空白鍵直接開始遊戲
		if(Input.GetKeyDown(KeyCode.Space)){		
			if(game == 0){
				GameStart();
				game = game + 1;
			}
		}

		if(Input.GetKeyDown(KeyCode.R)){
			Reatart();
		}

		if(Input.GetKeyDown(KeyCode.Q)){			//按下Q直接離開遊戲
			Quit();
		}
	}

	public void AddScore(){
		Score += 10;		//分數一次加十分
		ScoreText.text = "Score:" + Score;
	}

	public void AddLevel(){
		if(Score <= 100){
			LevelText.text = "Level:" + 1;
		}	else if(Score > 100 && Score <= 250){
			LevelText.text = "Level:" + 2;
		}
	}
	public void GameStart(){
		Isplaying = true;
		GameTitle.SetActive(false);
		PlayButton.SetActive(false);
		QuitButton.SetActive(false);
	}

	public void GameOver(){
		Isplaying = false;
		GameOverTitle.SetActive(true);
		RestartButton.SetActive(true);
		QuitButton.SetActive(true);
	}

	public void Reatart(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void Quit(){
		Application.Quit();
	}
}
