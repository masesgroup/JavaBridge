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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf
{
    #region IconUIResource
    public partial class IconUIResource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/IconUIResource.html#%3Cinit%3E(javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        public IconUIResource(Javax.Swing.Icon arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.IconUIResource"/> to <see cref="Javax.Swing.Icon"/>
        /// </summary>
        public static implicit operator Javax.Swing.Icon(Javax.Swing.Plaf.IconUIResource t) => t.Cast<Javax.Swing.Icon>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.IconUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
        /// </summary>
        public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.IconUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.IconUIResource"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Plaf.IconUIResource t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/IconUIResource.html#getIconHeight()"/> 
        /// </summary>
        public int IconHeight
        {
            get { return IExecuteWithSignature<int>("getIconHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/IconUIResource.html#getIconWidth()"/> 
        /// </summary>
        public int IconWidth
        {
            get { return IExecuteWithSignature<int>("getIconWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/IconUIResource.html#paintIcon(java.awt.Component,java.awt.Graphics,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void PaintIcon(Java.Awt.Component arg0, Java.Awt.Graphics arg1, int arg2, int arg3)
        {
            IExecute("paintIcon", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}