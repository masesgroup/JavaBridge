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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Process
    public partial class Process
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#getErrorStream()"/> 
        /// </summary>
        public Java.Io.InputStream ErrorStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getErrorStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#getInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream InputStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getInputStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#getOutputStream()"/> 
        /// </summary>
        public Java.Io.OutputStream OutputStream
        {
            get { return IExecuteWithSignature<Java.Io.OutputStream>("getOutputStream", "()Ljava/io/OutputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#exitValue()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ExitValue()
        {
            return IExecuteWithSignature<int>("exitValue", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#waitFor()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public int WaitFor()
        {
            return IExecuteWithSignature<int>("waitFor", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#isAlive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlive()
        {
            return IExecuteWithSignature<bool>("isAlive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#supportsNormalTermination()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsNormalTermination()
        {
            return IExecuteWithSignature<bool>("supportsNormalTermination", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#waitFor(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool WaitFor(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("waitFor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#destroyForcibly()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Process"/></returns>
        public Java.Lang.Process DestroyForcibly()
        {
            return IExecuteWithSignature<Java.Lang.Process>("destroyForcibly", "()Ljava/lang/Process;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#toHandle()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ProcessHandle"/></returns>
        public Java.Lang.ProcessHandle ToHandle()
        {
            return IExecuteWithSignature<Java.Lang.ProcessHandle>("toHandle", "()Ljava/lang/ProcessHandle;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#info()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.ProcessHandle.Info"/></returns>
        public Java.Lang.ProcessHandle.Info Info()
        {
            return IExecuteWithSignature<Java.Lang.ProcessHandle.Info>("info", "()Ljava/lang/ProcessHandle$Info;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#onExit()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Lang.Process> OnExit()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CompletableFuture<Java.Lang.Process>>("onExit", "()Ljava/util/concurrent/CompletableFuture;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#children()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Children()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>("children", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#descendants()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Lang.ProcessHandle> Descendants()
        {
            return IExecuteWithSignature<Java.Util.Stream.Stream<Java.Lang.ProcessHandle>>("descendants", "()Ljava/util/stream/Stream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Process.html#pid()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Pid()
        {
            return IExecuteWithSignature<long>("pid", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}