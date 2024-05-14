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

namespace Javax.Swing
{
    #region DefaultListCellRenderer
    public partial class DefaultListCellRenderer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultListCellRenderer"/> to <see cref="Javax.Swing.ListCellRenderer"/>
        /// </summary>
        public static implicit operator Javax.Swing.ListCellRenderer(Javax.Swing.DefaultListCellRenderer t) => t.Cast<Javax.Swing.ListCellRenderer>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultListCellRenderer"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.DefaultListCellRenderer t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultListCellRenderer.html#getListCellRendererComponent(javax.swing.JList,java.lang.Object,int,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JList"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetListCellRendererComponent(Javax.Swing.JList<object> arg0, object arg1, int arg2, bool arg3, bool arg4)
        {
            return IExecute<Java.Awt.Component>("getListCellRendererComponent", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region UIResource
        public partial class UIResource
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.DefaultListCellRenderer.UIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.DefaultListCellRenderer.UIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}