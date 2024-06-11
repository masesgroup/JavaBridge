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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region IAccessibleTableModelChange
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAccessibleTableModelChange
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getFirstColumn()"/> 
        /// </summary>
        int FirstColumn { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getFirstRow()"/> 
        /// </summary>
        int FirstRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getLastColumn()"/> 
        /// </summary>
        int LastColumn { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getLastRow()"/> 
        /// </summary>
        int LastRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getType()"/> 
        /// </summary>
        int Type { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AccessibleTableModelChange
    public partial class AccessibleTableModelChange : Javax.Accessibility.IAccessibleTableModelChange
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#DELETE"/>
        /// </summary>
        public static int DELETE { get { if (!_DELETEReady) { _DELETEContent = SGetField<int>(LocalBridgeClazz, "DELETE"); _DELETEReady = true; } return _DELETEContent; } }
        private static int _DELETEContent = default;
        private static bool _DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#INSERT"/>
        /// </summary>
        public static int INSERT { get { if (!_INSERTReady) { _INSERTContent = SGetField<int>(LocalBridgeClazz, "INSERT"); _INSERTReady = true; } return _INSERTContent; } }
        private static int _INSERTContent = default;
        private static bool _INSERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#UPDATE"/>
        /// </summary>
        public static int UPDATE { get { if (!_UPDATEReady) { _UPDATEContent = SGetField<int>(LocalBridgeClazz, "UPDATE"); _UPDATEReady = true; } return _UPDATEContent; } }
        private static int _UPDATEContent = default;
        private static bool _UPDATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getFirstColumn()"/> 
        /// </summary>
        public int FirstColumn
        {
            get { return IExecuteWithSignature<int>("getFirstColumn", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getFirstRow()"/> 
        /// </summary>
        public int FirstRow
        {
            get { return IExecuteWithSignature<int>("getFirstRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getLastColumn()"/> 
        /// </summary>
        public int LastColumn
        {
            get { return IExecuteWithSignature<int>("getLastColumn", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getLastRow()"/> 
        /// </summary>
        public int LastRow
        {
            get { return IExecuteWithSignature<int>("getLastRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleTableModelChange.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}