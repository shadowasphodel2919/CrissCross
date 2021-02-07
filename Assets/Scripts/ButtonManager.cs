using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject m_frontpanel;
    public GameObject m_gamePanel;

    public void Play()
    {
        m_frontpanel.SetActive(false);
        m_gamePanel.SetActive(true);
    }
}
