using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerUpgrades : MonoBehaviour
{
    public GameObject pnlUpgrades;
    public Button btnClose;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        pnlUpgrades.gameObject.SetActive(false);
    }
}
