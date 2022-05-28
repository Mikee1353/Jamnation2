using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    
    public bool camReversed = false;
    Camera cam;
    public int repeatTime;
    bool KayriwasHere;

    private void Start()
    {
        Reset[] ResetScripts = FindObjectsOfType<Reset>();
        int i = 0;
        foreach (Reset rs in ResetScripts)
        {
            if (i > 0)
            {
                Destroy(rs.gameObject);
            }
            i++;
        }

        DontDestroyOnLoad(gameObject);

        Debug.Log("Start");


    }
    void Update()
    {
        if (camReversed && KayriwasHere)
        {
            KayriwasHere = false;
            Debug.Log("Rev");
            transform.Rotate(0, 0, 180);
        }

        //Restart
        if (Input.GetKeyDown(KeyCode.R))
        {

            camReversed = !camReversed;
            KayriwasHere = camReversed;
            Restart();
            Debug.Log("1 artt?" + repeatTime);
                    
        }


    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
