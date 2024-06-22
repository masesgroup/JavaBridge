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

namespace Java.Util
{
    #region SortedMap
    public partial class SortedMap
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection Values()
        {
            return IExecuteWithSignature<Java.Util.Collection>("values", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#entrySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set EntrySet()
        {
            return IExecuteWithSignature<Java.Util.Set>("entrySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap HeadMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap SubMap(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedMap>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap TailMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#firstKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object FirstKey()
        {
            return IExecuteWithSignature("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#lastKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object LastKey()
        {
            return IExecuteWithSignature("lastKey", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ISortedMap<K, V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISortedMap<K, V> : Java.Util.IMap<K, V>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        Java.Util.Collection<V> Values();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#entrySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        Java.Util.Set<Java.Util.Map.Entry<K, V>> EntrySet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        Java.Util.Set<K> KeySet();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        Java.Util.SortedMap<K, V> HeadMap(K arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        Java.Util.SortedMap<K, V> SubMap(K arg0, K arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        Java.Util.SortedMap<K, V> TailMap(K arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#firstKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        K FirstKey();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#lastKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        K LastKey();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SortedMap<K, V>
    public partial class SortedMap<K, V> : Java.Util.ISortedMap<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.SortedMap{K, V}"/> to <see cref="Java.Util.SortedMap"/>
        /// </summary>
        public static implicit operator Java.Util.SortedMap(Java.Util.SortedMap<K, V> t) => t.Cast<Java.Util.SortedMap>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<V> Values()
        {
            return IExecuteWithSignature<Java.Util.Collection<V>>("values", "()Ljava/util/Collection;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#entrySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Util.Map.Entry<K, V>> EntrySet()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Util.Map.Entry<K, V>>>("entrySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#keySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<K> KeySet()
        {
            return IExecuteWithSignature<Java.Util.Set<K>>("keySet", "()Ljava/util/Set;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> HeadMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap<K, V>>("headMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> SubMap(K arg0, K arg1)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> TailMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.SortedMap<K, V>>("tailMap", "(Ljava/lang/Object;)Ljava/util/SortedMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#firstKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K FirstKey()
        {
            return IExecuteWithSignature<K>("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/SortedMap.html#lastKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K LastKey()
        {
            return IExecuteWithSignature<K>("lastKey", "()Ljava/lang/Object;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}