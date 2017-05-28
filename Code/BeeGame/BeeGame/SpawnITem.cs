﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BeeGame.Items;
using BeeGame.Blocks;
using BeeGame.Core.Enums;

namespace BeeGame
{
    class SpawnItem : MonoBehaviour
    {
        void Start()
        {
            GameObject go = Instantiate(UnityEngine.Resources.Load("Prefabs/ItemGameObject") as GameObject, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<ItemGameObject>().item = new Bee(BeeType.DRONE, new NormalBee() { pSpecies = BeeSpecies.FOREST});

            go = Instantiate(UnityEngine.Resources.Load("Prefabs/ItemGameObject") as GameObject, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<ItemGameObject>().item = new Bee(BeeType.PRINCESS, new NormalBee() { pSpecies = BeeSpecies.FOREST });

            go = Instantiate(UnityEngine.Resources.Load("Prefabs/ItemGameObject") as GameObject, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<ItemGameObject>().item = new Bee(BeeType.QUEEN, new QueenBee() { queen = new NormalBee() { pSpecies = BeeSpecies.FOREST }, drone = new NormalBee() });
            
            go = Instantiate(UnityEngine.Resources.Load("Prefabs/ItemGameObject") as GameObject, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<ItemGameObject>().item = new HoneyComb(HoneyCombType.ICEY);
            
            go = Instantiate(UnityEngine.Resources.Load("Prefabs/ItemGameObject") as GameObject, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<ItemGameObject>().item = new HoneyComb(HoneyCombType.HONEY);


            go = Instantiate(UnityEngine.Resources.Load("Prefabs/ItemGameObject") as GameObject, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<ItemGameObject>().item = new Chest();
            go = Instantiate(UnityEngine.Resources.Load("Prefabs/ItemGameObject") as GameObject, transform.position, Quaternion.identity) as GameObject;
            go.GetComponent<ItemGameObject>().item = new Chest();

        }

        private void OnDrawGizmos()
        {
            //Gizmos.color = Color.green;
            //Gizmos.DrawSphere(transform.position, 0.5f);
        }
    }
}