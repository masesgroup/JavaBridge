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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicArrowButton
    public partial class BasicArrowButton
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicArrowButton.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        public BasicArrowButton(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3, Java.Awt.Color arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicArrowButton.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public BasicArrowButton(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicArrowButton"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.Plaf.Basic.BasicArrowButton t) => t.Cast<Javax.Swing.SwingConstants>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicArrowButton.html#getDirection()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicArrowButton.html#setDirection(int)"/>
        /// </summary>
        public int Direction
        {
            get { return IExecuteWithSignature<int>("getDirection", "()I"); } set { IExecuteWithSignature("setDirection", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicArrowButton.html#paintTriangle(java.awt.Graphics,int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public void PaintTriangle(Java.Awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, bool arg5)
        {
            IExecute("paintTriangle", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}