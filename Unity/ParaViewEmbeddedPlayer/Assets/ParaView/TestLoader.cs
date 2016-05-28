﻿namespace ParaUnity
{
	using UnityEngine;
	using X3D;
    using System;
	using System.Collections.Generic;

	public class TestLoader : MonoBehaviour
	{

		public GameObject meshNode;
		public Material defaultMaterial;

		// Use this for initialization
		void Start ()
		{
			string path = getTestX2DFile("paraview_tutorial_data/disk_out_ref/disk_out_ref.x3d");
			Loader.ImportMesh (path, meshNode, defaultMaterial);
		}

        private string getTestX2DFile(string testFile)
        {
            return Environment.CurrentDirectory + "/../../TestMaterials/" + testFile;
        }
    }
}