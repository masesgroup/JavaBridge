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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Xml.Sax.Helpers
{
    #region NamespaceSupport
    public partial class NamespaceSupport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#NSDECL"/>
        /// </summary>
        public static Java.Lang.String NSDECL { get { if (!_NSDECLReady) { _NSDECLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NSDECL"); _NSDECLReady = true; } return _NSDECLContent; } }
        private static Java.Lang.String _NSDECLContent = default;
        private static bool _NSDECLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#XMLNS"/>
        /// </summary>
        public static Java.Lang.String XMLNS { get { if (!_XMLNSReady) { _XMLNSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "XMLNS"); _XMLNSReady = true; } return _XMLNSContent; } }
        private static Java.Lang.String _XMLNSContent = default;
        private static bool _XMLNSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getDeclaredPrefixes()"/> 
        /// </summary>
        public Java.Util.Enumeration<Java.Lang.String> DeclaredPrefixes
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("getDeclaredPrefixes", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getPrefixes()"/> 
        /// </summary>
        public Java.Util.Enumeration<Java.Lang.String> Prefixes
        {
            get { return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("getPrefixes", "()Ljava/util/Enumeration;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#declarePrefix(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool DeclarePrefix(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<bool>("declarePrefix", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#isNamespaceDeclUris()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsNamespaceDeclUris()
        {
            return IExecuteWithSignature<bool>("isNamespaceDeclUris", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getPrefix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetPrefix(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getPrefix", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getURI(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetURI(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getURI", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#processName(java.lang.String,java.lang.String[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] ProcessName(Java.Lang.String arg0, Java.Lang.String[] arg1, bool arg2)
        {
            return IExecuteArray<Java.Lang.String>("processName", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#getPrefixes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Lang.String> GetPrefixes(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Enumeration<Java.Lang.String>>("getPrefixes", "(Ljava/lang/String;)Ljava/util/Enumeration;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#popContext()"/>
        /// </summary>
        public void PopContext()
        {
            IExecuteWithSignature("popContext", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#pushContext()"/>
        /// </summary>
        public void PushContext()
        {
            IExecuteWithSignature("pushContext", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/xml/sax/helpers/NamespaceSupport.html#setNamespaceDeclUris(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetNamespaceDeclUris(bool arg0)
        {
            IExecuteWithSignature("setNamespaceDeclUris", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}