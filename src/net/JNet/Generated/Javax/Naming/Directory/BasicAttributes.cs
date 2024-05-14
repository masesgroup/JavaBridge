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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Directory
{
    #region BasicAttributes
    public partial class BasicAttributes
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public BasicAttributes(bool arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#%3Cinit%3E(java.lang.String,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public BasicAttributes(Java.Lang.String arg0, object arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#%3Cinit%3E(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public BasicAttributes(Java.Lang.String arg0, object arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#getAll()"/> 
        /// </summary>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.Attribute> All
        {
            get { return IExecuteWithSignature<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.Attribute>>("getAll", "()Ljavax/naming/NamingEnumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#getIDs()"/> 
        /// </summary>
        public Javax.Naming.NamingEnumeration<Java.Lang.String> IDs
        {
            get { return IExecuteWithSignature<Javax.Naming.NamingEnumeration<Java.Lang.String>>("getIDs", "()Ljavax/naming/NamingEnumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#isCaseIgnored()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCaseIgnored()
        {
            return IExecuteWithSignature<bool>("isCaseIgnored", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#size()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Directory.Attribute>("get", "(Ljava/lang/String;)Ljavax/naming/directory/Attribute;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Put(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Javax.Naming.Directory.Attribute>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#put(javax.naming.directory.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Directory.Attribute"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Put(Javax.Naming.Directory.Attribute arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Directory.Attribute>("put", "(Ljavax/naming/directory/Attribute;)Ljavax/naming/directory/Attribute;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/BasicAttributes.html#remove(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Remove(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Directory.Attribute>("remove", "(Ljava/lang/String;)Ljavax/naming/directory/Attribute;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}