using System; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchCharacter : MonoBehaviour
{
    
    public GameObject player1;
    
    public GameObject player2;
    
    public GameObject player3;
    
    public GameObject player4;
    
    public GameObject forest;
   
    private int currentCharacter = 1;

 

    void Start()
    {
        
        currentCharacter = PlayerPrefs.GetInt("CurrentCharacter", 1);

        
        switch (currentCharacter)
        {
            case 1:
                player1.SetActive(true);
                player2.SetActive(false);
                player3.SetActive(false);
                player4.SetActive(false);
                forest.SetActive(true);
                break;
            case 2:
                player1.SetActive(false);
                player2.SetActive(true);
                player3.SetActive(false);
                player4.SetActive(false);
                forest.SetActive(true);
                break;
            case 3:
                player1.SetActive(false);
                player2.SetActive(false);
                player3.SetActive(true);
                player4.SetActive(false);
                forest.SetActive(true);
                break;
            case 4:
                player1.SetActive(false);
                player2.SetActive(false);
                player3.SetActive(false);
                player4.SetActive(true);
                forest.SetActive(false);
                break;
        }
    }


    void Update()
    {


        if (Input.GetKeyUp(KeyCode.Space));
        {
            currentCharacter++;
            if (currentCharacter > 4)
            {
                currentCharacter = 1;
            }

            // Store the current character index in PlayerPrefs
            PlayerPrefs.SetInt("CurrentCharacter", currentCharacter);

            switch (currentCharacter)
            {
                case 1:
                player1.SetActive(true);
                player2.SetActive(false);
                player3.SetActive(false);
                player4.SetActive(false);
                forest.SetActive(true);
                break;
            case 2:
                player1.SetActive(false);
                player2.SetActive(true);
                player3.SetActive(false);
                player4.SetActive(false);
                forest.SetActive(true);
                break;
            case 3:
                player1.SetActive(false);
                player2.SetActive(false);
                player3.SetActive(true);
                player4.SetActive(false);
                forest.SetActive(true);
                break;
            case 4:
                player1.SetActive(false);
                player2.SetActive(false);
                player3.SetActive(false);
                player4.SetActive(true);
                forest.SetActive(false);
                break;
            }

            // �ӳ�1������¼��ص�ǰ����
            //Invoke("ReloadScene", 1f);
        }
    }

    //void ReloadScene()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}





// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class SwitchCharacter : MonoBehaviour
// {
//     public GameObject player1;
//     public GameObject player2;
//     public GameObject player3;
//     private int currentCharacter = 1;

//     void Start()
//     {
        
//         currentCharacter = PlayerPrefs.GetInt("CurrentCharacter", 1);

        
//         switch (currentCharacter)
//         {
//             case 1:
//                 player1.SetActive(true);
//                 player2.SetActive(false);
//                 player3.SetActive(false);
//                 break;
//             case 2:
//                 player1.SetActive(false);
//                 player2.SetActive(true);
//                 player3.SetActive(false);
//                 break;
//             case 3:
//                 player1.SetActive(false);
//                 player2.SetActive(false);
//                 player3.SetActive(true);
//                 break;
//         }
//     }


//     void Update()
//     {
//         // ������ֱ���X�����ֱ���Aͬʱ����
//         if (Input.GetButton("Fire1") && Input.GetButton("Fire3"))
//         {
//             currentCharacter++;
//             if (currentCharacter > 3)
//             {
//                 currentCharacter = 1;
//             }

//             // Store the current character index in PlayerPrefs
//             PlayerPrefs.SetInt("CurrentCharacter", currentCharacter);

//             switch (currentCharacter)
//             {
//                 case 1:
//                     player1.SetActive(true);
//                     player2.SetActive(false);
//                     player3.SetActive(false);
//                     break;
//                 case 2:
//                     player1.SetActive(false);
//                     player2.SetActive(true);
//                     player3.SetActive(false);
//                     break;
//                 case 3:
//                     player1.SetActive(false);
//                     player2.SetActive(false);
//                     player3.SetActive(true);
//                     break;
//             }

//             // �ӳ�1������¼��ص�ǰ����
//             //Invoke("ReloadScene", 1f);
//         }
//     }

//     void ReloadScene()
//     {
//         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//     }
// }
