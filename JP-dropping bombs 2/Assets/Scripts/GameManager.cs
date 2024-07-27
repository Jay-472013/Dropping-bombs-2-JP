using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
    private spawner spawner;
    public GameObject title;
    private Vector2 screenBounds;
=======
    private Spawner spawner;
    public GameObject title;

    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        title.SetActive(true);
    }
>>>>>>> 764c6801a8d00be9142f8f80306f1c8eacccf36b

    void Start()
    {
        spawner.active = false;
        title.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            spawner.active = true;
            title.SetActive(false);
<<<<<<< HEAD
        }

        var nextBomb = GameObject.FindGameObjectsWithTag("Bomb");

        foreach (GameObject bombObject in nextBomb)
        {
            if (bombObject.transform.position.y < (-screenBounds.y) - 12)
            {
                Destroy(bombObject);
            }
        }
    }

    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<spawner>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
=======
        }
    }
>>>>>>> 764c6801a8d00be9142f8f80306f1c8eacccf36b
}
