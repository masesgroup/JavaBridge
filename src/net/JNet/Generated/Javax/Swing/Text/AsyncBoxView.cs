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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region AsyncBoxView
    public partial class AsyncBoxView
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#<init>(javax.swing.text.Element,int)
        /// </summary>
        public AsyncBoxView(Javax.Swing.Text.Element arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getBottomInset() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setBottomInset(float)
        /// </summary>
        public float BottomInset
        {
            get { return IExecute<float>("getBottomInset"); } set { IExecute("setBottomInset", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getLeftInset() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setLeftInset(float)
        /// </summary>
        public float LeftInset
        {
            get { return IExecute<float>("getLeftInset"); } set { IExecute("setLeftInset", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getMajorAxis() 
        /// </summary>
        public int MajorAxis
        {
            get { return IExecute<int>("getMajorAxis"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getMinorAxis() 
        /// </summary>
        public int MinorAxis
        {
            get { return IExecute<int>("getMinorAxis"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getRightInset() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setRightInset(float)
        /// </summary>
        public float RightInset
        {
            get { return IExecute<float>("getRightInset"); } set { IExecute("setRightInset", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#getTopInset() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.html#setTopInset(float)
        /// </summary>
        public float TopInset
        {
            get { return IExecute<float>("getTopInset"); } set { IExecute("setTopInset", value); }
        }
        
        #endregion

        #region Nested classes
        #region ChildLocator
        public partial class ChildLocator
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#<init>(javax.swing.text.AsyncBoxView)
            /// </summary>
            public ChildLocator(Javax.Swing.Text.AsyncBoxView arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#getViewIndexAtPoint(float,float,java.awt.Shape)
            /// </summary>
            public int GetViewIndexAtPoint(float arg0, float arg1, Java.Awt.Shape arg2)
            {
                return IExecute<int>("getViewIndexAtPoint", arg0, arg1, arg2);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#getChildAllocation(int,java.awt.Shape)
            /// </summary>
            public Java.Awt.Shape GetChildAllocation(int arg0, Java.Awt.Shape arg1)
            {
                return IExecute<Java.Awt.Shape>("getChildAllocation", arg0, arg1);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#childChanged(javax.swing.text.AsyncBoxView$ChildState)
            /// </summary>
            public void ChildChanged(Javax.Swing.Text.AsyncBoxView.ChildState arg0)
            {
                IExecute("childChanged", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildLocator.html#paintChildren(java.awt.Graphics)
            /// </summary>
            public void PaintChildren(Java.Awt.Graphics arg0)
            {
                IExecute("paintChildren", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ChildState
        public partial class ChildState
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#<init>(javax.swing.text.AsyncBoxView,javax.swing.text.View)
            /// </summary>
            public ChildState(Javax.Swing.Text.AsyncBoxView arg0, Javax.Swing.Text.View arg1)
                : base(arg0, arg1)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Lang.Runnable(Javax.Swing.Text.AsyncBoxView.ChildState t) => t.Cast<Java.Lang.Runnable>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getChildView() 
            /// </summary>
            public Javax.Swing.Text.View ChildView
            {
                get { return IExecute<Javax.Swing.Text.View>("getChildView"); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMajorOffset() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#setMajorOffset(float)
            /// </summary>
            public float MajorOffset
            {
                get { return IExecute<float>("getMajorOffset"); } set { IExecute("setMajorOffset", value); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMajorSpan() 
            /// </summary>
            public float MajorSpan
            {
                get { return IExecute<float>("getMajorSpan"); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMinorOffset() 
            /// </summary>
            public float MinorOffset
            {
                get { return IExecute<float>("getMinorOffset"); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#getMinorSpan() 
            /// </summary>
            public float MinorSpan
            {
                get { return IExecute<float>("getMinorSpan"); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#isLayoutValid()
            /// </summary>
            public bool IsLayoutValid()
            {
                return IExecute<bool>("isLayoutValid");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#preferenceChanged(boolean,boolean)
            /// </summary>
            public void PreferenceChanged(bool arg0, bool arg1)
            {
                IExecute("preferenceChanged", arg0, arg1);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/AsyncBoxView.ChildState.html#run()
            /// </summary>
            public void Run()
            {
                IExecute("run");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}