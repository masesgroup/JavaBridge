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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Synth
{
    #region ISynthIcon
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISynthIcon : Javax.Swing.IIcon
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconHeight()"/> 
        /// </summary>
        int IconHeight { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconWidth()"/> 
        /// </summary>
        int IconWidth { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconHeight(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="int"/></returns>
        int GetIconHeight(Javax.Swing.Plaf.Synth.SynthContext arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconWidth(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="int"/></returns>
        int GetIconWidth(Javax.Swing.Plaf.Synth.SynthContext arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#paintIcon(javax.swing.plaf.synth.SynthContext,java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        void PaintIcon(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#paintIcon(java.awt.Component,java.awt.Graphics,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        void PaintIcon(Java.Awt.Component arg0, Java.Awt.Graphics arg1, int arg2, int arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SynthIcon
    public partial class SynthIcon : Javax.Swing.Plaf.Synth.ISynthIcon
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconHeight()"/> 
        /// </summary>
        public int IconHeight
        {
            get { return IExecuteWithSignature<int>("getIconHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconWidth()"/> 
        /// </summary>
        public int IconWidth
        {
            get { return IExecuteWithSignature<int>("getIconWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconHeight(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIconHeight(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecuteWithSignature<int>("getIconHeight", "(Ljavax/swing/plaf/synth/SynthContext;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#getIconWidth(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIconWidth(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecuteWithSignature<int>("getIconWidth", "(Ljavax/swing/plaf/synth/SynthContext;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#paintIcon(javax.swing.plaf.synth.SynthContext,java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void PaintIcon(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("paintIcon", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthIcon.html#paintIcon(java.awt.Component,java.awt.Graphics,int,int)"/>
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