using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SewerDoorway : MonoBehaviour
{
    public static void SceneChange()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Sewer");
    }

}
