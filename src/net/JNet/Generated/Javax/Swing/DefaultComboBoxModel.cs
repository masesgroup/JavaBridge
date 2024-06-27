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

namespace Javax.Swing
{
    #region DefaultComboBoxModel
    public partial class DefaultComboBoxModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#%3Cinit%3E(java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        public DefaultComboBoxModel(Java.Util.Vector arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultComboBoxModel"/> to <see cref="Javax.Swing.MutableComboBoxModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.MutableComboBoxModel(Javax.Swing.DefaultComboBoxModel t) => t.Cast<Javax.Swing.MutableComboBoxModel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#getSelectedItem()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#setSelectedItem(java.lang.Object)"/>
        /// </summary>
        public object SelectedItem
        {
            get { return IExecuteWithSignature("getSelectedItem", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setSelectedItem", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#getIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("getIndexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        public void AddAll(int arg0, Java.Util.Collection arg1)
        {
            IExecute("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public void AddAll(Java.Util.Collection arg0)
        {
            IExecuteWithSignature("addAll", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addElement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddElement(object arg0)
        {
            IExecuteWithSignature("addElement", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#insertElementAt(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void InsertElementAt(object arg0, int arg1)
        {
            IExecute("insertElementAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeAllElements()"/>
        /// </summary>
        public void RemoveAllElements()
        {
            IExecuteWithSignature("removeAllElements", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeElement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveElement(object arg0)
        {
            IExecuteWithSignature("removeElement", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeElementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveElementAt(int arg0)
        {
            IExecuteWithSignature("removeElementAt", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DefaultComboBoxModel<E>
    public partial class DefaultComboBoxModel<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#%3Cinit%3E(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public DefaultComboBoxModel(E[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#%3Cinit%3E(java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        public DefaultComboBoxModel(Java.Util.Vector<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultComboBoxModel{E}"/> to <see cref="Javax.Swing.MutableComboBoxModel{E}"/>
        /// </summary>
        public static implicit operator Javax.Swing.MutableComboBoxModel<E>(Javax.Swing.DefaultComboBoxModel<E> t) => t.Cast<Javax.Swing.MutableComboBoxModel<E>>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.DefaultComboBoxModel{E}"/> to <see cref="Javax.Swing.DefaultComboBoxModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.DefaultComboBoxModel(Javax.Swing.DefaultComboBoxModel<E> t) => t.Cast<Javax.Swing.DefaultComboBoxModel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#getSelectedItem()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#setSelectedItem(java.lang.Object)"/>
        /// </summary>
        public object SelectedItem
        {
            get { return IExecuteWithSignature("getSelectedItem", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setSelectedItem", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#getIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndexOf(object arg0)
        {
            return IExecuteWithSignature<int>("getIndexOf", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg1ExtendsE"><typeparamref name="E"/></typeparam>
        public void AddAll<Arg1ExtendsE>(int arg0, Java.Util.Collection<Arg1ExtendsE> arg1) where Arg1ExtendsE : E
        {
            IExecute("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        public void AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE : E
        {
            IExecuteWithSignature("addAll", "(Ljava/util/Collection;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#addElement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void AddElement(E arg0)
        {
            IExecuteWithSignature("addElement", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#insertElementAt(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void InsertElementAt(E arg0, int arg1)
        {
            IExecute("insertElementAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeAllElements()"/>
        /// </summary>
        public void RemoveAllElements()
        {
            IExecuteWithSignature("removeAllElements", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeElement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void RemoveElement(object arg0)
        {
            IExecuteWithSignature("removeElement", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DefaultComboBoxModel.html#removeElementAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveElementAt(int arg0)
        {
            IExecuteWithSignature("removeElementAt", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}