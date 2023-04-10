using System.Collections.Generic;
using UnityEngine;

public interface Imain_manager{
    void Quit();//button
    void SelectMap();//button
    void ReturnTitle();//button
    void UnLoadAllCanvas();//button+game_manager
    void LogOff();//button
    void HelpPage();//button
    void LoadMap();//button+game_manager
    void ClearData();//button

    int GetHighestScores(int mapIndex);//game_manager
    void SaveScoreAndLive(int mapIndex,int scores,int lives);//game_manager
}


public interface Igame_manager{
    void EatPellet();//pacman
    bool EatPacman();//pacman
    void EatGhost();//pacman
    void EatEnergizer(GameObject node);//pacman
}


public interface Ipacman_control{
    void LevelUp();//game_manager
}


public interface Ighost{
    void LevelUp();//game_manager
    bool BeingEaten();//pacman
    void SetEdible();//gama_manager
    void UnsetEdible();//game_manager
}

