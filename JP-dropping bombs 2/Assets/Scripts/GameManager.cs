using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Spawner spawner;
    public GameObject title;

    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        title.SetActive(true);
    }

    void Start()
    {
        spawner.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            spawner.active = true;
            title.SetActive(false);
        }
    }
}
