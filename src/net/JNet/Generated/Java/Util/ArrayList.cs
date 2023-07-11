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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region ArrayList
    public partial class ArrayList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ArrayList(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public ArrayList(Java.Util.Collection arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayList"/> to <see cref="Java.Util.RandomAccess"/>
        /// </summary>
        public static implicit operator Java.Util.RandomAccess(Java.Util.ArrayList t) => t.Cast<Java.Util.RandomAccess>();
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayList"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.ArrayList t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayList"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.ArrayList t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#ensureCapacity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void EnsureCapacity(int arg0)
        {
            IExecute("ensureCapacity", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#trimToSize()"/>
        /// </summary>
        public void TrimToSize()
        {
            IExecute("trimToSize");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ArrayList<E>
    public partial class ArrayList<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ArrayList(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public ArrayList(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayList{E}"/> to <see cref="Java.Util.RandomAccess"/>
        /// </summary>
        public static implicit operator Java.Util.RandomAccess(Java.Util.ArrayList<E> t) => t.Cast<Java.Util.RandomAccess>();
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayList{E}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.ArrayList<E> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayList{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.ArrayList<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.ArrayList{E}"/> to <see cref="Java.Util.ArrayList"/>
        /// </summary>
        public static implicit operator Java.Util.ArrayList(Java.Util.ArrayList<E> t) => t.Cast<Java.Util.ArrayList>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#ensureCapacity(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void EnsureCapacity(int arg0)
        {
            IExecute("ensureCapacity", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#trimToSize()"/>
        /// </summary>
        public void TrimToSize()
        {
            IExecute("trimToSize");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}