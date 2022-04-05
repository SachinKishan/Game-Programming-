using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
public class BattleInformationHolder : MonoBehaviour
{
    public EnemyOnField target;
    public static BattleInformationHolder main;
    
    private void Awake()
    {
        main = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        NewTarget(FindObjectOfType<EnemyOnField>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewTarget(EnemyOnField t)
    {
        if(target)target.pointer.SetActive(false);
        target = t;
        t.pointer.SetActive(true);
    }
        
}
