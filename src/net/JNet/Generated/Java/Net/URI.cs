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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region URI
    public partial class URI
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,int,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, int arg3, Java.Lang.String arg4, Java.Lang.String arg5, Java.Lang.String arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3, Java.Lang.String arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2, Java.Lang.String arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public URI(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Net.URI"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Net.URI t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Net.URI"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Net.URI t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#create(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public static Java.Net.URI Create(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Net.URI>(LocalBridgeClazz, "create", "(Ljava/lang/String;)Ljava/net/URI;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getAuthority()"/> 
        /// </summary>
        public Java.Lang.String Authority
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAuthority", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getFragment()"/> 
        /// </summary>
        public Java.Lang.String Fragment
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFragment", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getHost()"/> 
        /// </summary>
        public Java.Lang.String Host
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getHost", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getPath()"/> 
        /// </summary>
        public Java.Lang.String Path
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getPort()"/> 
        /// </summary>
        public int Port
        {
            get { return IExecuteWithSignature<int>("getPort", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getQuery()"/> 
        /// </summary>
        public Java.Lang.String Query
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getQuery", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawAuthority()"/> 
        /// </summary>
        public Java.Lang.String RawAuthority
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRawAuthority", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawFragment()"/> 
        /// </summary>
        public Java.Lang.String RawFragment
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRawFragment", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawPath()"/> 
        /// </summary>
        public Java.Lang.String RawPath
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRawPath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawQuery()"/> 
        /// </summary>
        public Java.Lang.String RawQuery
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRawQuery", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawSchemeSpecificPart()"/> 
        /// </summary>
        public Java.Lang.String RawSchemeSpecificPart
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRawSchemeSpecificPart", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getRawUserInfo()"/> 
        /// </summary>
        public Java.Lang.String RawUserInfo
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRawUserInfo", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getScheme()"/> 
        /// </summary>
        public Java.Lang.String Scheme
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getScheme", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getSchemeSpecificPart()"/> 
        /// </summary>
        public Java.Lang.String SchemeSpecificPart
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSchemeSpecificPart", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#getUserInfo()"/> 
        /// </summary>
        public Java.Lang.String UserInfo
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUserInfo", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#isAbsolute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAbsolute()
        {
            return IExecuteWithSignature<bool>("isAbsolute", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#isOpaque()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOpaque()
        {
            return IExecuteWithSignature<bool>("isOpaque", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#compareTo(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/net/URI;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#toASCIIString()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToASCIIString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toASCIIString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#normalize()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Normalize()
        {
            return IExecuteWithSignature<Java.Net.URI>("normalize", "()Ljava/net/URI;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#parseServerAuthority()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public Java.Net.URI ParseServerAuthority()
        {
            return IExecuteWithSignature<Java.Net.URI>("parseServerAuthority", "()Ljava/net/URI;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#relativize(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Relativize(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<Java.Net.URI>("relativize", "(Ljava/net/URI;)Ljava/net/URI;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#resolve(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Resolve(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Net.URI>("resolve", "(Ljava/lang/String;)Ljava/net/URI;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#resolve(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI Resolve(Java.Net.URI arg0)
        {
            return IExecuteWithSignature<Java.Net.URI>("resolve", "(Ljava/net/URI;)Ljava/net/URI;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URI.html#toURL()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public Java.Net.URL ToURL()
        {
            return IExecuteWithSignature<Java.Net.URL>("toURL", "()Ljava/net/URL;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}