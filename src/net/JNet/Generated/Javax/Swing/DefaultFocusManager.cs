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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DefaultFocusManager
    public partial class DefaultFocusManager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#compareTabOrder(java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareTabOrder(Java.Awt.Component arg0, Java.Awt.Component arg1)
        {
            return IExecute<bool>("compareTabOrder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getComponentAfter(java.awt.Container,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetComponentAfter(Java.Awt.Container arg0, Java.Awt.Component arg1)
        {
            return IExecute<Java.Awt.Component>("getComponentAfter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getComponentBefore(java.awt.Container,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetComponentBefore(Java.Awt.Container arg0, Java.Awt.Component arg1)
        {
            return IExecute<Java.Awt.Component>("getComponentBefore", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getFirstComponent(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetFirstComponent(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Component>("getFirstComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultFocusManager.html#getLastComponent(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetLastComponent(Java.Awt.Container arg0)
        {
            return IExecute<Java.Awt.Component>("getLastComponent", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}