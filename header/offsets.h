#pragma once
#include <cstdint>
#include <libloaderapi.h>

uintptr_t moduleBase = (uintptr_t)GetModuleHandle("GameAssembly.dll");
uintptr_t unityPlayer = (uintptr_t)GetModuleHandle("UnityPlayer.dll");
//uintptr_t playerListObject0 = mem::FindAddress(unityPlayer + 0x01B48C60, { 0x40, 0x1C0, 0x60, 0x0 });
//uintptr_t playerList = unityPlayer + 0x01B48C60 + 0x40 + 0x1C0 + 0x60;
//uintptr_t playerList = mem::FindAddress(unityPlayer + 0x01B48C60, { 0x40, 0x1C0, 0x60 });
//uintptr_t* playerList = reinterpret_cast<uintptr_t*>(mem::FindAddress(unityPlayer + 0x01B48C60, { 0x40, 0x1C0, 0x60 }));