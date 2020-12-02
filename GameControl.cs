using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject GameOverText;
    public GameObject OptionsMenu;
    public GameObject MainMenu;
    public bool gameOver = false;
    public Text scoreText;
    public static GameControl intance;
    public float scrollSpeed = -1.5f;
    private int score = 0;

    void Awake ()
    {
        if( intance == null)
        {
            intance = this;
        }
        else if( intance != null)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true && Input.GetMouseButtonDown(0) )
        {
                SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }
    }

    public void BirdScored()
    {
    	if(gameOver)
    	{
    		return;
    	}
    	score++;
    	scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
       GameOverText.SetActive(true);
       gameOver = true;
        //OptionsMenu.SetActive(true);
        //gameOver = true;
        //MainMenu.SetActive(true);
        //gameOver = true;
    }
}
