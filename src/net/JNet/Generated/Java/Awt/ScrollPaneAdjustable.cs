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
            get { return IExecuteArray<Java.Awt.EventNs.AdjustmentListener>("getAdjustmentListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getBlockIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setBlockIncrement(int)"/>
        /// </summary>
        public int BlockIncrement
        {
            get { return IExecute<int>("getBlockIncrement"); } set { IExecute("setBlockIncrement", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setMaximum(int)"/>
        /// </summary>
        public int Maximum
        {
            get { return IExecute<int>("getMaximum"); } set { IExecute("setMaximum", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setMinimum(int)"/>
        /// </summary>
        public int Minimum
        {
            get { return IExecute<int>("getMinimum"); } set { IExecute("setMinimum", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getOrientation()"/> 
        /// </summary>
        public int Orientation
        {
            get { return IExecute<int>("getOrientation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#paramString()"/> 
        /// </summary>
        public string ParamString
        {
            get { return IExecute<string>("paramString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getUnitIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setUnitIncrement(int)"/>
        /// </summary>
        public int UnitIncrement
        {
            get { return IExecute<int>("getUnitIncrement"); } set { IExecute("setUnitIncrement", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecute<int>("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecute<bool>("getValueIsAdjusting"); } set { IExecute("setValueIsAdjusting", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#getVisibleAmount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#setVisibleAmount(int)"/>
        /// </summary>
        public int VisibleAmount
        {
            get { return IExecute<int>("getVisibleAmount"); } set { IExecute("setVisibleAmount", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#addAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void AddAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecute("addAdjustmentListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/ScrollPaneAdjustable.html#removeAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void RemoveAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecute("removeAdjustmentListener", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}