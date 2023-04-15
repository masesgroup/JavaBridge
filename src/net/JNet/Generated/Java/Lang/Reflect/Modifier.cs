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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
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
        public static int ABSTRACT => Clazz.GetField<int>("ABSTRACT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#FINAL"/>
        /// </summary>
        public static int FINAL => Clazz.GetField<int>("FINAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#INTERFACE"/>
        /// </summary>
        public static int INTERFACE => Clazz.GetField<int>("INTERFACE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#NATIVE"/>
        /// </summary>
        public static int NATIVE => Clazz.GetField<int>("NATIVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PRIVATE"/>
        /// </summary>
        public static int PRIVATE => Clazz.GetField<int>("PRIVATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PROTECTED"/>
        /// </summary>
        public static int PROTECTED => Clazz.GetField<int>("PROTECTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#PUBLIC"/>
        /// </summary>
        public static int PUBLIC => Clazz.GetField<int>("PUBLIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#STATIC"/>
        /// </summary>
        public static int STATIC => Clazz.GetField<int>("STATIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#STRICT"/>
        /// </summary>
        public static int STRICT => Clazz.GetField<int>("STRICT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#SYNCHRONIZED"/>
        /// </summary>
        public static int SYNCHRONIZED => Clazz.GetField<int>("SYNCHRONIZED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#TRANSIENT"/>
        /// </summary>
        public static int TRANSIENT => Clazz.GetField<int>("TRANSIENT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#VOLATILE"/>
        /// </summary>
        public static int VOLATILE => Clazz.GetField<int>("VOLATILE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#classModifiers()"/> 
        /// </summary>
        public static int ClassModifiers
        {
            get { return SExecute<int>(LocalClazz, "classModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#constructorModifiers()"/> 
        /// </summary>
        public static int ConstructorModifiers
        {
            get { return SExecute<int>(LocalClazz, "constructorModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#fieldModifiers()"/> 
        /// </summary>
        public static int FieldModifiers
        {
            get { return SExecute<int>(LocalClazz, "fieldModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#interfaceModifiers()"/> 
        /// </summary>
        public static int InterfaceModifiers
        {
            get { return SExecute<int>(LocalClazz, "interfaceModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#methodModifiers()"/> 
        /// </summary>
        public static int MethodModifiers
        {
            get { return SExecute<int>(LocalClazz, "methodModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#parameterModifiers()"/> 
        /// </summary>
        public static int ParameterModifiers
        {
            get { return SExecute<int>(LocalClazz, "parameterModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isAbstract(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsAbstractMethod(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isAbstract", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isFinal(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsFinal(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isFinal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isInterface(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsInterfaceMethod(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isInterface", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isNative(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsNative(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isNative", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isPrivate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPrivate(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isPrivate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isProtected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsProtected(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isProtected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isPublic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsPublic(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isPublic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isStatic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsStaticMethod(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isStatic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isStrict(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsStrict(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isStrict", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isSynchronized(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSynchronized(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isSynchronized", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isTransient(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsTransient(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isTransient", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#isVolatile(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsVolatile(int arg0)
        {
            return SExecute<bool>(LocalClazz, "isVolatile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/reflect/Modifier.html#toString(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToString(int arg0)
        {
            return SExecute<string>(LocalClazz, "toString", arg0);
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