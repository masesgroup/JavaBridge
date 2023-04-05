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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels
{
    #region Selector
    public partial class Selector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.Selector"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Nio.Channels.Selector t) => t.Cast<Java.Io.Closeable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#open()"/> 
        /// </summary>
        public static Java.Nio.Channels.Selector Open
        {
            get { return SExecute<Java.Nio.Channels.Selector>("open"); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#isOpen()"/> 
        /// </summary>
        public bool IsOpen
        {
            get { return IExecute<bool>("isOpen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#keys()"/> 
        /// </summary>
        public Java.Util.Set<Java.Nio.Channels.SelectionKey> Keys
        {
            get { return IExecute<Java.Util.Set<Java.Nio.Channels.SelectionKey>>("keys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#provider()"/> 
        /// </summary>
        public Java.Nio.Channels.Spi.SelectorProvider Provider
        {
            get { return IExecute<Java.Nio.Channels.Spi.SelectorProvider>("provider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#selectedKeys()"/> 
        /// </summary>
        public Java.Util.Set<Java.Nio.Channels.SelectionKey> SelectedKeys
        {
            get { return IExecute<Java.Util.Set<Java.Nio.Channels.SelectionKey>>("selectedKeys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#wakeup()"/> 
        /// </summary>
        public Java.Nio.Channels.Selector Wakeup
        {
            get { return IExecute<Java.Nio.Channels.Selector>("wakeup"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#select()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Select()
        {
            return IExecute<int>("select");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#select(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Select(long arg0)
        {
            return IExecute<int>("select", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#selectNow()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SelectNow()
        {
            return IExecute<int>("selectNow");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#close()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#select(java.util.function.Consumer,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Select(Java.Util.Function.Consumer<Java.Nio.Channels.SelectionKey> arg0, long arg1)
        {
            return IExecute<int>("select", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#select(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Select(Java.Util.Function.Consumer<Java.Nio.Channels.SelectionKey> arg0)
        {
            return IExecute<int>("select", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/Selector.html#selectNow(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SelectNow(Java.Util.Function.Consumer<Java.Nio.Channels.SelectionKey> arg0)
        {
            return IExecute<int>("selectNow", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}