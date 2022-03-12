using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject dungeon;
//    public List<Gameobject> dungeonList;
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

    public void CreateDungeons(Dungeon dc)
    {
	if(dc.right==null)dc.right=Instantiate(dungeon,dc.gameObject.transform);
	if(dc.down==null)dc.down=Instantiate(dungeon,dc.gameObject.transform);
	if(dc.up==null)dc.up=Instantiate(dungeon,dc.gameObject.transform);
	if(dc.left==null)dc.left=Instantiate(dungeon,dc.gameObject.transform);
    }

}
