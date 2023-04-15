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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region InputMap
    public partial class InputMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.InputMap"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.InputMap t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#allKeys()"/> 
        /// </summary>
        public Javax.Swing.KeyStroke[] AllKeys
        {
            get { return IExecuteArray<Javax.Swing.KeyStroke>("allKeys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#keys()"/> 
        /// </summary>
        public Javax.Swing.KeyStroke[] Keys
        {
            get { return IExecuteArray<Javax.Swing.KeyStroke>("keys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#setParent(javax.swing.InputMap)"/>
        /// </summary>
        public Javax.Swing.InputMap Parent
        {
            get { return IExecute<Javax.Swing.InputMap>("getParent"); } set { IExecute("setParent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#get(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(Javax.Swing.KeyStroke arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#put(javax.swing.KeyStroke,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Put(Javax.Swing.KeyStroke arg0, object arg1)
        {
            IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/InputMap.html#remove(javax.swing.KeyStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.KeyStroke"/></param>
        public void Remove(Javax.Swing.KeyStroke arg0)
        {
            IExecute("remove", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}