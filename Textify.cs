﻿namespace SecTool
{
    internal class Textify
    {
        static Dictionary<int, string> ClauseOpNameMap = new Dictionary<int, string>{
            {0x00, "INVALID"},
            {0x01, "INVALID"},
            {0x02, "INVALID"},
            {0x03, "INVALID"},
            {0x04, "INVALID"},
            {0x05, "INVALID"},
            {0x06, "INVALID"},
            {0x07, "INVALID"},
            {0x08, "Jmp"},
            {0x09, "JmpOffset"},
            {0x0A, "Ret"},
            {0x0B, "CondJmp"},
            {0x0C, "CondJmpOffset"},
            {0x0D, "CondJmpStack"},
            {0x0E, "Call"},
            {0x0F, "CallOffset"},
            {0x10, "CallStack"},
            {0x11, "Ret"},
            {0x12, "PushOffset"},//TypeID = 6
            {0x13, "PushInt8"},//TypeID = 0
            {0x14, "PushInt16"},//TypeID = 0
            {0x15, "PushDWord"},//TypeID = 0
            {0x16, "PushQWord"},//TypeID = 1
            {0x17, "PushUInt8"},//TypeID = 0
            {0x18, "PushUInt16"},//TypeID = 0
            {0x19, "PushDWord"},//TypeID = 0
            {0x1A, "PushQWord"},//TypeID = 1
            {0x1B, "PushFloat"},//TypeID = 2
            {0x1C, "PushDouble"},//TypeID = 3
            {0x1D, "PushVariable"},//TypeID = 4
            {0x1E, "PushVariableArray"},//TypeID = 4 (int typeIndex, int elemCount)
            {0x1F, "INVALID"},
            {0x20, "PushEmptyVariable"},//TypeID = 4
            {0x21, "VariableCast"},//TypeID 4 -> 4
            {0x22, "INVALID"},
            {0x23, "VariableToRef"},//TypeID 4 -> 5
            {0x24, "CastVariablePop0"},
            {0x25, "CastVariablePop1"},
            {0x26, "CastArrayVariablePop0"},
            {0x27, "INVALID"},
            {0x28, "PushNullTypeVariable"},//TypeID = 4
            {0x29, "PushPresetObj"},//TypeID = 4
            {0x2A, "PushPresetObjRef"},//TypeID = 5
            {0x2B, "INVALID"},
            {0x2C, "INVALID"},
            {0x2D, "INVALID"},
            {0x2E, "INVALID"},
            {0x2F, "INVALID"},
            {0x30, "VariableRefCast0"},//TypeID 5 -> 0 PrimitiveTypeId = 0
            {0x31, "VariableRefCast1"},//TypeID 5 -> 0 PrimitiveTypeId = 1
            {0x32, "VariableRefCast2"},//TypeID 5 -> 0 PrimitiveTypeId = 2
            {0x33, "VariableRefCast3"},//TypeID 5 -> 0 PrimitiveTypeId = 3
            {0x34, "VariableRefCast00"},//TypeID 5 -> 0 PrimitiveTypeId = 0
            {0x35, "VariableRefCast10"},
            {0x36, "VariableRefCast2"},
            {0x37, "VariableRefCast3"},
            {0x38, "VariableRefCast4"},
            {0x39, "VariableRefCast5"},
            {0x3A, "VariableRefCast6"},
            {0x3B, "VariableRefCast7"},
            {0x3C, "sub_59AE30"},
            {0x3D, "sub_59AEE0"},
            {0x3E, "sub_59AF90"},
            {0x3F, "sub_59B040"},
            {0x40, "sub_59B0F0"},
            {0x41, "sub_59B1A0"},
            {0x42, "sub_59B250"},
            {0x43, "sub_59B310"},
            {0x44, "sub_596960"},
            {0x45, "INVALID"},
            {0x46, "INVALID"},
            {0x47, "INVALID"},
            {0x48, "INVALID"},
            {0x49, "INVALID"},
            {0x4A, "INVALID"},
            {0x4B, "INVALID"},
            {0x4C, "INVALID"},
            {0x4D, "INVALID"},
            {0x4E, "INVALID"},
            {0x4F, "INVALID"},
            {0x50, "Cmp_Eq"},
            {0x51, "sub_597CD0"},
            {0x52, "Pop"},
            {0x53, "PopRange"},
            {0x54, "PushBool"},
            {0x55, "PushBoolRange"},
            {0x56, "PushLocalFrame"},
            {0x57, "PopLocalFrame"},
            {0x58, "sub_59B540"},
            {0x59, "INVALID"},
            {0x5A, "INVALID"},
            {0x5B, "INVALID"},
            {0x5C, "INVALID"},
            {0x5D, "INVALID"},
            {0x5E, "INVALID"},
            {0x5F, "INVALID"},
            {0x60, "INVALID"},
            {0x61, "INVALID"},
            {0x62, "INVALID"},
            {0x63, "INVALID"},
            {0x64, "INVALID"},
            {0x65, "INVALID"},
            {0x66, "INVALID"},
            {0x67, "INVALID"},
            {0x68, "INVALID"},
            {0x69, "INVALID"},
            {0x6A, "INVALID"},
            {0x6B, "INVALID"},
            {0x6C, "INVALID"},
            {0x6D, "INVALID"},
            {0x6E, "INVALID"},
            {0x6F, "INVALID"},
            {0x70, "PushAddr"},//TypeID = 6
            {0x71, "INVALID"},
            {0x72, "INVALID"},
            {0x73, "INVALID"},
            {0x74, "INVALID"},
            {0x75, "INVALID"},
            {0x76, "INVALID"},
            {0x77, "INVALID"},
            {0x78, "INVALID"},
            {0x79, "INVALID"},
            {0x7A, "INVALID"},
            {0x7B, "INVALID"},
            {0x7C, "INVALID"},
            {0x7D, "INVALID"},
            {0x7E, "INVALID"},
            {0x7F, "INVALID"},
            {0x80, "INVALID"},
            {0x81, "INVALID"},
            {0x82, "INVALID"},
            {0x83, "INVALID"},
            {0x84, "INVALID"},
            {0x85, "INVALID"},
            {0x86, "INVALID"},
            {0x87, "INVALID"},
            {0x88, "INVALID"},
            {0x89, "INVALID"},
            {0x8A, "INVALID"},
            {0x8B, "INVALID"},
            {0x8C, "INVALID"},
            {0x8D, "INVALID"},
            {0x8E, "INVALID"},
            {0x8F, "INVALID"},
            {0x90, "INVALID"},
            {0x91, "INVALID"},
            {0x92, "INVALID"},
            {0x93, "INVALID"},
            {0x94, "INVALID"},
            {0x95, "INVALID"},
            {0x96, "INVALID"},
            {0x97, "INVALID"},
            {0x98, "INVALID"},
            {0x99, "INVALID"},
            {0x9A, "INVALID"},
            {0x9B, "INVALID"},
            {0x9C, "INVALID"},
            {0x9D, "INVALID"},
            {0x9E, "INVALID"},
            {0x9F, "INVALID"},
            {0xA0, "INVALID"},
            {0xA1, "INVALID"},
            {0xA2, "INVALID"},
            {0xA3, "INVALID"},
            {0xA4, "INVALID"},
            {0xA5, "INVALID"},
            {0xA6, "INVALID"},
            {0xA7, "INVALID"},
            {0xA8, "INVALID"},
            {0xA9, "INVALID"},
            {0xAA, "INVALID"},
            {0xAB, "INVALID"},
            {0xAC, "INVALID"},
            {0xAD, "INVALID"},
            {0xAE, "INVALID"},
            {0xAF, "INVALID"},
            {0xB0, "INVALID"},
            {0xB1, "INVALID"},
            {0xB2, "INVALID"},
            {0xB3, "INVALID"},
            {0xB4, "INVALID"},
            {0xB5, "INVALID"},
            {0xB6, "INVALID"},
            {0xB7, "INVALID"},
            {0xB8, "INVALID"},
            {0xB9, "INVALID"},
            {0xBA, "INVALID"},
            {0xBB, "INVALID"},
            {0xBC, "INVALID"},
            {0xBD, "INVALID"},
            {0xBE, "INVALID"},
            {0xBF, "INVALID"},
            {0xC0, "INVALID"},
            {0xC1, "INVALID"},
            {0xC2, "INVALID"},
            {0xC3, "INVALID"},
            {0xC4, "INVALID"},
            {0xC5, "INVALID"},
            {0xC6, "INVALID"},
            {0xC7, "INVALID"},
            {0xC8, "INVALID"},
            {0xC9, "INVALID"},
            {0xCA, "INVALID"},
            {0xCB, "INVALID"},
            {0xCC, "INVALID"},
            {0xCD, "INVALID"},
            {0xCE, "INVALID"},
            {0xCF, "INVALID"},
            {0xD0, "INVALID"},
            {0xD1, "INVALID"},
            {0xD2, "INVALID"},
            {0xD3, "INVALID"},
            {0xD4, "INVALID"},
            {0xD5, "INVALID"},
            {0xD6, "INVALID"},
            {0xD7, "INVALID"},
            {0xD8, "INVALID"},
            {0xD9, "INVALID"},
            {0xDA, "INVALID"},
            {0xDB, "INVALID"},
            {0xDC, "INVALID"},
            {0xDD, "INVALID"},
            {0xDE, "INVALID"},
            {0xDF, "INVALID"},
            {0xE0, "INVALID"},
            {0xE1, "INVALID"},
            {0xE2, "INVALID"},
            {0xE3, "INVALID"},
            {0xE4, "INVALID"},
            {0xE5, "sub_5A1090"},
            {0xE6, "INVALID"},
            {0xE7, "INVALID"},
            {0xE8, "INVALID"},
            {0xE9, "INVALID"},
            {0xEA, "INVALID"},
            {0xEB, "INVALID"},
            {0xEC, "INVALID"},
            {0xED, "INVALID"},
            {0xEE, "INVALID"},
            {0xEF, "INVALID"},
            {0xF0, "INVALID"},
            {0xF1, "INVALID"},
            {0xF2, "INVALID"},
            {0xF3, "INVALID"},
            {0xF4, "INVALID"},
            {0xF5, "INVALID"},
            {0xF6, "INVALID"},
            {0xF7, "INVALID"},
            {0xF8, "INVALID"},
            {0xF9, "INVALID"},
            {0xFA, "INVALID"},
            {0xFB, "INVALID"},
            {0xFC, "INVALID"},
            {0xFD, "INVALID"},
            {0xFE, "NativeCall"},
            {0xFF, "END"},
        };
    }
}
