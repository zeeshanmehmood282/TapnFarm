using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hypertonic.GridPlacement;

public class Grid_Manger : MonoBehaviour
{
    [SerializeField]
    private GridSettings _gridSettings;
    [SerializeField]
    private GameObject _gridObjectPrefab;
    private GridManager _gridManager;


    private void OnGUI(){
        if (GUI.Button(new Rect(10,10,150,50),"Confirm Placement"))
            ConfirmPlacement();
        if (GUI.Button(new Rect(10,70,150,50),"Enter Placement Mode"))
            EnterPlacementMode();    
    }
    void Start()
    {
      _gridManager = new GameObject("Grid Manager").AddComponent<GridManager>();
      _gridManager.Setup(_gridSettings);   
    }
    

    private void EnterPlacementMode(){
        GameObject gridObject = Instantiate(_gridObjectPrefab);
        _gridManager.EnterPlacementMode(gridObject);
    }


    private void  ConfirmPlacement(){
        _gridManager.ConfirmPlacement();
    }
}
