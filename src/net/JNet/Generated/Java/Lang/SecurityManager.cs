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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region SecurityManager
    public partial class SecurityManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#getSecurityContext()"/> 
        /// </summary>
        public object SecurityContext
        {
            get { return IExecuteWithSignature("getSecurityContext", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#getThreadGroup()"/> 
        /// </summary>
        public Java.Lang.ThreadGroup ThreadGroup
        {
            get { return IExecuteWithSignature<Java.Lang.ThreadGroup>("getThreadGroup", "()Ljava/lang/ThreadGroup;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkAccept(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void CheckAccept(Java.Lang.String arg0, int arg1)
        {
            IExecute("checkAccept", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkAccess(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        public void CheckAccess(Java.Lang.Thread arg0)
        {
            IExecuteWithSignature("checkAccess", "(Ljava/lang/Thread;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkAccess(java.lang.ThreadGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        public void CheckAccess(Java.Lang.ThreadGroup arg0)
        {
            IExecuteWithSignature("checkAccess", "(Ljava/lang/ThreadGroup;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkConnect(java.lang.String,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void CheckConnect(Java.Lang.String arg0, int arg1, object arg2)
        {
            IExecute("checkConnect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkConnect(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void CheckConnect(Java.Lang.String arg0, int arg1)
        {
            IExecute("checkConnect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkCreateClassLoader()"/>
        /// </summary>
        public void CheckCreateClassLoader()
        {
            IExecuteWithSignature("checkCreateClassLoader", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkDelete(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckDelete(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkDelete", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkExec(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckExec(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkExec", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkExit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void CheckExit(int arg0)
        {
            IExecuteWithSignature("checkExit", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkLink(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckLink(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkLink", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkListen(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void CheckListen(int arg0)
        {
            IExecuteWithSignature("checkListen", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkMulticast(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        public void CheckMulticast(Java.Net.InetAddress arg0)
        {
            IExecuteWithSignature("checkMulticast", "(Ljava/net/InetAddress;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkPackageAccess(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckPackageAccess(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkPackageAccess", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkPackageDefinition(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckPackageDefinition(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkPackageDefinition", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkPermission(java.security.Permission,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void CheckPermission(Java.Security.Permission arg0, object arg1)
        {
            IExecute("checkPermission", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkPermission(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        public void CheckPermission(Java.Security.Permission arg0)
        {
            IExecuteWithSignature("checkPermission", "(Ljava/security/Permission;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkPrintJobAccess()"/>
        /// </summary>
        public void CheckPrintJobAccess()
        {
            IExecuteWithSignature("checkPrintJobAccess", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkPropertiesAccess()"/>
        /// </summary>
        public void CheckPropertiesAccess()
        {
            IExecuteWithSignature("checkPropertiesAccess", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkPropertyAccess(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckPropertyAccess(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkPropertyAccess", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkRead(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        public void CheckRead(Java.Io.FileDescriptor arg0)
        {
            IExecuteWithSignature("checkRead", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkRead(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void CheckRead(Java.Lang.String arg0, object arg1)
        {
            IExecute("checkRead", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkRead(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckRead(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkRead", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkSecurityAccess(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckSecurityAccess(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkSecurityAccess", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkSetFactory()"/>
        /// </summary>
        public void CheckSetFactory()
        {
            IExecuteWithSignature("checkSetFactory", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkWrite(java.io.FileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileDescriptor"/></param>
        public void CheckWrite(Java.Io.FileDescriptor arg0)
        {
            IExecuteWithSignature("checkWrite", "(Ljava/io/FileDescriptor;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/SecurityManager.html#checkWrite(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void CheckWrite(Java.Lang.String arg0)
        {
            IExecuteWithSignature("checkWrite", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}