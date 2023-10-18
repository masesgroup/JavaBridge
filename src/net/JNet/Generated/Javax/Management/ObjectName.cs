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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region ObjectName
    public partial class ObjectName
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public ObjectName(string arg0, string arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#%3Cinit%3E(java.lang.String,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Hashtable"/></param>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public ObjectName(string arg0, Java.Util.Hashtable<string, string> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public ObjectName(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.ObjectName"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Javax.Management.ObjectName t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.ObjectName"/> to <see cref="Javax.Management.QueryExp"/>
        /// </summary>
        public static implicit operator Javax.Management.QueryExp(Javax.Management.ObjectName t) => t.Cast<Javax.Management.QueryExp>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#WILDCARD"/>
        /// </summary>
        public static Javax.Management.ObjectName WILDCARD { get { return SGetField<Javax.Management.ObjectName>(LocalBridgeClazz, "WILDCARD"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#quote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Quote(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "quote", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#unquote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string Unquote(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "unquote", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public static Javax.Management.ObjectName GetInstance(string arg0, string arg1, string arg2)
        {
            return SExecute<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(java.lang.String,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public static Javax.Management.ObjectName GetInstance(string arg0, Java.Util.Hashtable<string, string> arg1)
        {
            return SExecute<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        /// <exception cref="Java.Lang.NullPointerException"/>
        public static Javax.Management.ObjectName GetInstance(string arg0)
        {
            return SExecute<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        public static Javax.Management.ObjectName GetInstance(Javax.Management.ObjectName arg0)
        {
            return SExecute<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getCanonicalKeyPropertyListString()"/> 
        /// </summary>
        public string CanonicalKeyPropertyListString
        {
            get { return IExecute<string>("getCanonicalKeyPropertyListString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getCanonicalName()"/> 
        /// </summary>
        public string CanonicalName
        {
            get { return IExecute<string>("getCanonicalName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getDomain()"/> 
        /// </summary>
        public string Domain
        {
            get { return IExecute<string>("getDomain"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getKeyPropertyList()"/> 
        /// </summary>
        public Java.Util.Hashtable<string, string> KeyPropertyList
        {
            get { return IExecute<Java.Util.Hashtable<string, string>>("getKeyPropertyList"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getKeyPropertyListString()"/> 
        /// </summary>
        public string KeyPropertyListString
        {
            get { return IExecute<string>("getKeyPropertyListString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#apply(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Apply(Javax.Management.ObjectName arg0)
        {
            return IExecute<bool>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isDomainPattern()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDomainPattern()
        {
            return IExecute<bool>("isDomainPattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPattern()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPattern()
        {
            return IExecute<bool>("isPattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyListPattern()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyListPattern()
        {
            return IExecute<bool>("isPropertyListPattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyPattern()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyPattern()
        {
            return IExecute<bool>("isPropertyPattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyValuePattern()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyValuePattern()
        {
            return IExecute<bool>("isPropertyValuePattern");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyValuePattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyValuePattern(string arg0)
        {
            return IExecute<bool>("isPropertyValuePattern", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#compareTo(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Javax.Management.ObjectName arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getKeyProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetKeyProperty(string arg0)
        {
            return IExecute<string>("getKeyProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#setMBeanServer(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        public void SetMBeanServer(Javax.Management.MBeanServer arg0)
        {
            IExecute("setMBeanServer", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}