/***
 * Created by: Ethan Landrum
 * 
 * Last Edited by: Ethan Landrum
 * Last Edited: 3/2/2022
 * 
 * Description: Main Menu button functionality.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Debug.Log("Exit Button Works!");
        Application.Quit();
    }
}
