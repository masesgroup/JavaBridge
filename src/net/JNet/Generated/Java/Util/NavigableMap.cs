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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region NavigableMap
    public partial class NavigableMap
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#descendingKeySet()"/> 
        /// </summary>
        public Java.Util.NavigableSet DescendingKeySet
        {
            get { return IExecute<Java.Util.NavigableSet>("descendingKeySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#descendingMap()"/> 
        /// </summary>
        public Java.Util.NavigableMap DescendingMap
        {
            get { return IExecute<Java.Util.NavigableMap>("descendingMap"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#firstEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry FirstEntry
        {
            get { return IExecute<Java.Util.Map.Entry>("firstEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#lastEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry LastEntry
        {
            get { return IExecute<Java.Util.Map.Entry>("lastEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#navigableKeySet()"/> 
        /// </summary>
        public Java.Util.NavigableSet NavigableKeySet
        {
            get { return IExecute<Java.Util.NavigableSet>("navigableKeySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#pollFirstEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry PollFirstEntry
        {
            get { return IExecute<Java.Util.Map.Entry>("pollFirstEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#pollLastEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry PollLastEntry
        {
            get { return IExecute<Java.Util.Map.Entry>("pollLastEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry CeilingEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("ceilingEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry FloorEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("floorEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry HigherEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("higherEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry LowerEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("lowerEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap HeadMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap SubMap(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap TailMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap HeadMap(object arg0)
        {
            return IExecute<Java.Util.SortedMap>("headMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap SubMap(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedMap>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap TailMap(object arg0)
        {
            return IExecute<Java.Util.SortedMap>("tailMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CeilingKey(object arg0)
        {
            return IExecute("ceilingKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object FloorKey(object arg0)
        {
            return IExecute("floorKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object HigherKey(object arg0)
        {
            return IExecute("higherKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object LowerKey(object arg0)
        {
            return IExecute("lowerKey", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region NavigableMap<K, V>
    public partial class NavigableMap<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.NavigableMap{K, V}"/> to <see cref="Java.Util.NavigableMap"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableMap(Java.Util.NavigableMap<K, V> t) => t.Cast<Java.Util.NavigableMap>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#descendingKeySet()"/> 
        /// </summary>
        public Java.Util.NavigableSet<K> DescendingKeySet
        {
            get { return IExecute<Java.Util.NavigableSet<K>>("descendingKeySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#descendingMap()"/> 
        /// </summary>
        public Java.Util.NavigableMap<K, V> DescendingMap
        {
            get { return IExecute<Java.Util.NavigableMap<K, V>>("descendingMap"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#firstEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry<K, V> FirstEntry
        {
            get { return IExecute<Java.Util.Map.Entry<K, V>>("firstEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#lastEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry<K, V> LastEntry
        {
            get { return IExecute<Java.Util.Map.Entry<K, V>>("lastEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#navigableKeySet()"/> 
        /// </summary>
        public Java.Util.NavigableSet<K> NavigableKeySet
        {
            get { return IExecute<Java.Util.NavigableSet<K>>("navigableKeySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#pollFirstEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry<K, V> PollFirstEntry
        {
            get { return IExecute<Java.Util.Map.Entry<K, V>>("pollFirstEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#pollLastEntry()"/> 
        /// </summary>
        public Java.Util.Map.Entry<K, V> PollLastEntry
        {
            get { return IExecute<Java.Util.Map.Entry<K, V>>("pollLastEntry"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> CeilingEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("ceilingEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> FloorEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("floorEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> HigherEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("higherEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> LowerEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("lowerEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> HeadMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="K"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> SubMap(K arg0, bool arg1, K arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> TailMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> HeadMap(K arg0)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("headMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> SubMap(K arg0, K arg1)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> TailMap(K arg0)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("tailMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="K"/></returns>
        public K CeilingKey(K arg0)
        {
            return IExecute<K>("ceilingKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="K"/></returns>
        public K FloorKey(K arg0)
        {
            return IExecute<K>("floorKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="K"/></returns>
        public K HigherKey(K arg0)
        {
            return IExecute<K>("higherKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/NavigableMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <returns><see cref="K"/></returns>
        public K LowerKey(K arg0)
        {
            return IExecute<K>("lowerKey", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}