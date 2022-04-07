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
    [SerializeField] Slider actionSlider;
    [SerializeField] Slider healthSlider;

    
    [SerializeField] float prepTime = 4;

    private float pt;
    public Button[] buttons; 
    Ability currentAbility;
    Animator a;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        UpdateHealthBar();

        a = GetComponent<Animator>();
        abilityPanel.SetActive(true);
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
                    actionSlider.value = (currentAbility.cooldownTime - pt)/currentAbility.cooldownTime * 100;
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
        //abilityPanel.SetActive(true);
        
        state = State.Idle;
        //Debug.Log("IDLE");
    }

    public void SwitchToPrep()
    {
       
        pt = currentAbility.cooldownTime;
        //Debug.Log("PREP");
        if (currentAbility.type == AbilityType.magic) a.SetTrigger("casting");
        else if (currentAbility.type == AbilityType.skill) a.SetTrigger("prep");
        state = State.Prep;
    }

    public void SwitchToAct()
    {
        //Debug.Log("ACT");
       
        if (currentAbility.type == AbilityType.magic) a.SetTrigger("cast");
        else if (currentAbility.type == AbilityType.skill) a.SetTrigger("act");
        state = State.Act;

    }

    public void GetPanel()
    {
        abilityPanel.SetActive(true);
    }

    public void SetAbility(int  a)
    {
        //Debug.Log(a);
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

    public override void RemoveHealth(int h)
    {
        base.RemoveHealth(h);
        if(currentHealth<=0)
        {
            currentHealth = 0;
            BattleInformationHolder.main.SubtractPlayer();
        }
        UpdateHealthBar();

    }

    public void ActivateAbility()
    {
        currentAbility.Activate(BattleInformationHolder.main.target);
    }

    void UpdateHealthBar()
    {
        healthSlider.value = (int)(((float)currentHealth / (float)health) * 100);
    }
}
