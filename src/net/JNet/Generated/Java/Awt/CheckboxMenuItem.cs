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

namespace Java.Awt
{
    #region CheckboxMenuItem
    public partial class CheckboxMenuItem
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public CheckboxMenuItem(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public CheckboxMenuItem(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.CheckboxMenuItem"/> to <see cref="Java.Awt.ItemSelectable"/>
        /// </summary>
        public static implicit operator Java.Awt.ItemSelectable(Java.Awt.CheckboxMenuItem t) => t.Cast<Java.Awt.ItemSelectable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#getItemListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.ItemListener[] ItemListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.ItemListener>("getItemListeners", "()[Ljava/awt/event/ItemListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#getSelectedObjects()"/> 
        /// </summary>
        public object[] SelectedObjects
        {
            get { return IExecuteWithSignatureArray<object>("getSelectedObjects", "()[Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#getState()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#setState(boolean)"/>
        /// </summary>
        public bool State
        {
            get { return IExecuteWithSignature<bool>("getState", "()Z"); } set { IExecuteWithSignature("setState", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#addItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void AddItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("addItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/CheckboxMenuItem.html#removeItemListener(java.awt.event.ItemListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemListener"/></param>
        public void RemoveItemListener(Java.Awt.EventNs.ItemListener arg0)
        {
            IExecuteWithSignature("removeItemListener", "(Ljava/awt/event/ItemListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}