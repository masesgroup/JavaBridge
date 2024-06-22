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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Undo
{
    #region IStateEditable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStateEditable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/StateEditable.html#restoreState(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        void RestoreState(Java.Util.Hashtable<object, object> arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/StateEditable.html#storeState(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        void StoreState(Java.Util.Hashtable<object, object> arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateEditable
    public partial class StateEditable : Javax.Swing.Undo.IStateEditable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/StateEditable.html#RCSID"/>
        /// </summary>
        public static Java.Lang.String RCSID { get { if (!_RCSIDReady) { _RCSIDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RCSID"); _RCSIDReady = true; } return _RCSIDContent; } }
        private static Java.Lang.String _RCSIDContent = default;
        private static bool _RCSIDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/StateEditable.html#restoreState(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        public void RestoreState(Java.Util.Hashtable<object, object> arg0)
        {
            IExecuteWithSignature("restoreState", "(Ljava/util/Hashtable;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/StateEditable.html#storeState(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        public void StoreState(Java.Util.Hashtable<object, object> arg0)
        {
            IExecuteWithSignature("storeState", "(Ljava/util/Hashtable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}