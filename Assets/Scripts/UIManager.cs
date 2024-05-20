using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject resetButton;
    // Start is called before the first frame update
    void Start()
    {
        resetButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            resetButton.SetActive(!resetButton.activeSelf);
            Cursor.visible = true;
        }
    }
}
