using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : UnitBaseClass
{
    [SerializeField] State state = State.Idle;
    [SerializeField] float prepRate = 1;
    [SerializeField] float decisionRate = 1;

    //[SerializeField]private Skill skill;

    [SerializeField] float decisionTime = 6;
    [SerializeField] float prepTime = 4;

    private float dt;
    private float pt;
    Ability currentAbility;
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
                //wait for player input
                //when input received, switch to prep
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
        Debug.Log("IDLE");
    }

    public void SwitchToPrep()
    {
       
        pt = currentAbility.cooldownTime;
        Debug.Log("PREP");
        state = State.Prep;
    }

    public void SwitchToAct()
    {
        Debug.Log("ACT");
        currentAbility.Activate();
        //activate selected ability, just use some number ability number as chosen by ai. 
        //ability.Activate(gameObject);
        state = State.Act;

    }

    public void SetAbility(Ability a)
    {
        currentAbility = a;
        SwitchToPrep();
    }
}
