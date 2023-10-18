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

namespace Java.Beans
{
    #region IndexedPropertyDescriptor
    public partial class IndexedPropertyDescriptor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public IndexedPropertyDescriptor(string arg0, Java.Lang.Class arg1, string arg2, string arg3, string arg4, string arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public IndexedPropertyDescriptor(string arg0, Java.Lang.Class arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#%3Cinit%3E(java.lang.String,java.lang.reflect.Method,java.lang.reflect.Method,java.lang.reflect.Method,java.lang.reflect.Method)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg3"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public IndexedPropertyDescriptor(string arg0, Java.Lang.Reflect.Method arg1, Java.Lang.Reflect.Method arg2, Java.Lang.Reflect.Method arg3, Java.Lang.Reflect.Method arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#getIndexedPropertyType()"/> 
        /// </summary>
        public Java.Lang.Class IndexedPropertyType
        {
            get { return IExecute<Java.Lang.Class>("getIndexedPropertyType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#getIndexedReadMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#setIndexedReadMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method IndexedReadMethod
        {
            get { return IExecute<Java.Lang.Reflect.Method>("getIndexedReadMethod"); } set { IExecute("setIndexedReadMethod", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#getIndexedWriteMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/IndexedPropertyDescriptor.html#setIndexedWriteMethod(java.lang.reflect.Method)"/>
        /// </summary>
        public Java.Lang.Reflect.Method IndexedWriteMethod
        {
            get { return IExecute<Java.Lang.Reflect.Method>("getIndexedWriteMethod"); } set { IExecute("setIndexedWriteMethod", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}