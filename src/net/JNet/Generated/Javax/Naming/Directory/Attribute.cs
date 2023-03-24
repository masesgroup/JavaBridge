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

namespace Javax.Naming.Directory
{
    #region Attribute
    public partial class Attribute
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Directory.Attribute"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Naming.Directory.Attribute t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Directory.Attribute"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Naming.Directory.Attribute t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID => Clazz.GetField<long>("serialVersionUID");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#getAll()"/> 
        /// </summary>
        public Javax.Naming.NamingEnumeration All
        {
            get { return IExecute<Javax.Naming.NamingEnumeration>("getAll"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#getAttributeDefinition()"/> 
        /// </summary>
        public Javax.Naming.Directory.DirContext AttributeDefinition
        {
            get { return IExecute<Javax.Naming.Directory.DirContext>("getAttributeDefinition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#getAttributeSyntaxDefinition()"/> 
        /// </summary>
        public Javax.Naming.Directory.DirContext AttributeSyntaxDefinition
        {
            get { return IExecute<Javax.Naming.Directory.DirContext>("getAttributeSyntaxDefinition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#getID()"/> 
        /// </summary>
        public string ID
        {
            get { return IExecute<string>("getID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#isOrdered()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsOrdered()
        {
            return IExecute<bool>("isOrdered");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#size()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#get()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Get()
        {
            return IExecute("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Get(int arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(int arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#set(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Set(int arg0, object arg1)
        {
            return IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#add(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Add(int arg0, object arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/Attribute.html#clear()"/>
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