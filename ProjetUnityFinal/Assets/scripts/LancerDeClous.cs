using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LancerDeClous : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject healthBarEnnemie;
    public GameObject healthBar;

    public void SetDamages()
    {
        healthBarEnnemie.GetComponent<Scrollbar>().size -= 0.08f;
        healthBar.GetComponent<Scrollbar>().size -= 0.15f;
    }
}
