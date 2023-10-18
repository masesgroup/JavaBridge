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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region InputEvent
    public partial class InputEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#ALT_DOWN_MASK"/>
        /// </summary>
        public static int ALT_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "ALT_DOWN_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#ALT_GRAPH_DOWN_MASK"/>
        /// </summary>
        public static int ALT_GRAPH_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "ALT_GRAPH_DOWN_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#BUTTON1_DOWN_MASK"/>
        /// </summary>
        public static int BUTTON1_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "BUTTON1_DOWN_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#BUTTON2_DOWN_MASK"/>
        /// </summary>
        public static int BUTTON2_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "BUTTON2_DOWN_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#BUTTON3_DOWN_MASK"/>
        /// </summary>
        public static int BUTTON3_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "BUTTON3_DOWN_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#CTRL_DOWN_MASK"/>
        /// </summary>
        public static int CTRL_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "CTRL_DOWN_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#META_DOWN_MASK"/>
        /// </summary>
        public static int META_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "META_DOWN_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#SHIFT_DOWN_MASK"/>
        /// </summary>
        public static int SHIFT_DOWN_MASK { get { return SGetField<int>(LocalBridgeClazz, "SHIFT_DOWN_MASK"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getMaskForButton(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMaskForButton(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getMaskForButton", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getModifiersExText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string GetModifiersExText(int arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "getModifiersExText", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getModifiersEx()"/> 
        /// </summary>
        public int ModifiersEx
        {
            get { return IExecute<int>("getModifiersEx"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getWhen()"/> 
        /// </summary>
        public long When
        {
            get { return IExecute<long>("getWhen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isAltDown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAltDown()
        {
            return IExecute<bool>("isAltDown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isAltGraphDown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAltGraphDown()
        {
            return IExecute<bool>("isAltGraphDown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isConsumed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsConsumed()
        {
            return IExecute<bool>("isConsumed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isControlDown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsControlDown()
        {
            return IExecute<bool>("isControlDown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isMetaDown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMetaDown()
        {
            return IExecute<bool>("isMetaDown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isShiftDown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsShiftDown()
        {
            return IExecute<bool>("isShiftDown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#consume()"/>
        /// </summary>
        public void Consume()
        {
            IExecute("consume");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}