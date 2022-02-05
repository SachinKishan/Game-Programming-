using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject Dungeon;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            InstantiateDungeon();
            PickRandomNumber(10);
        }
    }

    private void InstantiateDungeon()
    {
        Instantiate(Dungeon);
    }

    private void PickRandomNumber(int maxInt)
    {
        int randomNum = Random.Range(1,maxInt+1);
        Debug.Log(randomNum);
    }

}
