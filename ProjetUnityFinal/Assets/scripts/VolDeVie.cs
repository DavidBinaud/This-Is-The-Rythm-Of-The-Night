using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolDeVie : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject healthBarEnnemie;
    public GameObject healthBar;

    public void SetDamages()
    {
        healthBarEnnemie.GetComponent<Scrollbar>().size -= 0.20f;
        if (healthBar.GetComponent<Scrollbar>().size > 0.8f)
        {
            healthBar.GetComponent<Scrollbar>().size = 1;
        }
        else
        {
            healthBar.GetComponent<Scrollbar>().size += 0.2f;
        }
    }
}
