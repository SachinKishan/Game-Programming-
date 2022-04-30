using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Heal Ability", menuName = "ScriptableObjects/Abilities/Heal Ability", order = 1)]

public class HealAbility : Ability
{
    [SerializeField] int heal;
    [SerializeField] GameObject particle;
    public override void Activate(UnitBaseClass obj)
    {
        base.Activate();
        Player[] p=FindObjectsOfType<Player>();
        Player min=null;
        for(int i=0;i<p.Length;i++)
        {
            if (min == null || p[i].currentHealth < min.health) min = p[i];
        }
        min.RemoveHealth(-heal);
        Instantiate(particle, min.gameObject.transform.position, min.gameObject.transform.rotation);
    }
}
