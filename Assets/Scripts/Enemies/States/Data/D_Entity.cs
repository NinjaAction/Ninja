﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="newEntityData",menuName ="Data/Entity Data/Base Data")]

public class D_Entity : ScriptableObject
{
    public float maxHealth = 30.0f;

    public float damageHopSpeed = 3.0f;

    public float wallCheckDistance = 0.2f;
    public float ledgeCheckDistance = 0.4f;
    public float gruondCheckRadius = 0.3f;

    public float minAgroDistance = 3.0f;
    public float maxAgroDistance = 4.0f;

    public float stunResistance = 3.0f;
    public float stunRecoveryTime = 2.0f;

    public float closeRangeActionDistatnce = 1.0f;

    public GameObject hitParticle;


    public LayerMask whatIsGround;
    public LayerMask whatIsPlayer;
}
