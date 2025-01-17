﻿/*
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

using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java LongSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongSupplier.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongSupplier : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsInt result</returns>
        long GetAsLong();
    }

    /// <summary>
    /// Listener for Java LongSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongSupplier.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class LongSupplier : JVMBridgeListener, ILongSupplier
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.LongSupplier";

        /// <summary>
        /// The <see cref="Func{Int64}"/> to be executed
        /// </summary>
        public virtual Func<long> OnGetAsLong { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="LongSupplier"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Int64}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public LongSupplier(Func<long> func = null, bool attachEventHandler = true)
        {
            if (InitHandlers)
            {
                AddEventHandler("getAsLong", new EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsLongEventHandler)); OnGetAsLong = GetAsLong;
            }
        }

        void GetAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var retVal = OnGetAsLong();
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsInt result</returns>
        public virtual long GetAsLong() { return default(long); }
    }

    /// <summary>
    /// Direct override of <see cref="LongSupplier"/> or its generic type if there is one
    /// </summary>
    public partial class LongSupplierDirect : LongSupplier
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongSupplier";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongSupplier.html#getAsLong()"/> 
        /// </summary>
        public override long GetAsLong()
        {
            return IExecuteWithSignature<long>("getAsLong", "()J");
        }
    }
}
