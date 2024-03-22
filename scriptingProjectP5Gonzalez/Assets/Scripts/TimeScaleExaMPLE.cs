using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleExaMPLE : MonoBehaviour
{
    public AnimationCurve bulletTimeScale;
    bool m_IsUsingBulletTime;
    float m_UnscaledElapsedTime;
    public void StartBullletTime()
    {
        m_UnscaledElapsedTime = 0f;
        m_IsUsingBulletTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IsUsingBulletTime)
        { 
           Time.timeScale = bulletTimeScale.Evaluate(m_UnscaledElapsedTime);
            ;
        }

    }
}
