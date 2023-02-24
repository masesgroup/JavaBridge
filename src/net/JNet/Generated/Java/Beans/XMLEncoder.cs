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

namespace Java.Beans
{
    #region XMLEncoder
    public partial class XMLEncoder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLEncoder.html#%3Cinit%3E(java.io.OutputStream,java.lang.String,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <param name="arg2"><see langword="bool"/></param>
        /// <param name="arg3"><see langword="int"/></param>
        public XMLEncoder(Java.Io.OutputStream arg0, string arg1, bool arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLEncoder.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public XMLEncoder(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.XMLEncoder"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Beans.XMLEncoder t) => t.Cast<Java.Lang.AutoCloseable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLEncoder.html#getOwner()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLEncoder.html#setOwner(java.lang.Object)"/>
        /// </summary>
        public object Owner
        {
            get { return IExecute("getOwner"); } set { IExecute("setOwner", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLEncoder.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLEncoder.html#flush()"/>
        /// </summary>
        public void Flush()
        {
            IExecute("flush");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/XMLEncoder.html#writeObject(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        public void WriteObject(object arg0)
        {
            IExecute("writeObject", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}