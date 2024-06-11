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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Scrollbar
    public partial class Scrollbar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#%3Cinit%3E(int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Scrollbar(int arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Scrollbar(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Scrollbar"/> to <see cref="Java.Awt.Adjustable"/>
        /// </summary>
        public static implicit operator Java.Awt.Adjustable(Java.Awt.Scrollbar t) => t.Cast<Java.Awt.Adjustable>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Scrollbar"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.Scrollbar t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static int _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<int>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static int _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getAdjustmentListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.AdjustmentListener[] AdjustmentListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.AdjustmentListener>("getAdjustmentListeners", "()[Ljava/awt/event/AdjustmentListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getBlockIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setBlockIncrement(int)"/>
        /// </summary>
        public int BlockIncrement
        {
            get { return IExecuteWithSignature<int>("getBlockIncrement", "()I"); } set { IExecuteWithSignature("setBlockIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setMaximum(int)"/>
        /// </summary>
        public int Maximum
        {
            get { return IExecuteWithSignature<int>("getMaximum", "()I"); } set { IExecuteWithSignature("setMaximum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setMinimum(int)"/>
        /// </summary>
        public int Minimum
        {
            get { return IExecuteWithSignature<int>("getMinimum", "()I"); } set { IExecuteWithSignature("setMinimum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecuteWithSignature<int>("getOrientation", "()I"); } set { IExecuteWithSignature("setOrientation", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getUnitIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setUnitIncrement(int)"/>
        /// </summary>
        public int UnitIncrement
        {
            get { return IExecuteWithSignature<int>("getUnitIncrement", "()I"); } set { IExecuteWithSignature("setUnitIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); } set { IExecuteWithSignature("setValue", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getValueIsAdjusting()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setValueIsAdjusting(boolean)"/>
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecuteWithSignature<bool>("getValueIsAdjusting", "()Z"); } set { IExecuteWithSignature("setValueIsAdjusting", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#getVisibleAmount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setVisibleAmount(int)"/>
        /// </summary>
        public int VisibleAmount
        {
            get { return IExecuteWithSignature<int>("getVisibleAmount", "()I"); } set { IExecuteWithSignature("setVisibleAmount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#addAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void AddAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecuteWithSignature("addAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#removeAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void RemoveAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecuteWithSignature("removeAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Scrollbar.html#setValues(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetValues(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setValues", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}