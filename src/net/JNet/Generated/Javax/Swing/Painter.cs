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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region Painter
    public partial class Painter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Painter.html#paint(java.awt.Graphics2D,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void Paint(Java.Awt.Graphics2D arg0, object arg1, int arg2, int arg3)
        {
            IExecute("paint", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IPainter<T>
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Painter.html"/>
    /// </summary>
    public partial interface IPainter<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Painter.html#paint(java.awt.Graphics2D,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        void Paint(Java.Awt.Graphics2D arg0, T arg1, int arg2, int arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Painter<T>
    public partial class Painter<T> : Javax.Swing.IPainter<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Painter{T}"/> to <see cref="Javax.Swing.Painter"/>
        /// </summary>
        public static implicit operator Javax.Swing.Painter(Javax.Swing.Painter<T> t) => t.Cast<Javax.Swing.Painter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Painter.html#paint(java.awt.Graphics2D,java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void Paint(Java.Awt.Graphics2D arg0, T arg1, int arg2, int arg3)
        {
            IExecute("paint", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}