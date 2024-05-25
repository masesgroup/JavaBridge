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

namespace Javax.Swing
{
    #region JCheckBox
    public partial class JCheckBox
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JCheckBox(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#%3Cinit%3E(java.lang.String,javax.swing.Icon,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public JCheckBox(Java.Lang.String arg0, Javax.Swing.Icon arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#%3Cinit%3E(java.lang.String,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        public JCheckBox(Java.Lang.String arg0, Javax.Swing.Icon arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public JCheckBox(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#%3Cinit%3E(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        public JCheckBox(Javax.Swing.Action arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#%3Cinit%3E(javax.swing.Icon,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JCheckBox(Javax.Swing.Icon arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#%3Cinit%3E(javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        public JCheckBox(Javax.Swing.Icon arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#BORDER_PAINTED_FLAT_CHANGED_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String BORDER_PAINTED_FLAT_CHANGED_PROPERTY { get { if (!_BORDER_PAINTED_FLAT_CHANGED_PROPERTYReady) { _BORDER_PAINTED_FLAT_CHANGED_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BORDER_PAINTED_FLAT_CHANGED_PROPERTY"); _BORDER_PAINTED_FLAT_CHANGED_PROPERTYReady = true; } return _BORDER_PAINTED_FLAT_CHANGED_PROPERTYContent; } }
        private static Java.Lang.String _BORDER_PAINTED_FLAT_CHANGED_PROPERTYContent = default;
        private static bool _BORDER_PAINTED_FLAT_CHANGED_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#isBorderPaintedFlat()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBorderPaintedFlat()
        {
            return IExecuteWithSignature<bool>("isBorderPaintedFlat", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JCheckBox.html#setBorderPaintedFlat(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBorderPaintedFlat(bool arg0)
        {
            IExecuteWithSignature("setBorderPaintedFlat", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}