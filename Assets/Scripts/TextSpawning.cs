using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TextSpawning : MonoBehaviour

{
    Text _text;
    TMP_Text _tmProtext;
    string writer;

    [SerializeField] float atraso = 0f;
    [SerializeField] float tempoEntre = 0.1f;
    [SerializeField] string iconComeco = "";
    [SerializeField] bool iconComecoAntesComeco = false;
    
    void Start()
    {
        _text = GetComponent<Text>()!;
        _tmProtext = GetComponent<TMP_Text>()!;

        if(_text != null)
        {
            writer = _text.text;
            _text.text = "";

            StartCoroutine("MaquinaTexto");
        }
        if(_tmProtext != null)
        {
            writer = _tmProtext.text;
            _tmProtext.text = "";

            StartCoroutine("MaquinaTMP");
        }
    }

    IEnumerator MaquinaTexto()
    {
        _text.text = iconComecoAntesComeco ? iconComeco : "" ;

        yield return new WaitForSeconds(atraso);

        foreach(char c in writer)
        {
            if(_text.text.Length > 0)
            {
                _text.text = _text.text.Substring(0, _text.text.Length - iconComeco.Length);
            }
            _text.text += c;
            _text.text += iconComeco;
            yield return new WaitForSeconds(tempoEntre);
        }
        if(iconComeco != "")
        {
            _text.text = _text.text.Substring(0,_text.text.Length - iconComeco.Length);
        }
    }

    IEnumerator MaquinaTMP()
    {
        _tmProtext.text = iconComecoAntesComeco ? iconComeco : "";
        yield return new WaitForSeconds(atraso);

        foreach (char c in writer)
        {
            if(_tmProtext.text.Length > 0)
            {
                _tmProtext.text = _tmProtext.text.Substring(0, _tmProtext.text.Length - iconComeco.Length);
            }

            _tmProtext.text += c;
            _tmProtext.text += iconComeco;
            yield return new WaitForSeconds(tempoEntre);
        }
        if(iconComeco != "")
        {
            _tmProtext.text = _tmProtext.text.Substring(0, _tmProtext.text.Length - iconComeco.Length);
        }
    }
}
