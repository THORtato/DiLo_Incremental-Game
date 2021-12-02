using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapText : MonoBehaviour
{
    public float SpawnTime = .5f;
    public Text Text;

    private float _SpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        _SpawnTime = SpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        _SpawnTime -= Time.unscaledDeltaTime;
        if(_SpawnTime <= 0f)
        {
            gameObject.SetActive(false);
        }
        else
        {
            Text.CrossFadeAlpha(0f, .5f, false);
            if(Text.color.a == 0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
