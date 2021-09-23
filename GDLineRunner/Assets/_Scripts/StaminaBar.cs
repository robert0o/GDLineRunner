using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaBar : MonoBehaviour
{
    int maxStamina = 1000;
    private int _currentStamina;
    public int CurrentStamina
    {
        get => _currentStamina;
        set 
        {
            _currentStamina = value;
            VisualizeStamina();
        }
    }
    float baseY;
    float baseScale;
    RectTransform recTrans;
    

    [Header("Testing Variable")]
    [Range(10, 100)]
    public int StaminaChange;
    public KeyCode increase;
    public KeyCode decrease;

    private void Awake()
    {
        recTrans = GetComponent<RectTransform>();
        baseY = recTrans.sizeDelta.y;
        baseScale = recTrans.rect.height;
        ResetStamina();
    }
    private void VisualizeStamina()
    {
        float percentage = (float)CurrentStamina / (float)maxStamina;
        float newScale = baseScale * percentage;
        float newY = newScale/2 + 5;
        recTrans.anchoredPosition = new Vector3(-30, newY, 0);
        recTrans.sizeDelta = new Vector2( recTrans.sizeDelta.x, newScale);
        
        //Debug.Log("newy: " + newScale);
    }

    public void ResetStamina()
    {
        CurrentStamina = maxStamina;
    }
    public void DecreaseStamina(int pointsLost)
    {
        CurrentStamina = Mathf.Clamp(CurrentStamina - pointsLost,0,maxStamina);
    }

    public void RecoverStamina(int pointsRegaind)
    {
        CurrentStamina = Mathf.Clamp(CurrentStamina + pointsRegaind, 0, maxStamina);
    }

    public void Update()
    {
        if (Input.GetKeyDown(increase))
        {
            RecoverStamina(StaminaChange);
        }
        if (Input.GetKeyDown(decrease))
        {
            DecreaseStamina(StaminaChange);
        }
    }



}
