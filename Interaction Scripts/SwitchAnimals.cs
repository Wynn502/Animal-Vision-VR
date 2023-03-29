using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchAnimals : MonoBehaviour
{
    public GameObject objectB;
    public GameObject objectC;
    public GameObject objectD;
    public GameObject objectE;

    private GameObject[] objects;
    private int currentIndex = 0;

    private bool canSwitchObject = true;

    void Start()
    {
        objects = new GameObject[] { objectB, objectC, objectD, objectE };

        objectB.SetActive(true);
        objectC.SetActive(false);
        objectD.SetActive(false);
        objectE.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetButton("Choose"))
        {
            // 根据当前显示的对象加载对应场景
            switch (currentIndex)
            {
                case 0:
                    SceneManager.LoadScene("Dog");
                    break;
                case 1:
                    SceneManager.LoadScene("Mice");
                    break;
                case 2:
                    SceneManager.LoadScene("Bird");
                    break;
                case 3:
                    SceneManager.LoadScene("Snake");
                    break;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (canSwitchObject)
            {
                canSwitchObject = false;
                ShowNextObject();
            }
        }
        else if (Input.GetButton("Switch"))
        {
            if (canSwitchObject)
            {
                canSwitchObject = false;
                ShowNextObject();
            }
        }
        else
        {
            canSwitchObject = true;
        }
    }

    void ShowNextObject()
    {
        objects[currentIndex].SetActive(false);

        int nextIndex = (currentIndex + 1) % objects.Length;
        if (nextIndex == currentIndex)
        {
            nextIndex = (currentIndex + 2) % objects.Length;
        }

        currentIndex = nextIndex;
        objects[currentIndex].SetActive(true);
    }
}



//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class SwitchAnimals : MonoBehaviour
//{
//    public GameObject objectB;
//    public GameObject objectC;
//    public GameObject objectD;
//    public GameObject objectE;

//    private GameObject[] objects;
//    private int currentIndex = 0;

//    void Start()
//    {

//        objects = new GameObject[] { objectB, objectC, objectD, objectE };


//        objectB.SetActive(true);
//        objectC.SetActive(false);
//        objectD.SetActive(false);
//        objectE.SetActive(false);
//    }

//    void Update()
//    {

//        if (Input.GetKeyDown(KeyCode.A)||Input.GetButton("Choose"))
//        {
//            // 根据当前显示的对象加载对应场景
//            switch (currentIndex)
//            {
//                case 0:
//                    SceneManager.LoadScene("Dog");
//                    break;
//                case 1:
//                    SceneManager.LoadScene("Mice");
//                    break;
//                case 2:
//                    SceneManager.LoadScene("Bird");
//                    break;
//                case 3:
//                    SceneManager.LoadScene("Snake");
//                    break;
//            }
//        }

//        if (Input.GetMouseButtonDown(0))
//        {

//            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//            RaycastHit hit;
//            if (Physics.Raycast(ray, out hit))
//            {

//                if (hit.collider.gameObject == gameObject)
//                {
//                    ShowNextObject();
//                }
//            }
//        }
//        else if (Input.GetButton("Switch")) {

//            ShowNextObject();
//        }



//    }

//    void ShowNextObject()
//    {

//        objects[currentIndex].SetActive(false);


//        currentIndex = (currentIndex + 1) % objects.Length;
//        objects[currentIndex].SetActive(true);
//    }
//}
