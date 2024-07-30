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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region ScrollPaneAdjustable
    public partial class ScrollPaneAdjustable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ScrollPaneAdjustable"/> to <see cref="Java.Awt.Adjustable"/>
        /// </summary>
        public static implicit operator Java.Awt.Adjustable(Java.Awt.ScrollPaneAdjustable t) => t.Cast<Java.Awt.Adjustable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ScrollPaneAdjustable"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.ScrollPaneAdjustable t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getAdjustmentListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.AdjustmentListener[] AdjustmentListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.AdjustmentListener>("getAdjustmentListeners", "()[Ljava/awt/event/AdjustmentListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getBlockIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setBlockIncrement(int)"/>
        /// </summary>
        public int BlockIncrement
        {
            get { return IExecuteWithSignature<int>("getBlockIncrement", "()I"); } set { IExecuteWithSignature("setBlockIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setMaximum(int)"/>
        /// </summary>
        public int Maximum
        {
            get { return IExecuteWithSignature<int>("getMaximum", "()I"); } set { IExecuteWithSignature("setMaximum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setMinimum(int)"/>
        /// </summary>
        public int Minimum
        {
            get { return IExecuteWithSignature<int>("getMinimum", "()I"); } set { IExecuteWithSignature("setMinimum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getOrientation()"/> 
        /// </summary>
        public int Orientation
        {
            get { return IExecuteWithSignature<int>("getOrientation", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getUnitIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setUnitIncrement(int)"/>
        /// </summary>
        public int UnitIncrement
        {
            get { return IExecuteWithSignature<int>("getUnitIncrement", "()I"); } set { IExecuteWithSignature("setUnitIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); } set { IExecuteWithSignature("setValue", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecuteWithSignature<bool>("getValueIsAdjusting", "()Z"); } set { IExecuteWithSignature("setValueIsAdjusting", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getVisibleAmount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setVisibleAmount(int)"/>
        /// </summary>
        public int VisibleAmount
        {
            get { return IExecuteWithSignature<int>("getVisibleAmount", "()I"); } set { IExecuteWithSignature("setVisibleAmount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#paramString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ParamString()
        {
            return IExecuteWithSignature<Java.Lang.String>("paramString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#addAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void AddAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecuteWithSignature("addAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#removeAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void RemoveAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecuteWithSignature("removeAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}