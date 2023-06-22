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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region IIntConsumer
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.function.IntConsumer implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html"/>
    /// </summary>
    public partial interface IIntConsumer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        void Accept(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.IntConsumer"/></returns>
        Java.Util.Function.IntConsumer AndThen(Java.Util.Function.IntConsumer arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IntConsumer
    public partial class IntConsumer : Java.Util.Function.IIntConsumer
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
        /// Handlers initializer for <see cref="IntConsumer"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("accept", new System.EventHandler<CLRListenerEventArgs<CLREventData<int>>>(AcceptEventHandler)); OnAccept = Accept;
            AddEventHandler("andThen", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Function.IntConsumer>>>(AndThenEventHandler)); OnAndThen = AndThen;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        public System.Action<int> OnAccept { get; set; }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            if (OnAccept != null) OnAccept.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public virtual void Accept(int arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        public System.Func<Java.Util.Function.IntConsumer, Java.Util.Function.IntConsumer> OnAndThen { get; set; }

        void AndThenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Function.IntConsumer>> data)
        {
            if (OnAndThen != null)
            {
                var executionResult = OnAndThen.Invoke(data.EventData.TypedEventData);
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.IntConsumer"/></returns>
        public virtual Java.Util.Function.IntConsumer AndThen(Java.Util.Function.IntConsumer arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}