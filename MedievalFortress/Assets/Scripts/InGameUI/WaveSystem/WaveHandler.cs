using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveHandler : MonoBehaviour
{

    public TMP_Text waveText;

    public Button startWaveButton;

    public int currentWave = 0;

    void Start()
    {
        startWaveButton.interactable = true;
        startWaveButton.onClick.AddListener(StartWave);
    }

    void StartWave()
    {
        currentWave++;
        waveText.text = "WAVE: " + currentWave.ToString();

        // Disable the button to prevent multiple waves from being triggered
        startWaveButton.enabled = false;

        StartCoroutine(WaveDuration(30));
    }

    IEnumerator WaveDuration(float duration)
    {
        // Wait for the duration of the wave
        yield return new WaitForSeconds(duration);

        // Enable the button after the wave is over
        startWaveButton.enabled = true;
    }

    void Update()
    {
        
    }
}
