using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject dungeon;
    public GameObject currentDungeon;
    public static Generator main;
    
	
    void Awake()
    {
	main=this;
    }
	// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateDungeon()
    {
        GameObject d=Instantiate(dungeon,currentDungeon.transform);
	d.transform.localPosition=new Vector2(0f,1f);
       // d.GetComponent<Dungeon>().SetNumber(PickRandomNumber(10));
	currentDungeon=d;
    }

    private int PickRandomNumber(int maxInt)
    {
        return Random.Range(1, maxInt + 1);
    }

  

}
