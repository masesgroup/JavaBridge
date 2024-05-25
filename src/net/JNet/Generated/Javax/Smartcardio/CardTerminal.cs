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

namespace Javax.Smartcardio
{
    #region CardTerminal
    public partial class CardTerminal
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminal.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminal.html#isCardPresent()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public bool IsCardPresent()
        {
            return IExecuteWithSignature<bool>("isCardPresent", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminal.html#waitForCardAbsent(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public bool WaitForCardAbsent(long arg0)
        {
            return IExecuteWithSignature<bool>("waitForCardAbsent", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminal.html#waitForCardPresent(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public bool WaitForCardPresent(long arg0)
        {
            return IExecuteWithSignature<bool>("waitForCardPresent", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.smartcardio/javax/smartcardio/CardTerminal.html#connect(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Smartcardio.Card"/></returns>
        /// <exception cref="Javax.Smartcardio.CardException"/>
        public Javax.Smartcardio.Card Connect(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Smartcardio.Card>("connect", "(Ljava/lang/String;)Ljavax/smartcardio/Card;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}