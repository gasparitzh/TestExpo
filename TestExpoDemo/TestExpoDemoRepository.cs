﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TestExpoDemo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the TestExpoDemoRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("d0e0079b-6379-4f58-878e-815af3a51486")]
    public partial class TestExpoDemoRepository : RepoGenBaseFolder
    {
        static TestExpoDemoRepository instance = new TestExpoDemoRepository();

        /// <summary>
        /// Gets the singleton class instance representing the TestExpoDemoRepository element repository.
        /// </summary>
        [RepositoryFolder("d0e0079b-6379-4f58-878e-815af3a51486")]
        public static TestExpoDemoRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public TestExpoDemoRepository() 
            : base("TestExpoDemoRepository", "/", null, 0, false, "d0e0079b-6379-4f58-878e-815af3a51486", ".\\RepositoryImages\\TestExpoDemoRepositoryd0e0079b.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d0e0079b-6379-4f58-878e-815af3a51486")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class TestExpoDemoRepositoryFolders
    {
    }
#pragma warning restore 0436
}