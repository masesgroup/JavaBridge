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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region ConcurrentSkipListMap
    public partial class ConcurrentSkipListMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#ceilingKey(K)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object CeilingKey(object arg0)
        {
            return IExecute("ceilingKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#firstKey()"/>
        /// </summary>
        
        /// <returns><see langword="object"/></returns>
        public object FirstKey()
        {
            return IExecute("firstKey");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#floorKey(K)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object FloorKey(object arg0)
        {
            return IExecute("floorKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#higherKey(K)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object HigherKey(object arg0)
        {
            return IExecute("higherKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lastKey()"/>
        /// </summary>
        
        /// <returns><see langword="object"/></returns>
        public object LastKey()
        {
            return IExecute("lastKey");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentSkipListMap.html#lowerKey(K)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
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
}