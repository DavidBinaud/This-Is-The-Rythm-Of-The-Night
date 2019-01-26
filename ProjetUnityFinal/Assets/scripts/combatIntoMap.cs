using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class combatIntoMap : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame

    public GameObject healthBarEnnemie;
    public GameObject healthBar;
    public Animator animator;
    private int levelToLoad;
    public LevelChanger ScriptCalled;

    void Update()
    {
        if (healthBar.GetComponent<Scrollbar>().size == 0f)
        {
            ScriptCalled.FadeToLevel(1);
        }
        else if (healthBarEnnemie.GetComponent<Scrollbar>().size == 0f)
        {
            ScriptCalled.FadeToNextLevel();
        }
    }


    

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
