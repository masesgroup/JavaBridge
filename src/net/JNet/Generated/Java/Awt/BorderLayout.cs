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
    #region BorderLayout
    public partial class BorderLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BorderLayout(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.BorderLayout"/> to <see cref="Java.Awt.LayoutManager2"/>
        /// </summary>
        public static implicit operator Java.Awt.LayoutManager2(Java.Awt.BorderLayout t) => t.Cast<Java.Awt.LayoutManager2>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.BorderLayout"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.BorderLayout t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#AFTER_LAST_LINE"/>
        /// </summary>
        public static Java.Lang.String AFTER_LAST_LINE { get { if (!_AFTER_LAST_LINEReady) { _AFTER_LAST_LINEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AFTER_LAST_LINE"); _AFTER_LAST_LINEReady = true; } return _AFTER_LAST_LINEContent; } }
        private static Java.Lang.String _AFTER_LAST_LINEContent = default;
        private static bool _AFTER_LAST_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#AFTER_LINE_ENDS"/>
        /// </summary>
        public static Java.Lang.String AFTER_LINE_ENDS { get { if (!_AFTER_LINE_ENDSReady) { _AFTER_LINE_ENDSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AFTER_LINE_ENDS"); _AFTER_LINE_ENDSReady = true; } return _AFTER_LINE_ENDSContent; } }
        private static Java.Lang.String _AFTER_LINE_ENDSContent = default;
        private static bool _AFTER_LINE_ENDSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#BEFORE_FIRST_LINE"/>
        /// </summary>
        public static Java.Lang.String BEFORE_FIRST_LINE { get { if (!_BEFORE_FIRST_LINEReady) { _BEFORE_FIRST_LINEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BEFORE_FIRST_LINE"); _BEFORE_FIRST_LINEReady = true; } return _BEFORE_FIRST_LINEContent; } }
        private static Java.Lang.String _BEFORE_FIRST_LINEContent = default;
        private static bool _BEFORE_FIRST_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#BEFORE_LINE_BEGINS"/>
        /// </summary>
        public static Java.Lang.String BEFORE_LINE_BEGINS { get { if (!_BEFORE_LINE_BEGINSReady) { _BEFORE_LINE_BEGINSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BEFORE_LINE_BEGINS"); _BEFORE_LINE_BEGINSReady = true; } return _BEFORE_LINE_BEGINSContent; } }
        private static Java.Lang.String _BEFORE_LINE_BEGINSContent = default;
        private static bool _BEFORE_LINE_BEGINSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#CENTER"/>
        /// </summary>
        public static Java.Lang.String CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
        private static Java.Lang.String _CENTERContent = default;
        private static bool _CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#EAST"/>
        /// </summary>
        public static Java.Lang.String EAST { get { if (!_EASTReady) { _EASTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "EAST"); _EASTReady = true; } return _EASTContent; } }
        private static Java.Lang.String _EASTContent = default;
        private static bool _EASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#LINE_END"/>
        /// </summary>
        public static Java.Lang.String LINE_END { get { if (!_LINE_ENDReady) { _LINE_ENDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LINE_END"); _LINE_ENDReady = true; } return _LINE_ENDContent; } }
        private static Java.Lang.String _LINE_ENDContent = default;
        private static bool _LINE_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#LINE_START"/>
        /// </summary>
        public static Java.Lang.String LINE_START { get { if (!_LINE_STARTReady) { _LINE_STARTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LINE_START"); _LINE_STARTReady = true; } return _LINE_STARTContent; } }
        private static Java.Lang.String _LINE_STARTContent = default;
        private static bool _LINE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#NORTH"/>
        /// </summary>
        public static Java.Lang.String NORTH { get { if (!_NORTHReady) { _NORTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NORTH"); _NORTHReady = true; } return _NORTHContent; } }
        private static Java.Lang.String _NORTHContent = default;
        private static bool _NORTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#PAGE_END"/>
        /// </summary>
        public static Java.Lang.String PAGE_END { get { if (!_PAGE_ENDReady) { _PAGE_ENDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PAGE_END"); _PAGE_ENDReady = true; } return _PAGE_ENDContent; } }
        private static Java.Lang.String _PAGE_ENDContent = default;
        private static bool _PAGE_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#PAGE_START"/>
        /// </summary>
        public static Java.Lang.String PAGE_START { get { if (!_PAGE_STARTReady) { _PAGE_STARTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PAGE_START"); _PAGE_STARTReady = true; } return _PAGE_STARTContent; } }
        private static Java.Lang.String _PAGE_STARTContent = default;
        private static bool _PAGE_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#SOUTH"/>
        /// </summary>
        public static Java.Lang.String SOUTH { get { if (!_SOUTHReady) { _SOUTHContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SOUTH"); _SOUTHReady = true; } return _SOUTHContent; } }
        private static Java.Lang.String _SOUTHContent = default;
        private static bool _SOUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#WEST"/>
        /// </summary>
        public static Java.Lang.String WEST { get { if (!_WESTReady) { _WESTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "WEST"); _WESTReady = true; } return _WESTContent; } }
        private static Java.Lang.String _WESTContent = default;
        private static bool _WESTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#getHgap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#setHgap(int)"/>
        /// </summary>
        public int Hgap
        {
            get { return IExecuteWithSignature<int>("getHgap", "()I"); } set { IExecuteWithSignature("setHgap", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#getVgap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#setVgap(int)"/>
        /// </summary>
        public int Vgap
        {
            get { return IExecuteWithSignature<int>("getVgap", "()I"); } set { IExecuteWithSignature("setVgap", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#getLayoutAlignmentX(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentX(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentX", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#getLayoutAlignmentY(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentY(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentY", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#getLayoutComponent(java.awt.Container,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetLayoutComponent(Java.Awt.Container arg0, object arg1)
        {
            return IExecute<Java.Awt.Component>("getLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#getLayoutComponent(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetLayoutComponent(object arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getLayoutComponent", "(Ljava/lang/Object;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#maximumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("maximumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#getConstraints(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetConstraints(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature("getConstraints", "(Ljava/awt/Component;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#invalidateLayout(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void InvalidateLayout(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("invalidateLayout", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("layoutContainer", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/BorderLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("removeLayoutComponent", "(Ljava/awt/Component;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}