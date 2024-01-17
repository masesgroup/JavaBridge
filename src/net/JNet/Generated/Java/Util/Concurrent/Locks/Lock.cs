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
*  This file is generated by MASES.JNetReflector (ver. 2.2.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent.Locks
{
    #region ILock
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILock
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#tryLock()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool TryLock();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#tryLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        bool TryLock(long arg0, Java.Util.Concurrent.TimeUnit arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#newCondition()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Locks.Condition"/></returns>
        Java.Util.Concurrent.Locks.Condition NewCondition();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#lock()"/>
        /// </summary>
        void LockMethod();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#lockInterruptibly()"/>
        /// </summary>

        /// <exception cref="Java.Lang.InterruptedException"/>
        void LockInterruptibly();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#unlock()"/>
        /// </summary>
        void Unlock();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Lock
    public partial class Lock : Java.Util.Concurrent.Locks.ILock
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#tryLock()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool TryLock()
        {
            return IExecute<bool>("tryLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#tryLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("tryLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#newCondition()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Locks.Condition"/></returns>
        public Java.Util.Concurrent.Locks.Condition NewCondition()
        {
            return IExecute<Java.Util.Concurrent.Locks.Condition>("newCondition");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#lock()"/>
        /// </summary>
        public void LockMethod()
        {
            IExecute("lock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#lockInterruptibly()"/>
        /// </summary>

        /// <exception cref="Java.Lang.InterruptedException"/>
        public void LockInterruptibly()
        {
            IExecute("lockInterruptibly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/Lock.html#unlock()"/>
        /// </summary>
        public void Unlock()
        {
            IExecute("unlock");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}