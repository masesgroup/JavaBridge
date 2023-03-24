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

namespace Java.Lang.Management
{
    #region PlatformLoggingMXBean
    public partial class PlatformLoggingMXBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Lang.Management.PlatformLoggingMXBean"/> to <see cref="Java.Lang.Management.PlatformManagedObject"/>
        /// </summary>
        public static implicit operator Java.Lang.Management.PlatformManagedObject(Java.Lang.Management.PlatformLoggingMXBean t) => t.Cast<Java.Lang.Management.PlatformManagedObject>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/PlatformLoggingMXBean.html#getLoggerNames()"/> 
        /// </summary>
        public Java.Util.List LoggerNames
        {
            get { return IExecute<Java.Util.List>("getLoggerNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/PlatformLoggingMXBean.html#getLoggerLevel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetLoggerLevel(string arg0)
        {
            return IExecute<string>("getLoggerLevel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/PlatformLoggingMXBean.html#getParentLoggerName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetParentLoggerName(string arg0)
        {
            return IExecute<string>("getParentLoggerName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/PlatformLoggingMXBean.html#setLoggerLevel(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void SetLoggerLevel(string arg0, string arg1)
        {
            IExecute("setLoggerLevel", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}