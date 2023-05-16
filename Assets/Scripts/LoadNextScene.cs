using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public string FINAL3; // Il nome della scena di destinazione

    public void PassaAllaScenaSuccessiva()
    {
        SceneManager.LoadScene("FINAL3");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
