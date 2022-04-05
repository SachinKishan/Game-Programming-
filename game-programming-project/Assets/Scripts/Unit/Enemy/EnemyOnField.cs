using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOnField : UnitBaseClass
{
    [SerializeField] UnitBaseClass player;
    [SerializeField] State state = State.Idle;
    [SerializeField] float prepRate = 1;
    [SerializeField] float decisionRate = 1;
    [SerializeField] float decisionTime = 6;
    [SerializeField] float prepTime = 4;

    private float dt;
    private float pt;

    // Start is called before the first frame update
    void Start()
    {
        pt = prepTime;
        dt = decisionTime;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Idle:
                if (dt > 0)
                {
                    dt -= Time.deltaTime * decisionRate;
                }
                else
                {

                    SwitchToPrep();
                }
                break;

            case State.Prep:
                if (pt > 0)
                {
                    pt -= Time.deltaTime * prepRate;
                }
                else
                {
                    SwitchToAct();
                }
                break;

            case State.Act://depends on animation, a constant for now 
                SwitchToIdle();

                break;
        }
    }
    public void SwitchToIdle()
    {

        dt = decisionTime;
        state = State.Idle;
        Debug.Log("act performed");
    }

    public void SwitchToPrep()
    {
        //call ai to choose which ability
        pt = prepTime;
        Debug.Log("Decision made, prepping move");
        state = State.Prep;
    }

    public void SwitchToAct()
    {
        Debug.Log("Prep complete, performing action");
        //activate selected ability, just use some number ability number as chosen by ai. 
        abilities[0].Activate(player);
        state = State.Act;

    }

    private void OnMouseDown()
    {
        BattleInformationHolder.main.target = this.gameObject.GetComponent<UnitBaseClass>();
    }
}
