using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloading : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Falling.ReloadScene();
    }
}
