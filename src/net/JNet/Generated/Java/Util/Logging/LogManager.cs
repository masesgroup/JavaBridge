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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Logging
{
    #region LogManager
    public partial class LogManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#LOGGING_MXBEAN_NAME"/>
        /// </summary>
        public static string LOGGING_MXBEAN_NAME { get { return SGetField<string>(LocalBridgeClazz, "LOGGING_MXBEAN_NAME"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getLogManager()"/> 
        /// </summary>
        public static Java.Util.Logging.LogManager GetLogManager
        {
            get { return SExecute<Java.Util.Logging.LogManager>(LocalBridgeClazz, "getLogManager"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getLoggerNames()"/> 
        /// </summary>
        public Java.Util.Enumeration<string> LoggerNames
        {
            get { return IExecute<Java.Util.Enumeration<string>>("getLoggerNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#addLogger(java.util.logging.Logger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Logging.Logger"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddLogger(Java.Util.Logging.Logger arg0)
        {
            return IExecute<bool>("addLogger", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetProperty(string arg0)
        {
            return IExecute<string>("getProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#getLogger(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Logging.Logger"/></returns>
        public Java.Util.Logging.Logger GetLogger(string arg0)
        {
            return IExecute<Java.Util.Logging.Logger>("getLogger", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#addConfigurationListener(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Logging.LogManager"/></returns>
        public Java.Util.Logging.LogManager AddConfigurationListener(Java.Lang.Runnable arg0)
        {
            return IExecute<Java.Util.Logging.LogManager>("addConfigurationListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#checkAccess()"/>
        /// </summary>

        /// <exception cref="Java.Lang.SecurityException"/>
        public void CheckAccess()
        {
            IExecute("checkAccess");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#readConfiguration()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ReadConfiguration()
        {
            IExecute("readConfiguration");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#readConfiguration(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void ReadConfiguration(Java.Io.InputStream arg0)
        {
            IExecute("readConfiguration", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#removeConfigurationListener(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void RemoveConfigurationListener(Java.Lang.Runnable arg0)
        {
            IExecute("removeConfigurationListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#reset()"/>
        /// </summary>

        /// <exception cref="Java.Lang.SecurityException"/>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#updateConfiguration(java.io.InputStream,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void UpdateConfiguration(Java.Io.InputStream arg0, Java.Util.Function.Function<string, Java.Util.Function.BiFunction<string, string, string>> arg1)
        {
            IExecute("updateConfiguration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.logging/java/util/logging/LogManager.html#updateConfiguration(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void UpdateConfiguration(Java.Util.Function.Function<string, Java.Util.Function.BiFunction<string, string, string>> arg0)
        {
            IExecute("updateConfiguration", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}