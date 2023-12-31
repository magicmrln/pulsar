#pragma once
namespace globals {
    /*
    int tab;
    static float hrecoil;
    static float vrecoil;
    static float spread;
    static int ammo;
    static bool nw;
    bool loopActive = false;
    bool show = true;
    */
    bool clientRunning = true;

    //gui
    bool inGui = true;
    bool guiToggleCheck = true;

    bool joinDelayCheck = true;

    float playerListPositions[10][3] = {{}};

    //features
    bool smg_bullets = false;
    bool player_list = false;
    bool crosshair = false;

    //overlay
    bool overlay = false;
}