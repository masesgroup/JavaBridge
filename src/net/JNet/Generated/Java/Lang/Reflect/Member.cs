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

namespace Java.Lang.Reflect
{
    #region IMember
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMember
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#getDeclaringClass()"/> 
        /// </summary>
        Java.Lang.Class DeclaringClass { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#getModifiers()"/> 
        /// </summary>
        int Modifiers { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#isSynthetic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsSynthetic();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Member
    public partial class Member : Java.Lang.Reflect.IMember
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#DECLARED"/>
        /// </summary>
        public static int DECLARED { get { if (!_DECLAREDReady) { _DECLAREDContent = SGetField<int>(LocalBridgeClazz, "DECLARED"); _DECLAREDReady = true; } return _DECLAREDContent; } }
        private static int _DECLAREDContent = default;
        private static bool _DECLAREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#PUBLIC"/>
        /// </summary>
        public static int PUBLIC { get { if (!_PUBLICReady) { _PUBLICContent = SGetField<int>(LocalBridgeClazz, "PUBLIC"); _PUBLICReady = true; } return _PUBLICContent; } }
        private static int _PUBLICContent = default;
        private static bool _PUBLICReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#getDeclaringClass()"/> 
        /// </summary>
        public Java.Lang.Class DeclaringClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getDeclaringClass", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecuteWithSignature<int>("getModifiers", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Member.html#isSynthetic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSynthetic()
        {
            return IExecuteWithSignature<bool>("isSynthetic", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}