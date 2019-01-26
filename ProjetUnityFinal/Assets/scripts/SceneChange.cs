using UnityEngine;
using System.Collections;


using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour {

    public LevelChanger ScriptCalled;

    public int levelIndex;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScriptCalled.FadeToNextLevel();
        }
    }
}