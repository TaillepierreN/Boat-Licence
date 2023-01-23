using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer _am;
    [SerializeField] Slider _bgmSlider;
    [SerializeField] Slider _sfxSlider;

    // Update is called once per frame
    void Update()
    {
        float sfxFloat = _sfxSlider.value;
        _am.SetFloat("SFX",Mathf.Log10(sfxFloat)*20);
        float bgmFloat = _bgmSlider.value;
        _am.SetFloat("BGM",Mathf.Log10(bgmFloat)*20);
    }

}
