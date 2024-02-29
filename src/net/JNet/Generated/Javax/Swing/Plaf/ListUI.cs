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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf
{
    #region ListUI
    public partial class ListUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/ListUI.html#locationToIndex(javax.swing.JList,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JList"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="int"/></returns>
        public int LocationToIndex(Javax.Swing.JList<object> arg0, Java.Awt.Point arg1)
        {
            return IExecute<int>("locationToIndex", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/ListUI.html#indexToLocation(javax.swing.JList,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JList"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point IndexToLocation(Javax.Swing.JList<object> arg0, int arg1)
        {
            return IExecute<Java.Awt.Point>("indexToLocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/ListUI.html#getCellBounds(javax.swing.JList,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JList"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetCellBounds(Javax.Swing.JList<object> arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.Rectangle>("getCellBounds", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}