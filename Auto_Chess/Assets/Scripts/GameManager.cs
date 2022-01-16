using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{

    public Transform team1Parent;
    public Transform team2Parent;
    private Dictionary<BaseEntity,Pos> playersTeamPosition = new Dictionary<BaseEntity,Pos>();
    private Dictionary<BaseEntity,Pos> opponentsTeamPosition = new Dictionary<BaseEntity,Pos>();

    void Start() {

        // Create the 2 teams.
        InstantiateUnits();
    }

    private void InstantiateUnits(EntitiesDatabaseSO.EntityData entityData) {
        BaseEntity newEntity = Instantiate(entityData.prefab, team1Parent);
        
    }
    
}
