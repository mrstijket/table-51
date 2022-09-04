using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFromCredits : MonoBehaviour
{
    [SerializeField] MenuManagerMenuScene menuScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            menuScene.LoadMenu();
        }
        StartCoroutine(LoadAutomatically());
    }
    IEnumerator LoadAutomatically()
    {
        yield return new WaitForSeconds(30);
        menuScene.LoadMenu();
    }
}
