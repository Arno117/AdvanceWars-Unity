﻿using UnityEngine;
public class CellTerrain : MonoBehaviour {
    [SerializeField]
    private Manager.Type type;
    [SerializeField]
    int def;
    [SerializeField]
    private Transform posSelect;
    private Transform select;
    void Awake()
    {
        select = GameObject.Find("Select").transform;
        posSelect = transform.GetChild(0).GetComponent<Transform>();
    }
    public void OnMouseEnter()
    {
        select.transform.position = posSelect.position;
    }
    public void ShowInfo()
    {

    }
}
