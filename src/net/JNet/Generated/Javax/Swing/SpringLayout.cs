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
    #region SpringLayout
    public partial class SpringLayout
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#BASELINE"/>
        /// </summary>
        public static Java.Lang.String BASELINE { get { if (!_BASELINEReady) { _BASELINEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BASELINE"); _BASELINEReady = true; } return _BASELINEContent; } }
        private static Java.Lang.String _BASELINEContent = default;
        private static bool _BASELINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#EAST"/>
        /// </summary>
        public static Java.Lang.String EAST { get { if (!_EASTReady) { _EASTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EAST"); _EASTReady = true; } return _EASTContent; } }
        private static Java.Lang.String _EASTContent = default;
        private static bool _EASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#HEIGHT"/>
        /// </summary>
        public static Java.Lang.String HEIGHT { get { if (!_HEIGHTReady) { _HEIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HEIGHT"); _HEIGHTReady = true; } return _HEIGHTContent; } }
        private static Java.Lang.String _HEIGHTContent = default;
        private static bool _HEIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#HORIZONTAL_CENTER"/>
        /// </summary>
        public static Java.Lang.String HORIZONTAL_CENTER { get { if (!_HORIZONTAL_CENTERReady) { _HORIZONTAL_CENTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HORIZONTAL_CENTER"); _HORIZONTAL_CENTERReady = true; } return _HORIZONTAL_CENTERContent; } }
        private static Java.Lang.String _HORIZONTAL_CENTERContent = default;
        private static bool _HORIZONTAL_CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#NORTH"/>
        /// </summary>
        public static Java.Lang.String NORTH { get { if (!_NORTHReady) { _NORTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NORTH"); _NORTHReady = true; } return _NORTHContent; } }
        private static Java.Lang.String _NORTHContent = default;
        private static bool _NORTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#SOUTH"/>
        /// </summary>
        public static Java.Lang.String SOUTH { get { if (!_SOUTHReady) { _SOUTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOUTH"); _SOUTHReady = true; } return _SOUTHContent; } }
        private static Java.Lang.String _SOUTHContent = default;
        private static bool _SOUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#VERTICAL_CENTER"/>
        /// </summary>
        public static Java.Lang.String VERTICAL_CENTER { get { if (!_VERTICAL_CENTERReady) { _VERTICAL_CENTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "VERTICAL_CENTER"); _VERTICAL_CENTERReady = true; } return _VERTICAL_CENTERContent; } }
        private static Java.Lang.String _VERTICAL_CENTERContent = default;
        private static bool _VERTICAL_CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#WEST"/>
        /// </summary>
        public static Java.Lang.String WEST { get { if (!_WESTReady) { _WESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WEST"); _WESTReady = true; } return _WESTContent; } }
        private static Java.Lang.String _WESTContent = default;
        private static bool _WESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#WIDTH"/>
        /// </summary>
        public static Java.Lang.String WIDTH { get { if (!_WIDTHReady) { _WIDTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WIDTH"); _WIDTHReady = true; } return _WIDTHContent; } }
        private static Java.Lang.String _WIDTHContent = default;
        private static bool _WIDTHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getLayoutAlignmentX(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentX(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentX", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getLayoutAlignmentY(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentY(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentY", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#maximumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("maximumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getConstraint(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.Spring"/></returns>
        public Javax.Swing.Spring GetConstraint(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            return IExecute<Javax.Swing.Spring>("getConstraint", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#getConstraints(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.SpringLayout.Constraints"/></returns>
        public Javax.Swing.SpringLayout.Constraints GetConstraints(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<Javax.Swing.SpringLayout.Constraints>("getConstraints", "(Ljava/awt/Component;)Ljavax/swing/SpringLayout$Constraints;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#invalidateLayout(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void InvalidateLayout(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("invalidateLayout", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("layoutContainer", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#putConstraint(java.lang.String,java.awt.Component,int,java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Component"/></param>
        public void PutConstraint(Java.Lang.String arg0, Java.Awt.Component arg1, int arg2, Java.Lang.String arg3, Java.Awt.Component arg4)
        {
            IExecute("putConstraint", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#putConstraint(java.lang.String,java.awt.Component,javax.swing.Spring,java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Spring"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Component"/></param>
        public void PutConstraint(Java.Lang.String arg0, Java.Awt.Component arg1, Javax.Swing.Spring arg2, Java.Lang.String arg3, Java.Awt.Component arg4)
        {
            IExecute("putConstraint", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("removeLayoutComponent", "(Ljava/awt/Component;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Constraints
        public partial class Constraints
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#%3Cinit%3E(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            public Constraints(Java.Awt.Component arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#%3Cinit%3E(javax.swing.Spring,javax.swing.Spring,javax.swing.Spring,javax.swing.Spring)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Spring"/></param>
            public Constraints(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1, Javax.Swing.Spring arg2, Javax.Swing.Spring arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#%3Cinit%3E(javax.swing.Spring,javax.swing.Spring)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Spring"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
            public Constraints(Javax.Swing.Spring arg0, Javax.Swing.Spring arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setHeight(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring Height
            {
                get { return IExecuteWithSignature<Javax.Swing.Spring>("getHeight", "()Ljavax/swing/Spring;"); } set { IExecuteWithSignature("setHeight", "(Ljavax/swing/Spring;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setWidth(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring Width
            {
                get { return IExecuteWithSignature<Javax.Swing.Spring>("getWidth", "()Ljavax/swing/Spring;"); } set { IExecuteWithSignature("setWidth", "(Ljavax/swing/Spring;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getX()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setX(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring X
            {
                get { return IExecuteWithSignature<Javax.Swing.Spring>("getX", "()Ljavax/swing/Spring;"); } set { IExecuteWithSignature("setX", "(Ljavax/swing/Spring;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getY()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setY(javax.swing.Spring)"/>
            /// </summary>
            public Javax.Swing.Spring Y
            {
                get { return IExecuteWithSignature<Javax.Swing.Spring>("getY", "()Ljavax/swing/Spring;"); } set { IExecuteWithSignature("setY", "(Ljavax/swing/Spring;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#getConstraint(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Swing.Spring"/></returns>
            public Javax.Swing.Spring GetConstraint(Java.Lang.String arg0)
            {
                return IExecuteWithSignature<Javax.Swing.Spring>("getConstraint", "(Ljava/lang/String;)Ljavax/swing/Spring;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SpringLayout.Constraints.html#setConstraint(java.lang.String,javax.swing.Spring)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Spring"/></param>
            public void SetConstraint(Java.Lang.String arg0, Javax.Swing.Spring arg1)
            {
                IExecute("setConstraint", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}