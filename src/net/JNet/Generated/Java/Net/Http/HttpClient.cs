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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net.Http
{
    #region HttpClient
    public partial class HttpClient
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#newHttpClient()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Http.HttpClient"/></returns>
        public static Java.Net.Http.HttpClient NewHttpClient()
        {
            return SExecuteWithSignature<Java.Net.Http.HttpClient>(LocalBridgeClazz, "newHttpClient", "()Ljava/net/http/HttpClient;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#newBuilder()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
        public static Java.Net.Http.HttpClient.Builder NewBuilder()
        {
            return SExecuteWithSignature<Java.Net.Http.HttpClient.Builder>(LocalBridgeClazz, "newBuilder", "()Ljava/net/http/HttpClient$Builder;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#send(java.net.http.HttpRequest,java.net.http.HttpResponse.BodyHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest"/></param>
        /// <param name="arg1"><see cref="Java.Net.Http.HttpResponse.BodyHandler"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Net.Http.HttpResponse"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Net.Http.HttpResponse<T> Send<T>(Java.Net.Http.HttpRequest arg0, Java.Net.Http.HttpResponse.BodyHandler<T> arg1)
        {
            return IExecute<Java.Net.Http.HttpResponse<T>>("send", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sendAsync(java.net.http.HttpRequest,java.net.http.HttpResponse.BodyHandler,java.net.http.HttpResponse.PushPromiseHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest"/></param>
        /// <param name="arg1"><see cref="Java.Net.Http.HttpResponse.BodyHandler"/></param>
        /// <param name="arg2"><see cref="Java.Net.Http.HttpResponse.PushPromiseHandler"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>> SendAsync<T>(Java.Net.Http.HttpRequest arg0, Java.Net.Http.HttpResponse.BodyHandler<T> arg1, Java.Net.Http.HttpResponse.PushPromiseHandler<T> arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>>>("sendAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sendAsync(java.net.http.HttpRequest,java.net.http.HttpResponse.BodyHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest"/></param>
        /// <param name="arg1"><see cref="Java.Net.Http.HttpResponse.BodyHandler"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>> SendAsync<T>(Java.Net.Http.HttpRequest arg0, Java.Net.Http.HttpResponse.BodyHandler<T> arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>>>("sendAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#followRedirects()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Http.HttpClient.Redirect"/></returns>
        public Java.Net.Http.HttpClient.Redirect FollowRedirects()
        {
            return IExecuteWithSignature<Java.Net.Http.HttpClient.Redirect>("followRedirects", "()Ljava/net/http/HttpClient$Redirect;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#version()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Http.HttpClient.Version"/></returns>
        public Java.Net.Http.HttpClient.Version VersionMethod()
        {
            return IExecuteWithSignature<Java.Net.Http.HttpClient.Version>("version", "()Ljava/net/http/HttpClient$Version;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#authenticator()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Net.Authenticator> Authenticator()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Net.Authenticator>>("authenticator", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#cookieHandler()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Net.CookieHandler> CookieHandler()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Net.CookieHandler>>("cookieHandler", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#proxy()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Net.ProxySelector> Proxy()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Net.ProxySelector>>("proxy", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#connectTimeout()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Time.Duration> ConnectTimeout()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Time.Duration>>("connectTimeout", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#executor()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Optional"/></returns>
        public Java.Util.Optional<Java.Util.Concurrent.Executor> Executor()
        {
            return IExecuteWithSignature<Java.Util.Optional<Java.Util.Concurrent.Executor>>("executor", "()Ljava/util/Optional;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sslContext()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLContext"/></returns>
        public Javax.Net.Ssl.SSLContext SslContext()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLContext>("sslContext", "()Ljavax/net/ssl/SSLContext;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sslParameters()"/>
        /// </summary>
        /// <returns><see cref="Javax.Net.Ssl.SSLParameters"/></returns>
        public Javax.Net.Ssl.SSLParameters SslParameters()
        {
            return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("sslParameters", "()Ljavax/net/ssl/SSLParameters;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#newWebSocketBuilder()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.Http.WebSocket.Builder"/></returns>
        public Java.Net.Http.WebSocket.Builder NewWebSocketBuilder()
        {
            return IExecuteWithSignature<Java.Net.Http.WebSocket.Builder>("newWebSocketBuilder", "()Ljava/net/http/WebSocket$Builder;");
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#NO_PROXY"/>
            /// </summary>
            public static Java.Net.ProxySelector NO_PROXY { get { if (!_NO_PROXYReady) { _NO_PROXYContent = SGetField<Java.Net.ProxySelector>(LocalBridgeClazz, "NO_PROXY"); _NO_PROXYReady = true; } return _NO_PROXYContent; } }
            private static Java.Net.ProxySelector _NO_PROXYContent = default;
            private static bool _NO_PROXYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#build()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpClient"/></returns>
            public Java.Net.Http.HttpClient Build()
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient>("build", "()Ljava/net/http/HttpClient;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#authenticator(java.net.Authenticator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Authenticator"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Authenticator(Java.Net.Authenticator arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("authenticator", "(Ljava/net/Authenticator;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#connectTimeout(java.time.Duration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder ConnectTimeout(Java.Time.Duration arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("connectTimeout", "(Ljava/time/Duration;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#cookieHandler(java.net.CookieHandler)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.CookieHandler"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder CookieHandler(Java.Net.CookieHandler arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("cookieHandler", "(Ljava/net/CookieHandler;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#executor(java.util.concurrent.Executor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Executor(Java.Util.Concurrent.Executor arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("executor", "(Ljava/util/concurrent/Executor;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#followRedirects(java.net.http.HttpClient.Redirect)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.HttpClient.Redirect"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder FollowRedirects(Java.Net.Http.HttpClient.Redirect arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("followRedirects", "(Ljava/net/http/HttpClient$Redirect;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#priority(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Priority(int arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("priority", "(I)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#proxy(java.net.ProxySelector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.ProxySelector"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Proxy(Java.Net.ProxySelector arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("proxy", "(Ljava/net/ProxySelector;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#sslContext(javax.net.ssl.SSLContext)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLContext"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder SslContext(Javax.Net.Ssl.SSLContext arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("sslContext", "(Ljavax/net/ssl/SSLContext;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#sslParameters(javax.net.ssl.SSLParameters)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLParameters"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder SslParameters(Javax.Net.Ssl.SSLParameters arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("sslParameters", "(Ljavax/net/ssl/SSLParameters;)Ljava/net/http/HttpClient$Builder;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#version(java.net.http.HttpClient.Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.HttpClient.Version"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder VersionMethod(Java.Net.Http.HttpClient.Version arg0)
            {
                return IExecuteWithSignature<Java.Net.Http.HttpClient.Builder>("version", "(Ljava/net/http/HttpClient$Version;)Ljava/net/http/HttpClient$Builder;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Redirect
        public partial class Redirect
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#ALWAYS"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Redirect ALWAYS { get { if (!_ALWAYSReady) { _ALWAYSContent = SGetField<Java.Net.Http.HttpClient.Redirect>(LocalBridgeClazz, "ALWAYS"); _ALWAYSReady = true; } return _ALWAYSContent; } }
            private static Java.Net.Http.HttpClient.Redirect _ALWAYSContent = default;
            private static bool _ALWAYSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#NEVER"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Redirect NEVER { get { if (!_NEVERReady) { _NEVERContent = SGetField<Java.Net.Http.HttpClient.Redirect>(LocalBridgeClazz, "NEVER"); _NEVERReady = true; } return _NEVERContent; } }
            private static Java.Net.Http.HttpClient.Redirect _NEVERContent = default;
            private static bool _NEVERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#NORMAL"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Redirect NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Java.Net.Http.HttpClient.Redirect>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
            private static Java.Net.Http.HttpClient.Redirect _NORMALContent = default;
            private static bool _NORMALReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Redirect"/></returns>
            public static Java.Net.Http.HttpClient.Redirect ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Net.Http.HttpClient.Redirect>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/net/http/HttpClient$Redirect;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpClient.Redirect"/></returns>
            public static Java.Net.Http.HttpClient.Redirect[] Values()
            {
                return SExecuteWithSignatureArray<Java.Net.Http.HttpClient.Redirect>(LocalBridgeClazz, "values", "()[Ljava/net/http/HttpClient$Redirect;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Version
        public partial class Version
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#HTTP_1_1"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Version HTTP_1_1 { get { if (!_HTTP_1_1Ready) { _HTTP_1_1Content = SGetField<Java.Net.Http.HttpClient.Version>(LocalBridgeClazz, "HTTP_1_1"); _HTTP_1_1Ready = true; } return _HTTP_1_1Content; } }
            private static Java.Net.Http.HttpClient.Version _HTTP_1_1Content = default;
            private static bool _HTTP_1_1Ready = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#HTTP_2"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Version HTTP_2 { get { if (!_HTTP_2Ready) { _HTTP_2Content = SGetField<Java.Net.Http.HttpClient.Version>(LocalBridgeClazz, "HTTP_2"); _HTTP_2Ready = true; } return _HTTP_2Content; } }
            private static Java.Net.Http.HttpClient.Version _HTTP_2Content = default;
            private static bool _HTTP_2Ready = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Version"/></returns>
            public static Java.Net.Http.HttpClient.Version ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Net.Http.HttpClient.Version>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/net/http/HttpClient$Version;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Net.Http.HttpClient.Version"/></returns>
            public static Java.Net.Http.HttpClient.Version[] Values()
            {
                return SExecuteWithSignatureArray<Java.Net.Http.HttpClient.Version>(LocalBridgeClazz, "values", "()[Ljava/net/http/HttpClient$Version;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}