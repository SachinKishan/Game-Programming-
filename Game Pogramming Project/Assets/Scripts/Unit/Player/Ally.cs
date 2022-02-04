using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
	Idle, 
	Prep, 
	Act
};

public class Ally : MonoBehaviour
{

	[SerializeField]State state=State.Idle;
	[SerializeField]float prepRate=1;
	[SerializeField]float decisionRate=1;

    	//[SerializeField]private Skill skill;

   	[SerializeField] float decisionTime=6;
	[SerializeField] float prepTime=4;

	private float dt;
	private float pt;

    // Start is called before the first frame update
    void Start()
    {
        pt=prepTime;
	dt=decisionTime;
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case State.Idle:
		if(dt>0)
		{
			dt-=Time.deltaTime*decisionRate;
		}
                else 
                {
                    SwitchToPrep();
                }
                break;
            
            case State.Prep:
                if(pt>0)
		{
			pt-=Time.deltaTime*prepRate;
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
        
	dt=decisionTime;
        state = State.Idle;
        Debug.Log("act performed");
    }

    public void SwitchToPrep()
    {
	pt=prepTime;
        
        Debug.Log("Decision made, prepping move");
        state = State.Prep;
    }

    public void SwitchToAct()
    {
        //ability.Activate(gameObject);
        state = State.Act;
	Debug.Log("Prep complete, performing action");
    }
  
}