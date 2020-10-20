using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void SwitchToCloth()
    {
        SceneManager.LoadScene(0);
    }
    public void SwitchToBreak()
    {
        SceneManager.LoadScene(1);
    }
}
