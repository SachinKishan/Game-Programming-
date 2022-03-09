using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject dungeon;


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
        }
    }

    private void InstantiateDungeon()
    {
        GameObject d=Instantiate(dungeon);
        d.GetComponent<Dungeon>().SetNumber(PickRandomNumber(10));
    }

    private int PickRandomNumber(int maxInt)
    {
        return Random.Range(1, maxInt + 1);
    }

}
