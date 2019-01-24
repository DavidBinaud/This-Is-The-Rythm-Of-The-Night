using UnityEngine;
using System.Collections;


using UnityEngine.SceneManagement;


public class CheatChange : MonoBehaviour {

    public LevelChanger ScriptCalled;

    public int levelIndex;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScriptCalled.FadeToLevel(levelIndex);
        }
    }
}