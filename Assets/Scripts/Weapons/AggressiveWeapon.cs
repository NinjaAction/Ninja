using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AggressiveWeapon : Weapon
{
    private Movement Movement { get => movement ?? core.GetCoreComponent(ref movement); }   

    private Movement movement;
    
    protected SO_AgressiveWeaponData agressiveWeaponData;

    private List<IDamageable> detectedDamageables = new List<IDamageable>();
    private List<IKnockbackable> detectedKnockbackables = new List<IKnockbackable>();


    protected override void Awake()
    {
        base.Awake();

        if (weaponData.GetType() == typeof(SO_AgressiveWeaponData))
        {
            agressiveWeaponData = (SO_AgressiveWeaponData)weaponData;
        }
        else
        {
            Debug.LogError("Wrong data for the weapon");
        }
    }


    public override void AnimationActionTrigger()
    {
        base.AnimationActionTrigger();
        CheckMeleeAttack();
    }

    public void AddToDetected(Collider2D collision)
    {
        

        IDamageable damageble = collision.GetComponent<IDamageable>();

        if (damageble != null)
        {
            
            detectedDamageables.Add(damageble);
        }


        IKnockbackable knockbackable = collision.GetComponent<IKnockbackable>();

        if (knockbackable != null)
        {
            detectedKnockbackables.Add(knockbackable);
        }
    }

    private void CheckMeleeAttack()
    {
        WeaponAttackDetails details = agressiveWeaponData.AttackDetails[attackCounter];

        foreach(IDamageable item in detectedDamageables.ToList())
        {
            item.Damege(details.damageAmount);
        }

        foreach(IKnockbackable item in detectedDamageables.ToList())
        {
            item.Knockback(details.knockbackAngle, details.knockbackStrenght, Movement.FacingDirection);
        }
    }



   

    public void RemoveFromDetected(Collider2D collision)
    {
        

        IDamageable damageble = collision.GetComponent<IDamageable>();

        if (damageble != null)
        {
            

            detectedDamageables.Remove(damageble);
        }

        IKnockbackable knockbackable = collision.GetComponent<IKnockbackable>();

        if (knockbackable != null)
        {
            detectedKnockbackables.Remove(knockbackable);
        }
    }
}
