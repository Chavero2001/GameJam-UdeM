using UnityEngine;

public class SkillData
{
    public float value;
    public bool[] flags = new bool[4];
    public SkillData(float value)
    {
        this.value = value;
    }
}
