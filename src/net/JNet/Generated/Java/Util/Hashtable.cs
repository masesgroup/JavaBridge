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

namespace Java.Util
{
    #region Hashtable
    public partial class Hashtable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="float"/></param>
        public Hashtable(int arg0, float arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        public Hashtable(int arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Hashtable t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Hashtable t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecute<bool>("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replace(K,V,V)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <param name="arg2"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Replace(object arg0, object arg1, object arg2)
        {
            return IExecute<bool>("replace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#getOrDefault(java.lang.Object,V)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object GetOrDefault(object arg0, object arg1)
        {
            return IExecute("getOrDefault", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#putIfAbsent(K,V)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object PutIfAbsent(object arg0, object arg1)
        {
            return IExecute("putIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replace(K,V)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object Replace(object arg0, object arg1)
        {
            return IExecute("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}