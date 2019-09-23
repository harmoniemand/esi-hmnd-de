#pragma once

#include <Arduino.h>
#include "lmic.h"

/////////////////////////////////
// The Things Network
/////////////////////////////////

// Device Address
static const u4_t DEVADDR = 0x26012F16;

// Network Session Key
static const PROGMEM u1_t NWKSKEY[16] = { 0xD4, 0x8E, 0x95, 0x57, 0xF8, 0x9A, 0xDE, 0x18, 0x70, 0x4F, 0x13, 0xB7, 0xA1, 0xF9, 0x2B, 0xFD };

// App Session Key
static const u1_t PROGMEM APPSKEY[16] = { 0x70, 0x26, 0xFD, 0xC6, 0x9C, 0x48, 0x70, 0x40, 0x88, 0x47, 0x94, 0x96, 0x0E, 0x40, 0x63, 0x38 };