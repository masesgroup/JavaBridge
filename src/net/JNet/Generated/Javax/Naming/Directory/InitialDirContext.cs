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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Directory
{
    #region InitialDirContext
    public partial class InitialDirContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#%3Cinit%3E(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public InitialDirContext(Java.Util.Hashtable<object, object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Naming.Directory.InitialDirContext"/> to <see cref="Javax.Naming.Directory.DirContext"/>
        /// </summary>
        public static implicit operator Javax.Naming.Directory.DirContext(Javax.Naming.Directory.InitialDirContext t) => t.Cast<Javax.Naming.Directory.DirContext>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getAttributes(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.Attributes GetAttributes(string arg0, string[] arg1)
        {
            return IExecute<Javax.Naming.Directory.Attributes>("getAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getAttributes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.Attributes GetAttributes(string arg0)
        {
            return IExecute<Javax.Naming.Directory.Attributes>("getAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getAttributes(javax.naming.Name,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.Attributes GetAttributes(Javax.Naming.Name arg0, string[] arg1)
        {
            return IExecute<Javax.Naming.Directory.Attributes>("getAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getAttributes(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.Attributes GetAttributes(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Directory.Attributes>("getAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#createSubcontext(java.lang.String,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext CreateSubcontext(string arg0, Javax.Naming.Directory.Attributes arg1)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("createSubcontext", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#createSubcontext(javax.naming.Name,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext CreateSubcontext(Javax.Naming.Name arg0, Javax.Naming.Directory.Attributes arg1)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("createSubcontext", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getSchema(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchema(string arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchema", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getSchema(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchema(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchema", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getSchemaClassDefinition(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchemaClassDefinition(string arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchemaClassDefinition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#getSchemaClassDefinition(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchemaClassDefinition(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchemaClassDefinition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(java.lang.String,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(java.lang.String,java.lang.String,javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, string arg1, Javax.Naming.Directory.SearchControls arg2)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(java.lang.String,javax.naming.directory.Attributes,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, Javax.Naming.Directory.Attributes arg1, string[] arg2)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(java.lang.String,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, Javax.Naming.Directory.Attributes arg1)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(javax.naming.Name,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(javax.naming.Name,java.lang.String,javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, string arg1, Javax.Naming.Directory.SearchControls arg2)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(javax.naming.Name,javax.naming.directory.Attributes,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, Javax.Naming.Directory.Attributes arg1, string[] arg2)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#search(javax.naming.Name,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, Javax.Naming.Directory.Attributes arg1)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult>>("search", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#bind(java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(string arg0, object arg1, Javax.Naming.Directory.Attributes arg2)
        {
            IExecute("bind", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#bind(javax.naming.Name,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(Javax.Naming.Name arg0, object arg1, Javax.Naming.Directory.Attributes arg2)
        {
            IExecute("bind", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#modifyAttributes(java.lang.String,int,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void ModifyAttributes(string arg0, int arg1, Javax.Naming.Directory.Attributes arg2)
        {
            IExecute("modifyAttributes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#modifyAttributes(java.lang.String,javax.naming.directory.ModificationItem[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.ModificationItem"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void ModifyAttributes(string arg0, Javax.Naming.Directory.ModificationItem[] arg1)
        {
            IExecute("modifyAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#modifyAttributes(javax.naming.Name,int,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void ModifyAttributes(Javax.Naming.Name arg0, int arg1, Javax.Naming.Directory.Attributes arg2)
        {
            IExecute("modifyAttributes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#modifyAttributes(javax.naming.Name,javax.naming.directory.ModificationItem[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.ModificationItem"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void ModifyAttributes(Javax.Naming.Name arg0, Javax.Naming.Directory.ModificationItem[] arg1)
        {
            IExecute("modifyAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#rebind(java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(string arg0, object arg1, Javax.Naming.Directory.Attributes arg2)
        {
            IExecute("rebind", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/InitialDirContext.html#rebind(javax.naming.Name,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(Javax.Naming.Name arg0, object arg1, Javax.Naming.Directory.Attributes arg2)
        {
            IExecute("rebind", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}