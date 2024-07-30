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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region ConcurrentSkipListMap
    public partial class ConcurrentSkipListMap
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#%3Cinit%3E(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        public ConcurrentSkipListMap(Java.Util.Comparator arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ConcurrentSkipListMap(Java.Util.Map arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#%3Cinit%3E(java.util.SortedMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedMap"/></param>
        public ConcurrentSkipListMap(Java.Util.SortedMap arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListMap"/> to <see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentNavigableMap(Java.Util.Concurrent.ConcurrentSkipListMap t) => t.Cast<Java.Util.Concurrent.ConcurrentNavigableMap>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListMap"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Concurrent.ConcurrentSkipListMap t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListMap"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ConcurrentSkipListMap t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#comparator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator Comparator()
        {
            return IExecuteWithSignature<Java.Util.Comparator>("comparator", "()Ljava/util/Comparator;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#descendingMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap DescendingMap()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentNavigableMap>("descendingMap", "()Ljava/util/concurrent/ConcurrentNavigableMap;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap HeadMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap HeadMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentNavigableMap>("headMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap SubMapMethod(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap SubMapMethod(object arg0, object arg1)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap TailMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap TailMap(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentNavigableMap>("tailMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentSkipListMap"/></returns>
        public Java.Util.Concurrent.ConcurrentSkipListMap Clone()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentSkipListMap>("clone", "()Ljava/util/concurrent/ConcurrentSkipListMap;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry CeilingEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#firstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry FirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("firstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry FloorEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry HigherEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry LastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("lastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry LowerEntry(object arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#pollFirstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry PollFirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("pollFirstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#pollLastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry PollLastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry>("pollLastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#descendingKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet DescendingKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet>("descendingKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#navigableKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet NavigableKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet>("navigableKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CeilingKey(object arg0)
        {
            return IExecuteWithSignature("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#firstKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object FirstKey()
        {
            return IExecuteWithSignature("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object FloorKey(object arg0)
        {
            return IExecuteWithSignature("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object HigherKey(object arg0)
        {
            return IExecuteWithSignature("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lastKey()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object LastKey()
        {
            return IExecuteWithSignature("lastKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object LowerKey(object arg0)
        {
            return IExecuteWithSignature("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConcurrentSkipListMap<K, V>
    public partial class ConcurrentSkipListMap<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#%3Cinit%3E(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        public ConcurrentSkipListMap(Java.Util.Comparator<K> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public ConcurrentSkipListMap(Java.Util.Map<K, V> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#%3Cinit%3E(java.util.SortedMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedMap"/></param>
        public ConcurrentSkipListMap(Java.Util.SortedMap<K, V> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListMap{K, V}"/> to <see cref="Java.Util.Concurrent.ConcurrentNavigableMap{K, V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentNavigableMap<K, V>(Java.Util.Concurrent.ConcurrentSkipListMap<K, V> t) => t.Cast<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListMap{K, V}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Concurrent.ConcurrentSkipListMap<K, V> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListMap{K, V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.ConcurrentSkipListMap<K, V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentSkipListMap{K, V}"/> to <see cref="Java.Util.Concurrent.ConcurrentSkipListMap"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentSkipListMap(Java.Util.Concurrent.ConcurrentSkipListMap<K, V> t) => t.Cast<Java.Util.Concurrent.ConcurrentSkipListMap>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#comparator()"/>
        /// </summary>
        /// <typeparam name="ReturnobjectSuperK"><typeparamref name="K"/></typeparam>
        /// <returns><see cref="Java.Util.Comparator"/></returns>
        public Java.Util.Comparator<ReturnobjectSuperK> Comparator<ReturnobjectSuperK>() where ReturnobjectSuperK : K
        {
            return IExecuteWithSignature<Java.Util.Comparator<ReturnobjectSuperK>>("comparator", "()Ljava/util/Comparator;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#descendingMap()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap<K, V> DescendingMap()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>("descendingMap", "()Ljava/util/concurrent/ConcurrentNavigableMap;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap<K, V> HeadMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap<K, V> HeadMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>("headMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><typeparamref name="K"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap<K, V> SubMapMethod(K arg0, bool arg1, K arg2, bool arg3)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap<K, V> SubMapMethod(K arg0, K arg1)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap<K, V> TailMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentNavigableMap"/></returns>
        public Java.Util.Concurrent.ConcurrentNavigableMap<K, V> TailMap(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentNavigableMap<K, V>>("tailMap", "(Ljava/lang/Object;)Ljava/util/concurrent/ConcurrentNavigableMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#clone()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.ConcurrentSkipListMap"/></returns>
        public Java.Util.Concurrent.ConcurrentSkipListMap<K, V> Clone()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.ConcurrentSkipListMap<K, V>>("clone", "()Ljava/util/concurrent/ConcurrentSkipListMap;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> CeilingEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("ceilingEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#firstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> FirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("firstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> FloorEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("floorEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> HigherEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("higherEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> LastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("lastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> LowerEntry(K arg0)
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("lowerEntry", "(Ljava/lang/Object;)Ljava/util/Map$Entry;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#pollFirstEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> PollFirstEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("pollFirstEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#pollLastEntry()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> PollLastEntry()
        {
            return IExecuteWithSignature<Java.Util.Map.Entry<K, V>>("pollLastEntry", "()Ljava/util/Map$Entry;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#descendingKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> DescendingKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet<K>>("descendingKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#navigableKeySet()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> NavigableKeySet()
        {
            return IExecuteWithSignature<Java.Util.NavigableSet<K>>("navigableKeySet", "()Ljava/util/NavigableSet;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K CeilingKey(K arg0)
        {
            return IExecuteWithSignature<K>("ceilingKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#firstKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K FirstKey()
        {
            return IExecuteWithSignature<K>("firstKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K FloorKey(K arg0)
        {
            return IExecuteWithSignature<K>("floorKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K HigherKey(K arg0)
        {
            return IExecuteWithSignature<K>("higherKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lastKey()"/>
        /// </summary>
        /// <returns><typeparamref name="K"/></returns>
        public K LastKey()
        {
            return IExecuteWithSignature<K>("lastKey", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K LowerKey(K arg0)
        {
            return IExecuteWithSignature<K>("lowerKey", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}