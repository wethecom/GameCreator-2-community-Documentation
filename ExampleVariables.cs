using System;
using System.Threading.Tasks;
using GameCreator.Runtime.Characters;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using GameCreator.Runtime.VisualScripting;
using Unity.VisualScripting;
using UnityEngine;

[Version(1, 0, 1)]
[Title("Example Variables")]
[Description("Demonstrates retrieving various types of variables from local and global scopes in Game Creator 2.")]
[Category("Variables/Example Variables")]
[Keywords("Local", "Global", "Variables", "Retrieve", "GameObject", "Vector3", "Boolean")]

[Serializable]
public class ExampleVariables : Instruction
{
    [SerializeField] private TimeMode m_TimeMode = new TimeMode(TimeMode.UpdateMode.GameTime);
    [SerializeField] private PropertyGetDecimal m_Interval = new PropertyGetDecimal(1f);
    
    [SerializeField] private LocalNameVariables localVariables;
    [SerializeField] private GlobalNameVariables globalVariables;
    [SerializeField] private PropertyGetRotation direction = new PropertyGetRotation();
    [SerializeField] private ForceMode forceMode = ForceMode.Impulse;
    [SerializeField] private PropertySetWeapon setWeapon = SetWeaponNone.Create;
    [SerializeField] private PropertyGetWeapon weapon = new PropertyGetWeapon();
    [SerializeField] private PropertyGetGameObject gameObjectA = new PropertyGetGameObject();

    [SerializeField] private string distanceVariableName = "distance";
    [SerializeField] private LocalNameVariables localDistanceVariable;

    protected override Task Run(Args args)
    {
 private double m_NextInterval = double.MinValue;

     this.m_NextInterval = this.m_TimeMode.Time + this.m_Interval.Get(args);
        // Retrieve different types of variables from local scope
        GameObject localGameObject = (GameObject)localVariables.Get("localGameObject");
        Vector3 localPosition = (Vector3)localVariables.Get("localPosition");
        bool localFlag = (bool)localVariables.Get("localFlag");

        // Retrieve different types of variables from global scope
        GameObject globalGameObject = (GameObject)globalVariables.Get("globalGameObject");
        Vector3 globalPosition = (Vector3)globalVariables.Get("globalPosition");
        bool globalFlag = (bool)globalVariables.Get("globalFlag");

        IWeapon currentWeapon = weapon.Get(args);
        if (currentWeapon == null) return DefaultResult;
        setWeapon.Set(currentWeapon, args);

        Transform transformA = gameObjectA.Get(args)?.transform;
        localDistanceVariable.Set(distanceVariableName, 1f);

        // Your code here...
        // Example: You can use these variables to control game logic, manipulate objects, etc.

        return DefaultResult;
    }
}
