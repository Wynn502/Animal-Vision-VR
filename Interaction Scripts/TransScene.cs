using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransScene : MonoBehaviour
{
    public void Trans_Bird()
    {
        SceneManager.LoadScene("Bird");
    }

    public void Trans_Mice()
    {
        SceneManager.LoadScene("Mice");
    }

    public void Trans_Dog()
    {
        SceneManager.LoadScene("Dog");
    }

    public void Trans_Snake()
    {
        SceneManager.LoadScene("Snake");
    }

    void Update()
    {

        if (Input.GetButton("Return"))
        {

            SceneManager.LoadScene("ChooseAnimal");
        }

    }

}
