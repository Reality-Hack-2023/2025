using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject searchDropdown;
    public GameObject selectorBar;

    // Update is called once per frame
    void Update()
    {
        selectorBar.SetActive(!searchDropdown.activeSelf);
    }
}
