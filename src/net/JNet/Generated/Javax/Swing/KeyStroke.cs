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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region KeyStroke
    public partial class KeyStroke
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/KeyStroke.html#getKeyStroke(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public static Javax.Swing.KeyStroke GetKeyStroke(char arg0)
        {
            return SExecuteWithSignature<Javax.Swing.KeyStroke>(LocalBridgeClazz, "getKeyStroke", "(C)Ljavax/swing/KeyStroke;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/KeyStroke.html#getKeyStroke(int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public static Javax.Swing.KeyStroke GetKeyStroke(int arg0, int arg1, bool arg2)
        {
            return SExecute<Javax.Swing.KeyStroke>(LocalBridgeClazz, "getKeyStroke", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/KeyStroke.html#getKeyStroke(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public static Javax.Swing.KeyStroke GetKeyStroke(int arg0, int arg1)
        {
            return SExecute<Javax.Swing.KeyStroke>(LocalBridgeClazz, "getKeyStroke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/KeyStroke.html#getKeyStroke(java.lang.Character,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Character"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public static Javax.Swing.KeyStroke GetKeyStroke(Java.Lang.Character arg0, int arg1)
        {
            return SExecute<Javax.Swing.KeyStroke>(LocalBridgeClazz, "getKeyStroke", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/KeyStroke.html#getKeyStroke(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public static Javax.Swing.KeyStroke GetKeyStroke(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Swing.KeyStroke>(LocalBridgeClazz, "getKeyStroke", "(Ljava/lang/String;)Ljavax/swing/KeyStroke;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/KeyStroke.html#getKeyStrokeForEvent(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        /// <returns><see cref="Javax.Swing.KeyStroke"/></returns>
        public static Javax.Swing.KeyStroke GetKeyStrokeForEvent(Java.Awt.EventNs.KeyEvent arg0)
        {
            return SExecuteWithSignature<Javax.Swing.KeyStroke>(LocalBridgeClazz, "getKeyStrokeForEvent", "(Ljava/awt/event/KeyEvent;)Ljavax/swing/KeyStroke;", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}