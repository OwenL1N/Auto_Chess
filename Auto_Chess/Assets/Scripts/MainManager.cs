using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainManager : Manager<MainManager> {

    public EntitiesDatabaseSO entitiesDatabase;
    public Transform team1Parent;
    public Transform team2Parent;
    private Dictionary<BaseEntity,Pos> playersTeamPosition = new Dictionary<BaseEntity,Pos>();
    private Dictionary<BaseEntity,Pos> opponentsTeamPosition = new Dictionary<BaseEntity,Pos>();

    void Start() {
        // Create the 2 teams.
        // InstantiateUnits();
    }

    public void InstantiateUnits() {
        EntitiesDatabaseSO.EntityData entityData = entitiesDatabase.allEntities[0];
        BaseEntity newEntity = Instantiate(entityData.prefab, team1Parent);
        playersTeamPosition.Add(newEntity,new Pos(1,1));
        print("click");
    }
}

