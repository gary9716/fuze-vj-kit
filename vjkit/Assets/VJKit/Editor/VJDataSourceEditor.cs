﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using System;
using System.Collections.Generic;

[CustomEditor(typeof(VJDataSource))]
public class VJDataSourceEditor : VJAbstractDataSourceEditor 
{

    public VJDataSourceEditor()
    {
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }
}
