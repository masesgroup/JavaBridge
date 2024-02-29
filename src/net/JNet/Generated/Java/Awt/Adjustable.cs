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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region IAdjustable
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAdjustable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getBlockIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setBlockIncrement(int)"/>
        /// </summary>
        int BlockIncrement { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setMaximum(int)"/>
        /// </summary>
        int Maximum { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setMinimum(int)"/>
        /// </summary>
        int Minimum { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getOrientation()"/> 
        /// </summary>
        int Orientation { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getUnitIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setUnitIncrement(int)"/>
        /// </summary>
        int UnitIncrement { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setValue(int)"/>
        /// </summary>
        int Value { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getVisibleAmount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setVisibleAmount(int)"/>
        /// </summary>
        int VisibleAmount { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#addAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        void AddAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#removeAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        void RemoveAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Adjustable
    public partial class Adjustable : Java.Awt.IAdjustable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#HORIZONTAL"/>
        /// </summary>
        public static int HORIZONTAL { get { if (!_HORIZONTALReady) { _HORIZONTALContent = SGetField<int>(LocalBridgeClazz, "HORIZONTAL"); _HORIZONTALReady = true; } return _HORIZONTALContent; } }
        private static int _HORIZONTALContent = default;
        private static bool _HORIZONTALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#NO_ORIENTATION"/>
        /// </summary>
        public static int NO_ORIENTATION { get { if (!_NO_ORIENTATIONReady) { _NO_ORIENTATIONContent = SGetField<int>(LocalBridgeClazz, "NO_ORIENTATION"); _NO_ORIENTATIONReady = true; } return _NO_ORIENTATIONContent; } }
        private static int _NO_ORIENTATIONContent = default;
        private static bool _NO_ORIENTATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#VERTICAL"/>
        /// </summary>
        public static int VERTICAL { get { if (!_VERTICALReady) { _VERTICALContent = SGetField<int>(LocalBridgeClazz, "VERTICAL"); _VERTICALReady = true; } return _VERTICALContent; } }
        private static int _VERTICALContent = default;
        private static bool _VERTICALReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getBlockIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setBlockIncrement(int)"/>
        /// </summary>
        public int BlockIncrement
        {
            get { return IExecuteWithSignature<int>("getBlockIncrement", "()I"); } set { IExecuteWithSignature("setBlockIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getMaximum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setMaximum(int)"/>
        /// </summary>
        public int Maximum
        {
            get { return IExecuteWithSignature<int>("getMaximum", "()I"); } set { IExecuteWithSignature("setMaximum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getMinimum()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setMinimum(int)"/>
        /// </summary>
        public int Minimum
        {
            get { return IExecuteWithSignature<int>("getMinimum", "()I"); } set { IExecuteWithSignature("setMinimum", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getOrientation()"/> 
        /// </summary>
        public int Orientation
        {
            get { return IExecuteWithSignature<int>("getOrientation", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getUnitIncrement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setUnitIncrement(int)"/>
        /// </summary>
        public int UnitIncrement
        {
            get { return IExecuteWithSignature<int>("getUnitIncrement", "()I"); } set { IExecuteWithSignature("setUnitIncrement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setValue(int)"/>
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); } set { IExecuteWithSignature("setValue", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#getVisibleAmount()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#setVisibleAmount(int)"/>
        /// </summary>
        public int VisibleAmount
        {
            get { return IExecuteWithSignature<int>("getVisibleAmount", "()I"); } set { IExecuteWithSignature("setVisibleAmount", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#addAdjustmentListener(java.awt.event.AdjustmentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AdjustmentListener"/></param>
        public void AddAdjustmentListener(Java.Awt.EventNs.AdjustmentListener arg0)
        {
            IExecuteWithSignature("addAdjustmentListener", "(Ljava/awt/event/AdjustmentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Adjustable.html#removeAdjustmentListener(java.awt.event.AdjustmentListener)"/>
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