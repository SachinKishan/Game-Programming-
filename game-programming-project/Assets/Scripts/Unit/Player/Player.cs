using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : UnitBaseClass
{
    [SerializeField] State state = State.Idle;
    [SerializeField] float prepRate = 1;
    [SerializeField] float decisionRate = 1;

    [SerializeField]GameObject abilityPanel;
    [SerializeField] Slider slider;

    
    [SerializeField] float prepTime = 4;

    private float pt;
    public Button[] buttons; 
    Ability currentAbility;
    // Start is called before the first frame update
    void Start()
    {
        abilityPanel.SetActive(false);
        SwitchToIdle();
        SetButtons();
        pt = prepTime;
        
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
                    slider.value = (currentAbility.cooldownTime - pt)/currentAbility.cooldownTime * 100;
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
        abilityPanel.SetActive(true);
        
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
        
        state = State.Act;

    }

    public void SetAbility(int  a)
    {
        Debug.Log(a);
        currentAbility = abilities[a];
        SwitchToPrep();
        abilityPanel.SetActive(false);
    }

    void SetButtons()
    {
        for(int i=0;i<buttons.Length;i++)
        {
            
                if (i < abilities.Length)
                {
                    buttons[i].GetComponentInChildren<TMPro.TMP_Text>().text = abilities[i].abilityName;
                  
                }
                else
                {
                    buttons[i].gameObject.SetActive(false);
                }
        }
    }
}
