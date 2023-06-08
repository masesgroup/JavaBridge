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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Directory
{
    #region IDirContext
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html"/>
    /// </summary>
    public partial interface IDirContext : Javax.Naming.IContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.Attributes GetAttributes(string arg0, string[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.Attributes GetAttributes(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(javax.naming.Name,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.Attributes GetAttributes(Javax.Naming.Name arg0, string[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.Attributes GetAttributes(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#createSubcontext(java.lang.String,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.DirContext CreateSubcontext(string arg0, Javax.Naming.Directory.Attributes arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#createSubcontext(javax.naming.Name,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.DirContext CreateSubcontext(Javax.Naming.Name arg0, Javax.Naming.Directory.Attributes arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchema(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.DirContext GetSchema(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchema(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.DirContext GetSchema(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchemaClassDefinition(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.DirContext GetSchemaClassDefinition(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchemaClassDefinition(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Directory.DirContext GetSchemaClassDefinition(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,java.lang.String,javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, string arg1, Javax.Naming.Directory.SearchControls arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,javax.naming.directory.Attributes,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, Javax.Naming.Directory.Attributes arg1, string[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(string arg0, Javax.Naming.Directory.Attributes arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, string arg1, object[] arg2, Javax.Naming.Directory.SearchControls arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,java.lang.String,javax.naming.directory.SearchControls)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.SearchControls"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, string arg1, Javax.Naming.Directory.SearchControls arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,javax.naming.directory.Attributes,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, Javax.Naming.Directory.Attributes arg1, string[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Directory.SearchResult> Search(Javax.Naming.Name arg0, Javax.Naming.Directory.Attributes arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#bind(java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Bind(string arg0, object arg1, Javax.Naming.Directory.Attributes arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#bind(javax.naming.Name,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Bind(Javax.Naming.Name arg0, object arg1, Javax.Naming.Directory.Attributes arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(java.lang.String,int,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void ModifyAttributes(string arg0, int arg1, Javax.Naming.Directory.Attributes arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(java.lang.String,javax.naming.directory.ModificationItem[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.ModificationItem"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void ModifyAttributes(string arg0, Javax.Naming.Directory.ModificationItem[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(javax.naming.Name,int,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void ModifyAttributes(Javax.Naming.Name arg0, int arg1, Javax.Naming.Directory.Attributes arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(javax.naming.Name,javax.naming.directory.ModificationItem[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.ModificationItem"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void ModifyAttributes(Javax.Naming.Name arg0, Javax.Naming.Directory.ModificationItem[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#rebind(java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Rebind(string arg0, object arg1, Javax.Naming.Directory.Attributes arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#rebind(javax.naming.Name,java.lang.Object,javax.naming.directory.Attributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Javax.Naming.Directory.Attributes"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Rebind(Javax.Naming.Name arg0, object arg1, Javax.Naming.Directory.Attributes arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DirContext
    public partial class DirContext : Javax.Naming.Directory.IDirContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#ADD_ATTRIBUTE"/>
        /// </summary>
        public static int ADD_ATTRIBUTE { get { return SGetField<int>(LocalBridgeClazz, "ADD_ATTRIBUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#REMOVE_ATTRIBUTE"/>
        /// </summary>
        public static int REMOVE_ATTRIBUTE { get { return SGetField<int>(LocalBridgeClazz, "REMOVE_ATTRIBUTE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#REPLACE_ATTRIBUTE"/>
        /// </summary>
        public static int REPLACE_ATTRIBUTE { get { return SGetField<int>(LocalBridgeClazz, "REPLACE_ATTRIBUTE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(java.lang.String,java.lang.String[])"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.Attributes GetAttributes(string arg0)
        {
            return IExecute<Javax.Naming.Directory.Attributes>("getAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(javax.naming.Name,java.lang.String[])"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getAttributes(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.Attributes"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.Attributes GetAttributes(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Directory.Attributes>("getAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#createSubcontext(java.lang.String,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#createSubcontext(javax.naming.Name,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchema(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchema(string arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchema", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchema(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchema(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchema", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchemaClassDefinition(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchemaClassDefinition(string arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchemaClassDefinition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#getSchemaClassDefinition(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Directory.DirContext"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Directory.DirContext GetSchemaClassDefinition(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Directory.DirContext>("getSchemaClassDefinition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,java.lang.String,javax.naming.directory.SearchControls)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,javax.naming.directory.Attributes,java.lang.String[])"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(java.lang.String,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,java.lang.String,java.lang.Object[],javax.naming.directory.SearchControls)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,java.lang.String,javax.naming.directory.SearchControls)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,javax.naming.directory.Attributes,java.lang.String[])"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#search(javax.naming.Name,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#bind(java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#bind(javax.naming.Name,java.lang.Object,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(java.lang.String,int,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(java.lang.String,javax.naming.directory.ModificationItem[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.ModificationItem"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void ModifyAttributes(string arg0, Javax.Naming.Directory.ModificationItem[] arg1)
        {
            IExecute("modifyAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(javax.naming.Name,int,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#modifyAttributes(javax.naming.Name,javax.naming.directory.ModificationItem[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Directory.ModificationItem"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void ModifyAttributes(Javax.Naming.Name arg0, Javax.Naming.Directory.ModificationItem[] arg1)
        {
            IExecute("modifyAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#rebind(java.lang.String,java.lang.Object,javax.naming.directory.Attributes)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/DirContext.html#rebind(javax.naming.Name,java.lang.Object,javax.naming.directory.Attributes)"/>
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