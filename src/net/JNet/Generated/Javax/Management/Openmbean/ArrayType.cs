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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region ArrayType
    public partial class ArrayType
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#%3Cinit%3E(int,javax.management.openmbean.OpenType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public ArrayType(int arg0, Javax.Management.Openmbean.OpenType arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#%3Cinit%3E(javax.management.openmbean.SimpleType,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.SimpleType"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public ArrayType(Javax.Management.Openmbean.SimpleType arg0, bool arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getArrayType(javax.management.openmbean.OpenType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.ArrayType"/></returns>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public static Javax.Management.Openmbean.ArrayType GetArrayType(Javax.Management.Openmbean.OpenType arg0)
        {
            return SExecute<Javax.Management.Openmbean.ArrayType>(LocalBridgeClazz, "getArrayType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getPrimitiveArrayType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.ArrayType"/></returns>
        public static Javax.Management.Openmbean.ArrayType GetPrimitiveArrayType(Java.Lang.Class arg0)
        {
            return SExecute<Javax.Management.Openmbean.ArrayType>(LocalBridgeClazz, "getPrimitiveArrayType", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getDimension()"/> 
        /// </summary>
        public int Dimension
        {
            get { return IExecute<int>("getDimension"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getElementOpenType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.OpenType ElementOpenType
        {
            get { return IExecute<Javax.Management.Openmbean.OpenType>("getElementOpenType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#isPrimitiveArray()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPrimitiveArray()
        {
            return IExecute<bool>("isPrimitiveArray");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ArrayType<T>
    public partial class ArrayType<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#%3Cinit%3E(int,javax.management.openmbean.OpenType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public ArrayType(int arg0, Javax.Management.Openmbean.OpenType<object> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#%3Cinit%3E(javax.management.openmbean.SimpleType,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.SimpleType"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public ArrayType(Javax.Management.Openmbean.SimpleType<object> arg0, bool arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.ArrayType{T}"/> to <see cref="Javax.Management.Openmbean.ArrayType"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.ArrayType(Javax.Management.Openmbean.ArrayType<T> t) => t.Cast<Javax.Management.Openmbean.ArrayType>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getArrayType(javax.management.openmbean.OpenType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <typeparam name="E"></typeparam>
        /// <returns><see cref="Javax.Management.Openmbean.ArrayType"/></returns>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public static Javax.Management.Openmbean.ArrayType<E[]> GetArrayType<E>(Javax.Management.Openmbean.OpenType<E> arg0)
        {
            return SExecute<Javax.Management.Openmbean.ArrayType<E[]>>(LocalBridgeClazz, "getArrayType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getPrimitiveArrayType(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Javax.Management.Openmbean.ArrayType"/></returns>
        public static Javax.Management.Openmbean.ArrayType<T> GetPrimitiveArrayType(Java.Lang.Class arg0)
        {
            return SExecute<Javax.Management.Openmbean.ArrayType<T>>(LocalBridgeClazz, "getPrimitiveArrayType", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getDimension()"/> 
        /// </summary>
        public int Dimension
        {
            get { return IExecute<int>("getDimension"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#getElementOpenType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.OpenType<object> ElementOpenType
        {
            get { return IExecute<Javax.Management.Openmbean.OpenType<object>>("getElementOpenType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/ArrayType.html#isPrimitiveArray()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPrimitiveArray()
        {
            return IExecute<bool>("isPrimitiveArray");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}