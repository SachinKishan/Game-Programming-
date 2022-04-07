using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Attack Ability", menuName = "ScriptableObjects/Abilities/Attack Ability", order = 1)]

public class AttackAbility : Ability
{
    [SerializeField] int attack;
    [SerializeField] GameObject particle;
    public override void Activate(UnitBaseClass obj)
    {
        base.Activate();
        obj.RemoveHealth(attack);
        Transform t = obj.gameObject.transform;

        Destroy(Instantiate(particle, t.position, t.rotation),0.5f);
    }
}
