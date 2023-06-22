/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region FileDialog
    public partial class FileDialog
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public FileDialog(Java.Awt.Dialog arg0, string arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public FileDialog(Java.Awt.Dialog arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Dialog)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        public FileDialog(Java.Awt.Dialog arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public FileDialog(Java.Awt.Frame arg0, string arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public FileDialog(Java.Awt.Frame arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Frame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        public FileDialog(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#LOAD"/>
        /// </summary>
        public static int LOAD { get { return SGetField<int>(LocalBridgeClazz, "LOAD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#SAVE"/>
        /// </summary>
        public static int SAVE { get { return SGetField<int>(LocalBridgeClazz, "SAVE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setDirectory(java.lang.String)"/>
        /// </summary>
        public string Directory
        {
            get { return IExecute<string>("getDirectory"); } set { IExecute("setDirectory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFile()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setFile(java.lang.String)"/>
        /// </summary>
        public string File
        {
            get { return IExecute<string>("getFile"); } set { IExecute("setFile", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFilenameFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setFilenameFilter(java.io.FilenameFilter)"/>
        /// </summary>
        public Java.Io.FilenameFilter FilenameFilter
        {
            get { return IExecute<Java.Io.FilenameFilter>("getFilenameFilter"); } set { IExecute("setFilenameFilter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFiles()"/> 
        /// </summary>
        public Java.Io.File[] Files
        {
            get { return IExecuteArray<Java.Io.File>("getFiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setMode(int)"/>
        /// </summary>
        public int Mode
        {
            get { return IExecute<int>("getMode"); } set { IExecute("setMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#isMultipleMode()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMultipleMode()
        {
            return IExecute<bool>("isMultipleMode");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setMultipleMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMultipleMode(bool arg0)
        {
            IExecute("setMultipleMode", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}