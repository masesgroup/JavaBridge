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

namespace Java.Net
{
    #region URLConnection
    public partial class URLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDefaultAllowUserInteraction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDefaultAllowUserInteraction(boolean)"/>
        /// </summary>
        public static bool DefaultAllowUserInteraction
        {
            get { return SExecuteWithSignature<bool>(LocalBridgeClazz, "getDefaultAllowUserInteraction", "()Z"); } set { SExecuteWithSignature(LocalBridgeClazz, "setDefaultAllowUserInteraction", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getFileNameMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setFileNameMap(java.net.FileNameMap)"/>
        /// </summary>
        public static Java.Net.FileNameMap FileNameMap
        {
            get { return SExecuteWithSignature<Java.Net.FileNameMap>(LocalBridgeClazz, "getFileNameMap", "()Ljava/net/FileNameMap;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setFileNameMap", "(Ljava/net/FileNameMap;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDefaultUseCaches(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetDefaultUseCaches(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "getDefaultUseCaches", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#guessContentTypeFromName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GuessContentTypeFromName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "guessContentTypeFromName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#guessContentTypeFromStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Lang.String GuessContentTypeFromStream(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "guessContentTypeFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setContentHandlerFactory(java.net.ContentHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ContentHandlerFactory"/></param>
        public static void SetContentHandlerFactory(Java.Net.ContentHandlerFactory arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setContentHandlerFactory", "(Ljava/net/ContentHandlerFactory;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDefaultUseCaches(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public static void SetDefaultUseCaches(Java.Lang.String arg0, bool arg1)
        {
            SExecute(LocalBridgeClazz, "setDefaultUseCaches", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getAllowUserInteraction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setAllowUserInteraction(boolean)"/>
        /// </summary>
        public bool AllowUserInteraction
        {
            get { return IExecuteWithSignature<bool>("getAllowUserInteraction", "()Z"); } set { IExecuteWithSignature("setAllowUserInteraction", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getConnectTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setConnectTimeout(int)"/>
        /// </summary>
        public int ConnectTimeout
        {
            get { return IExecuteWithSignature<int>("getConnectTimeout", "()I"); } set { IExecuteWithSignature("setConnectTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContent()"/> 
        /// </summary>
        public object Content
        {
            get { return IExecuteWithSignature("getContent", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentEncoding()"/> 
        /// </summary>
        public Java.Lang.String ContentEncoding
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getContentEncoding", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentLength()"/> 
        /// </summary>
        public int ContentLength
        {
            get { return IExecuteWithSignature<int>("getContentLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentLengthLong()"/> 
        /// </summary>
        public long ContentLengthLong
        {
            get { return IExecuteWithSignature<long>("getContentLengthLong", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentType()"/> 
        /// </summary>
        public Java.Lang.String ContentType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getContentType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDate()"/> 
        /// </summary>
        public long Date
        {
            get { return IExecuteWithSignature<long>("getDate", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDefaultUseCaches()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDefaultUseCaches(boolean)"/>
        /// </summary>
        public bool DefaultUseCaches
        {
            get { return IExecuteWithSignature<bool>("getDefaultUseCaches", "()Z"); } set { IExecuteWithSignature("setDefaultUseCaches", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDoInput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDoInput(boolean)"/>
        /// </summary>
        public bool DoInput
        {
            get { return IExecuteWithSignature<bool>("getDoInput", "()Z"); } set { IExecuteWithSignature("setDoInput", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDoOutput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDoOutput(boolean)"/>
        /// </summary>
        public bool DoOutput
        {
            get { return IExecuteWithSignature<bool>("getDoOutput", "()Z"); } set { IExecuteWithSignature("setDoOutput", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getExpiration()"/> 
        /// </summary>
        public long Expiration
        {
            get { return IExecuteWithSignature<long>("getExpiration", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFields()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> HeaderFields
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("getHeaderFields", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getIfModifiedSince()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setIfModifiedSince(long)"/>
        /// </summary>
        public long IfModifiedSince
        {
            get { return IExecuteWithSignature<long>("getIfModifiedSince", "()J"); } set { IExecuteWithSignature("setIfModifiedSince", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream InputStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getLastModified()"/> 
        /// </summary>
        public long LastModified
        {
            get { return IExecuteWithSignature<long>("getLastModified", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getOutputStream()"/> 
        /// </summary>
        public Java.Io.OutputStream OutputStream
        {
            get { return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getPermission()"/> 
        /// </summary>
        public Java.Security.Permission Permission
        {
            get { return IExecuteWithSignature<Java.Security.Permission>("getPermission", "()Ljava/security/Permission;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getReadTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setReadTimeout(int)"/>
        /// </summary>
        public int ReadTimeout
        {
            get { return IExecuteWithSignature<int>("getReadTimeout", "()I"); } set { IExecuteWithSignature("setReadTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getRequestProperties()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> RequestProperties
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("getRequestProperties", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getURL()"/> 
        /// </summary>
        public Java.Net.URL URL
        {
            get { return IExecuteWithSignature<Java.Net.URL>("getURL", "()Ljava/net/URL;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getUseCaches()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setUseCaches(boolean)"/>
        /// </summary>
        public bool UseCaches
        {
            get { return IExecuteWithSignature<bool>("getUseCaches", "()Z"); } set { IExecuteWithSignature("setUseCaches", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetHeaderFieldInt(Java.Lang.String arg0, int arg1)
        {
            return IExecute<int>("getHeaderFieldInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContent(java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetContent(Java.Lang.Class[] arg0)
        {
            return IExecuteWithSignature("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderField(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHeaderField(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getHeaderField", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHeaderField(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetHeaderFieldKey(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getHeaderFieldKey", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getRequestProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetRequestProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldDate(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetHeaderFieldDate(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("getHeaderFieldDate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetHeaderFieldLong(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("getHeaderFieldLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#addRequestProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void AddRequestProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("addRequestProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setRequestProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetRequestProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("setRequestProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}