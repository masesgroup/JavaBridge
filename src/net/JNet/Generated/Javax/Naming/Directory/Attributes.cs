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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Directory
{
    #region IAttributes
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAttributes
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#getAll()"/> 
        /// </summary>
        Javax.Naming.NamingEnumeration All { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#getIDs()"/> 
        /// </summary>
        Javax.Naming.NamingEnumeration<Java.Lang.String> IDs { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#isCaseIgnored()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCaseIgnored();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        int Size();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        Javax.Naming.Directory.Attribute Get(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        Javax.Naming.Directory.Attribute Put(Java.Lang.String arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#put(javax.naming.directory.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Directory.Attribute"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        Javax.Naming.Directory.Attribute Put(Javax.Naming.Directory.Attribute arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#remove(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        Javax.Naming.Directory.Attribute Remove(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Attributes
    public partial class Attributes : Javax.Naming.Directory.IAttributes
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Directory.Attributes"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Naming.Directory.Attributes t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Directory.Attributes"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Naming.Directory.Attributes t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#getAll()"/> 
        /// </summary>
        public Javax.Naming.NamingEnumeration All
        {
            get { return IExecuteWithSignature<Javax.Naming.NamingEnumeration>("getAll", "()Ljavax/naming/NamingEnumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#getIDs()"/> 
        /// </summary>
        public Javax.Naming.NamingEnumeration<Java.Lang.String> IDs
        {
            get { return IExecuteWithSignature<Javax.Naming.NamingEnumeration<Java.Lang.String>>("getIDs", "()Ljavax/naming/NamingEnumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#isCaseIgnored()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCaseIgnored()
        {
            return IExecuteWithSignature<bool>("isCaseIgnored", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#size()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#get(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Get(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Directory.Attribute>("get", "(Ljava/lang/String;)Ljavax/naming/directory/Attribute;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#put(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Put(Java.Lang.String arg0, object arg1)
        {
            return IExecute<Javax.Naming.Directory.Attribute>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#put(javax.naming.directory.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Directory.Attribute"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attribute"/></returns>
        public Javax.Naming.Directory.Attribute Put(Javax.Naming.Directory.Attribute arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Directory.Attribute>("put", "(Ljavax/naming/directory/Attribute;)Ljavax/naming/directory/Attribute;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attributes.html#remove(java.lang.String)"/>
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