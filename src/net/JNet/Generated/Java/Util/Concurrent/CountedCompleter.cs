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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region CountedCompleter
    public partial class CountedCompleter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getCompleter()"/> 
        /// </summary>
        public Java.Util.Concurrent.CountedCompleter Completer
        {
            get { return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("getCompleter", "()Ljava/util/concurrent/CountedCompleter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getPendingCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#setPendingCount(int)"/>
        /// </summary>
        public int PendingCount
        {
            get { return IExecuteWithSignature<int>("getPendingCount", "()I"); } set { IExecuteWithSignature("setPendingCount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getRoot()"/> 
        /// </summary>
        public Java.Util.Concurrent.CountedCompleter Root
        {
            get { return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("getRoot", "()Ljava/util/concurrent/CountedCompleter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#compute()"/>
        /// </summary>
        public void Compute()
        {
            IExecuteWithSignature("compute", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#onExceptionalCompletion(java.lang.Throwable,java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnExceptionalCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, Java.Util.Concurrent.CountedCompleter arg1)
        {
            return IExecute<bool>("onExceptionalCompletion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#compareAndSetPendingCount(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetPendingCount(int arg0, int arg1)
        {
            return IExecute<bool>("compareAndSetPendingCount", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#decrementPendingCountUnlessZero()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DecrementPendingCountUnlessZero()
        {
            return IExecuteWithSignature<int>("decrementPendingCountUnlessZero", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#firstComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter FirstComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("firstComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#nextComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter NextComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter>("nextComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#addToPendingCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddToPendingCount(int arg0)
        {
            IExecuteWithSignature("addToPendingCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#helpComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void HelpComplete(int arg0)
        {
            IExecuteWithSignature("helpComplete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#propagateCompletion()"/>
        /// </summary>
        public void PropagateCompletion()
        {
            IExecuteWithSignature("propagateCompletion", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#quietlyCompleteRoot()"/>
        /// </summary>
        public void QuietlyCompleteRoot()
        {
            IExecuteWithSignature("quietlyCompleteRoot", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#tryComplete()"/>
        /// </summary>
        public void TryComplete()
        {
            IExecuteWithSignature("tryComplete", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#onCompletion(java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        public void OnCompletion(Java.Util.Concurrent.CountedCompleter arg0)
        {
            IExecuteWithSignature("onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CountedCompleter<T>
    public partial class CountedCompleter<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CountedCompleter{T}"/> to <see cref="Java.Util.Concurrent.CountedCompleter"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.CountedCompleter(Java.Util.Concurrent.CountedCompleter<T> t) => t.Cast<Java.Util.Concurrent.CountedCompleter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getCompleter()"/> 
        /// </summary>
        public Java.Util.Concurrent.CountedCompleter<object> Completer
        {
            get { return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("getCompleter", "()Ljava/util/concurrent/CountedCompleter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getPendingCount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#setPendingCount(int)"/>
        /// </summary>
        public int PendingCount
        {
            get { return IExecuteWithSignature<int>("getPendingCount", "()I"); } set { IExecuteWithSignature("setPendingCount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#getRoot()"/> 
        /// </summary>
        public Java.Util.Concurrent.CountedCompleter<object> Root
        {
            get { return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("getRoot", "()Ljava/util/concurrent/CountedCompleter;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#compute()"/>
        /// </summary>
        public void Compute()
        {
            IExecuteWithSignature("compute", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#onExceptionalCompletion(java.lang.Throwable,java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Throwable"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OnExceptionalCompletion(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0, Java.Util.Concurrent.CountedCompleter<object> arg1)
        {
            return IExecute<bool>("onExceptionalCompletion", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#compareAndSetPendingCount(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSetPendingCount(int arg0, int arg1)
        {
            return IExecute<bool>("compareAndSetPendingCount", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#decrementPendingCountUnlessZero()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DecrementPendingCountUnlessZero()
        {
            return IExecuteWithSignature<int>("decrementPendingCountUnlessZero", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#firstComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter<object> FirstComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("firstComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#nextComplete()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Concurrent.CountedCompleter"/></returns>
        public Java.Util.Concurrent.CountedCompleter<object> NextComplete()
        {
            return IExecuteWithSignature<Java.Util.Concurrent.CountedCompleter<object>>("nextComplete", "()Ljava/util/concurrent/CountedCompleter;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#addToPendingCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AddToPendingCount(int arg0)
        {
            IExecuteWithSignature("addToPendingCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#helpComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void HelpComplete(int arg0)
        {
            IExecuteWithSignature("helpComplete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#propagateCompletion()"/>
        /// </summary>
        public void PropagateCompletion()
        {
            IExecuteWithSignature("propagateCompletion", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#quietlyCompleteRoot()"/>
        /// </summary>
        public void QuietlyCompleteRoot()
        {
            IExecuteWithSignature("quietlyCompleteRoot", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#tryComplete()"/>
        /// </summary>
        public void TryComplete()
        {
            IExecuteWithSignature("tryComplete", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CountedCompleter.html#onCompletion(java.util.concurrent.CountedCompleter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.CountedCompleter"/></param>
        public void OnCompletion(Java.Util.Concurrent.CountedCompleter<object> arg0)
        {
            IExecuteWithSignature("onCompletion", "(Ljava/util/concurrent/CountedCompleter;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}