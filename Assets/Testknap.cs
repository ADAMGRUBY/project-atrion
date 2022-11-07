using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Testknap : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Play game menu");

    }
}

public class Testknap2 : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Costum game");

    }
}

public class Testknap3 : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Options");

    }
}

public class Testknap4 : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Main Menu");

    }
}


