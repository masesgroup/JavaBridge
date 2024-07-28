/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Filechooser
{
    #region FileView
    public partial class FileView
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileView.html#isTraversable(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean IsTraversable(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("isTraversable", "(Ljava/io/File;)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileView.html#getDescription(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDescription(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getDescription", "(Ljava/io/File;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileView.html#getName(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetName(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getName", "(Ljava/io/File;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileView.html#getTypeDescription(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTypeDescription(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getTypeDescription", "(Ljava/io/File;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/filechooser/FileView.html#getIcon(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetIcon(Java.Io.File arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Icon>("getIcon", "(Ljava/io/File;)Ljavax/swing/Icon;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}