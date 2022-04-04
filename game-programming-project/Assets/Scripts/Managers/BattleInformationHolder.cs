using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleInformationHolder : MonoBehaviour
{
    public UnitBaseClass target;
    public static BattleInformationHolder main;
    
    private void Awake()
    {
        main = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
