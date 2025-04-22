 using UnityEngine;

public class FPSLimiter : MonoBehaviour

{

public int FPS = 30;

void Start()

{

QualitySettings.vSyncCount = 0;

Application.targetFrameRate = FPS;

}

} 