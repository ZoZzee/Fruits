using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomFruits : MonoBehaviour
{
    public TextMeshProUGUI[] fruitsText;
    public TextMeshProUGUI textApp;
    public static float vectorX ;
    public static float vectorZ ;
    public Button restartButton ;

    public GameObject canvas;

    public static bool finishGame = false;

    private int prost = 0;
    private int numer = 1;
    private int ostatoc = 1;

    public static int[,] fruitRandAndKil = new int[4,2];

    private int[] fruitsNum = new int [4];


    void Start()
    {
        Invoke("FruitRand",0f);
        InvokeRepeating("obgect", 2f , 0.5f);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        finishGame = false;
        //gameOver= false;
    }

    void TextFruits( int i)
    {
        int num = fruitRandAndKil[i, 1];

        

        if (fruitRandAndKil[i, 1] == 0)
        {
            fruitsText[i].gameObject.SetActive(false);
        }
        else 
        {
            fruitsText[i].gameObject.SetActive(true);
        }

        vectorX = Random.Range( -3.3f,-9.7f);
        vectorZ = Random.Range( -7.4f,-10f);
        
        if (fruitsNum[i] > fruitRandAndKil[i, 1])
        {
            fruitsNum[i] = fruitRandAndKil[i, 1];
        }

        switch (fruitRandAndKil[i, 0])
        {
            case 1:
                fruitsText[i].text = "Apples = " + num;
                
        
                break; 
            case 2:
                fruitsText[i].text = "Avocados = " + num;

                break;
            case 3:
                fruitsText[i].text = "Banana = " + num;

                break;
            case 4:
                fruitsText[i].text = "Cherries = " + num;

                break;
            case 5:
                fruitsText[i].text = "Lemons = " + num;

                break;
            case 6:
                fruitsText[i].text = "Strawberries = " + num;

                break;
        }

        if (fruitRandAndKil[i, 1] == 0)
        {
            ostatoc -= 1;
        }

        if(ostatoc <= 0)
        {
            restartButton.gameObject.SetActive(true);
            finishGame=true;
        }

    }

    void FruitRand()
    {
        int Num = Random.Range(2,4);
        for(int i=0; i<Num; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    int fruit = Random.Range(1, 6);
                    if ( i == 0)
                    {
                        fruitRandAndKil[i,0] = fruit;
                    } 
                    else
                    {
                        while(fruitRandAndKil[i - 1,0] == fruit )
                        {
                            fruit = Random.Range(1, 6);
                            fruitRandAndKil[i,j] = fruit;

                        }
                        if(fruitRandAndKil[i - 1, 0] != fruit)
                        {
                            fruitRandAndKil[i, j] = fruit;
                        }
                        if (i >= 2)
                        {
                            while (fruitRandAndKil[i - 2, 0] == fruit)
                            {
                                fruit = Random.Range(1, 6);
                                fruitRandAndKil[i, j] = fruit;
                                
                            }
                        }
                    }
                }
                if(j==1)
                {
                    int fruit = Random.Range(1, 5);
                    fruitRandAndKil[i, j] = fruit;
                    fruitsNum[i] = fruit;
                }
                
                
            }
            TextFruits(i);
            numer = Num;
            
        }
    }

    void obgect()
    {
        if (finishGame == false)
        {
            ostatoc = numer;
            for (int i = 0; i < numer; i++)
            {
                TextFruits(i);
            }
        }
    }

}
