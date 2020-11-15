using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CnvMain : MonoBehaviour
{
    public Text txtSavings;
    public Button btnClick;

    public double value = 0.01;
    public double savings = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        btnClick.GetComponentInChildren<Text>().text = "+$ " + value;
        txtSavings.text = "Savings: $ " + savings.ToString("0.00");
    }

    public void Click()
    {
        savings += value;
    }

    public void Upgrade()
    {
        value *= 2;
    }
}
