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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Reflect
{
    #region Modifier
    public partial class Modifier
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#ABSTRACT"/>
        /// </summary>
        public static int ABSTRACT { get { return SGetField<int>(LocalBridgeClazz, "ABSTRACT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#FINAL"/>
        /// </summary>
        public static int FINAL { get { return SGetField<int>(LocalBridgeClazz, "FINAL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#INTERFACE"/>
        /// </summary>
        public static int INTERFACE { get { return SGetField<int>(LocalBridgeClazz, "INTERFACE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#NATIVE"/>
        /// </summary>
        public static int NATIVE { get { return SGetField<int>(LocalBridgeClazz, "NATIVE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PRIVATE"/>
        /// </summary>
        public static int PRIVATE { get { return SGetField<int>(LocalBridgeClazz, "PRIVATE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PROTECTED"/>
        /// </summary>
        public static int PROTECTED { get { return SGetField<int>(LocalBridgeClazz, "PROTECTED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PUBLIC"/>
        /// </summary>
        public static int PUBLIC { get { return SGetField<int>(LocalBridgeClazz, "PUBLIC"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#STATIC"/>
        /// </summary>
        public static int STATIC { get { return SGetField<int>(LocalBridgeClazz, "STATIC"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#STRICT"/>
        /// </summary>
        public static int STRICT { get { return SGetField<int>(LocalBridgeClazz, "STRICT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#SYNCHRONIZED"/>
        /// </summary>
        public static int SYNCHRONIZED { get { return SGetField<int>(LocalBridgeClazz, "SYNCHRONIZED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#TRANSIENT"/>
        /// </summary>
        public static int TRANSIENT { get { return SGetField<int>(LocalBridgeClazz, "TRANSIENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#VOLATILE"/>
        /// </summary>
        public static int VOLATILE { get { return SGetField<int>(LocalBridgeClazz, "VOLATILE"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isAbstract(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAbstract(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isAbstract", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isFinal(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFinal(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isFinal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isInterface(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInterface(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isInterface", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isNative(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNative(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isNative", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isPrivate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPrivate(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isPrivate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isProtected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsProtected(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isProtected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isPublic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPublic(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isPublic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isStatic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsStatic(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isStatic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isStrict(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsStrict(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isStrict", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isSynchronized(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSynchronized(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isSynchronized", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isTransient(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTransient(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isTransient", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isVolatile(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsVolatile(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isVolatile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#classModifiers()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int ClassModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "classModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#constructorModifiers()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int ConstructorModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "constructorModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#fieldModifiers()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int FieldModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "fieldModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#interfaceModifiers()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int InterfaceModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "interfaceModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#methodModifiers()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int MethodModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "methodModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#parameterModifiers()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int ParameterModifiers()
        {
            return SExecute<int>(LocalBridgeClazz, "parameterModifiers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toString", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}