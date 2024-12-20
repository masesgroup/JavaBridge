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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming
{
    #region InitialContext declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html"/>
    /// </summary>
    public partial class InitialContext : Javax.Naming.Context
    {
        const string _bridgeClassName = "javax.naming.InitialContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InitialContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InitialContext(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region InitialContext implementation
    public partial class InitialContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#%3Cinit%3E(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public InitialContext(Java.Util.Hashtable<object, object> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#doLookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static T DoLookup<T>(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<T>(LocalBridgeClazz, "doLookup", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#doLookup(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public static T DoLookup<T>(Javax.Naming.Name arg0)
        {
            return SExecuteWithSignature<T>(LocalBridgeClazz, "doLookup", "(Ljavax/naming/Name;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getEnvironment()"/> 
        /// </summary>
        public Java.Util.Hashtable<object, object> Environment
        {
            get { return IExecuteWithSignature<Java.Util.Hashtable<object, object>>("getEnvironment", "()Ljava/util/Hashtable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getNameInNamespace()"/> 
        /// </summary>
        public Java.Lang.String NameInNamespace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNameInNamespace", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#addToEnvironment(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object AddToEnvironment(Java.Lang.String arg0, object arg1)
        {
            return IExecuteWithSignature("addToEnvironment", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("lookup", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookup(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(Javax.Naming.Name arg0)
        {
            return IExecuteWithSignature("lookup", "(Ljavax/naming/Name;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookupLink(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("lookupLink", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#lookupLink(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(Javax.Naming.Name arg0)
        {
            return IExecuteWithSignature("lookupLink", "(Ljavax/naming/Name;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#removeFromEnvironment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object RemoveFromEnvironment(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("removeFromEnvironment", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#composeName(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Java.Lang.String ComposeName(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("composeName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#createSubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Context>("createSubcontext", "(Ljava/lang/String;)Ljavax/naming/Context;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#createSubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(Javax.Naming.Name arg0)
        {
            return IExecuteWithSignature<Javax.Naming.Context>("createSubcontext", "(Ljavax/naming/Name;)Ljavax/naming/Context;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#composeName(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Name ComposeName(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            return IExecuteWithSignature<Javax.Naming.Name>("composeName", "(Ljavax/naming/Name;Ljavax/naming/Name;)Ljavax/naming/Name;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getNameParser(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Naming.NameParser>("getNameParser", "(Ljava/lang/String;)Ljavax/naming/NameParser;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#getNameParser(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(Javax.Naming.Name arg0)
        {
            return IExecuteWithSignature<Javax.Naming.NameParser>("getNameParser", "(Ljavax/naming/Name;)Ljavax/naming/NameParser;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#listBindings(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Naming.NamingEnumeration<Javax.Naming.Binding>>("listBindings", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#listBindings(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(Javax.Naming.Name arg0)
        {
            return IExecuteWithSignature<Javax.Naming.NamingEnumeration<Javax.Naming.Binding>>("listBindings", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#list(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair>>("list", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#list(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(Javax.Naming.Name arg0)
        {
            return IExecuteWithSignature<Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair>>("list", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#bind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(Java.Lang.String arg0, object arg1)
        {
            IExecuteWithSignature("bind", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#bind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(Javax.Naming.Name arg0, object arg1)
        {
            IExecuteWithSignature("bind", "(Ljavax/naming/Name;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#close()"/>
        /// </summary>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#destroySubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(Java.Lang.String arg0)
        {
            IExecuteWithSignature("destroySubcontext", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#destroySubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(Javax.Naming.Name arg0)
        {
            IExecuteWithSignature("destroySubcontext", "(Ljavax/naming/Name;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rebind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(Java.Lang.String arg0, object arg1)
        {
            IExecuteWithSignature("rebind", "(Ljava/lang/String;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rebind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(Javax.Naming.Name arg0, object arg1)
        {
            IExecuteWithSignature("rebind", "(Ljavax/naming/Name;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rename(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("rename", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#rename(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            IExecuteWithSignature("rename", "(Ljavax/naming/Name;Ljavax/naming/Name;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(Java.Lang.String arg0)
        {
            IExecuteWithSignature("unbind", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/InitialContext.html#unbind(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(Javax.Naming.Name arg0)
        {
            IExecuteWithSignature("unbind", "(Ljavax/naming/Name;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}