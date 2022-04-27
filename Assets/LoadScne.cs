using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScne : MonoBehaviour
{
    public int i;
    public void Loadnoww()
    {
        SceneManager.LoadScene(i);
    }

}
