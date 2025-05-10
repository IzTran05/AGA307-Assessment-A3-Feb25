using Unity.VisualScripting;
using UnityEngine;

public class DayNightCycle : GameBehaviour
{
    // Trigger Victory Screen after light cycle finishes
    public void LightCycle()
    {
        _GM.GameVictory();
    }


}
