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
    [SerializeField] private LocalNameVariables m_Set;
    [SerializeField] private GlobalNameVariables m_Set2;
    [SerializeField] private PropertyGetRotation m_Direction = new PropertyGetRotation();
    [SerializeField] private ForceMode m_ForceMode = ForceMode.Impulse;
    [SerializeField] private PropertySetWeapon m_To = SetWeaponNone.Create;
    [SerializeField] private PropertyGetWeapon m_Weapon = new PropertyGetWeapon();
    [SerializeField] private PropertyGetGameObject m_TransformA = new PropertyGetGameObject();

    [SerializeField] private string m_VariableName = "distance";
    [SerializeField] private LocalNameVariables m_LocalVariable; // Reference to a Variable
    protected override Task Run(Args args)
    {
        // Retrieve different types of variables from local scope
        GameObject gO = (GameObject)m_Set.Get("localGameObject");
        Vector3 v3 = (Vector3)m_Set.Get("localPosition");
        bool Bool = (bool)m_Set.Get("localFlag");

        // Retrieve different types of variables from global scope
        GameObject gO2 = (GameObject)m_Set2.Get("globalGameObject");
        Vector3 v32 = (Vector3)m_Set2.Get("globalPosition");
        bool Bool2 = (bool)m_Set2.Get("globalFlag");

        IWeapon weapon = this.m_Weapon.Get(args);
        if (weapon == null) return DefaultResult;
        this.m_To.Set(weapon, args);
        Transform transformA = m_TransformA.Get(args)?.transform;
        m_LocalVariable.Set(m_VariableName.ToString(), 1f);

        // Your code here...
        // Example: You can use these variables to control game logic, manipulate objects, etc.

        return DefaultResult;
    }
}
