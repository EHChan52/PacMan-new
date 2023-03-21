using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cyan : ghost{
    private string n1,n2,n3;
    private node_control controller;
    private GameObject node;

    protected override void Start(){
        base.Start();
    }

    void Update(){
        if(data.game_active==false){
            return;
        }
        else if(ChangeNode()){
            int pacman_dir=pacman.dir;
            n1=null;n2=null;n3=null;
            
            if(edible){
                Move(Cmp);
            }
            else{
                node=pacman.cur_node;
                target=node.name;
                controller=node.GetComponent<node_control>();
                
                if(pacman_dir>=0&&(node=controller.node_nearby[pacman_dir])!=null){
                    controller=node.GetComponent<node_control>();
                    n1=node.name;
                }
                else{
                    goto Start_search;
                }
                if((node=controller.node_nearby[pacman_dir])!=null){
                    controller=node.GetComponent<node_control>();
                    n2=node.name;
                }
                else{
                    goto Start_search;
                }
                if((node=controller.node_nearby[pacman_dir])!=null){
                    controller=node.GetComponent<node_control>();
                    n3=node.name;
                }
                else{
                    goto Start_search;
                }
                Start_search:
                Move(CyanCmp);
            }
        }
    }
    public bool CyanCmp(string x){
        return x==target||x==n1||x==n2||x==n3;
    }
}
