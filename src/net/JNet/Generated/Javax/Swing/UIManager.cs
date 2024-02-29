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

namespace Javax.Swing
{
    #region UIManager
    public partial class UIManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getAuxiliaryLookAndFeels()"/> 
        /// </summary>
        public static Javax.Swing.LookAndFeel[] AuxiliaryLookAndFeels
        {
            get { return SExecuteWithSignatureArray<Javax.Swing.LookAndFeel>(LocalBridgeClazz, "getAuxiliaryLookAndFeels", "()[Ljavax/swing/LookAndFeel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getCrossPlatformLookAndFeelClassName()"/> 
        /// </summary>
        public static Java.Lang.String CrossPlatformLookAndFeelClassName
        {
            get { return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getCrossPlatformLookAndFeelClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getDefaults()"/> 
        /// </summary>
        public static Javax.Swing.UIDefaults Defaults
        {
            get { return SExecuteWithSignature<Javax.Swing.UIDefaults>(LocalBridgeClazz, "getDefaults", "()Ljavax/swing/UIDefaults;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInstalledLookAndFeels()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#setInstalledLookAndFeels(javax.swing.UIManager.LookAndFeelInfo[])"/>
        /// </summary>
        public static Javax.Swing.UIManager.LookAndFeelInfo[] InstalledLookAndFeels
        {
            get { return SExecuteWithSignatureArray<Javax.Swing.UIManager.LookAndFeelInfo>(LocalBridgeClazz, "getInstalledLookAndFeels", "()[Ljavax/swing/UIManager$LookAndFeelInfo;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setInstalledLookAndFeels", "([Ljavax/swing/UIManager$LookAndFeelInfo;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getLookAndFeel()"/> 
        /// </summary>
        public static Javax.Swing.LookAndFeel LookAndFeel
        {
            get { return SExecuteWithSignature<Javax.Swing.LookAndFeel>(LocalBridgeClazz, "getLookAndFeel", "()Ljavax/swing/LookAndFeel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getLookAndFeelDefaults()"/> 
        /// </summary>
        public static Javax.Swing.UIDefaults LookAndFeelDefaults
        {
            get { return SExecuteWithSignature<Javax.Swing.UIDefaults>(LocalBridgeClazz, "getLookAndFeelDefaults", "()Ljavax/swing/UIDefaults;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public static Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return SExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>(LocalBridgeClazz, "getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getSystemLookAndFeelClassName()"/> 
        /// </summary>
        public static Java.Lang.String SystemLookAndFeelClassName
        {
            get { return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getSystemLookAndFeelClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBoolean(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetBoolean(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "getBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBoolean(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetBoolean(object arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "getBoolean", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#removeAuxiliaryLookAndFeel(javax.swing.LookAndFeel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.LookAndFeel"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool RemoveAuxiliaryLookAndFeel(Javax.Swing.LookAndFeel arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "removeAuxiliaryLookAndFeel", "(Ljavax/swing/LookAndFeel;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInt(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetInt(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInt(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetInt(object arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getInt", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getColor(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Color>(LocalBridgeClazz, "getColor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getColor(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color GetColor(object arg0)
        {
            return SExecuteWithSignature<Java.Awt.Color>(LocalBridgeClazz, "getColor", "(Ljava/lang/Object;)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getDimension(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public static Java.Awt.Dimension GetDimension(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Dimension>(LocalBridgeClazz, "getDimension", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getDimension(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public static Java.Awt.Dimension GetDimension(object arg0)
        {
            return SExecuteWithSignature<Java.Awt.Dimension>(LocalBridgeClazz, "getDimension", "(Ljava/lang/Object;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getFont(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font GetFont(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Font>(LocalBridgeClazz, "getFont", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getFont(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Font"/></returns>
        public static Java.Awt.Font GetFont(object arg0)
        {
            return SExecuteWithSignature<Java.Awt.Font>(LocalBridgeClazz, "getFont", "(Ljava/lang/Object;)Ljava/awt/Font;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInsets(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public static Java.Awt.Insets GetInsets(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Awt.Insets>(LocalBridgeClazz, "getInsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getInsets(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public static Java.Awt.Insets GetInsets(object arg0)
        {
            return SExecuteWithSignature<Java.Awt.Insets>(LocalBridgeClazz, "getInsets", "(Ljava/lang/Object;)Ljava/awt/Insets;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#get(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="object"/></returns>
        public static object Get(object arg0, Java.Util.Locale arg1)
        {
            return SExecute(LocalBridgeClazz, "get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public static object Get(object arg0)
        {
            return SExecuteWithSignature(LocalBridgeClazz, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public static object Put(object arg0, object arg1)
        {
            return SExecute(LocalBridgeClazz, "put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getString(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetString(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getString(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetString(object arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getString", "(Ljava/lang/Object;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBorder(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border GetBorder(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Javax.Swing.Border.Border>(LocalBridgeClazz, "getBorder", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getBorder(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Border.Border"/></returns>
        public static Javax.Swing.Border.Border GetBorder(object arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Border.Border>(LocalBridgeClazz, "getBorder", "(Ljava/lang/Object;)Ljavax/swing/border/Border;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getIcon(java.lang.Object,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public static Javax.Swing.Icon GetIcon(object arg0, Java.Util.Locale arg1)
        {
            return SExecute<Javax.Swing.Icon>(LocalBridgeClazz, "getIcon", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getIcon(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public static Javax.Swing.Icon GetIcon(object arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Icon>(LocalBridgeClazz, "getIcon", "(Ljava/lang/Object;)Ljavax/swing/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#createLookAndFeel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.LookAndFeel"/></returns>
        /// <exception cref="Javax.Swing.UnsupportedLookAndFeelException"/>
        public static Javax.Swing.LookAndFeel CreateLookAndFeel(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Swing.LookAndFeel>(LocalBridgeClazz, "createLookAndFeel", "(Ljava/lang/String;)Ljavax/swing/LookAndFeel;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#getUI(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Javax.Swing.Plaf.ComponentUI"/></returns>
        public static Javax.Swing.Plaf.ComponentUI GetUI(Javax.Swing.JComponent arg0)
        {
            return SExecuteWithSignature<Javax.Swing.Plaf.ComponentUI>(LocalBridgeClazz, "getUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#addAuxiliaryLookAndFeel(javax.swing.LookAndFeel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.LookAndFeel"/></param>
        public static void AddAuxiliaryLookAndFeel(Javax.Swing.LookAndFeel arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "addAuxiliaryLookAndFeel", "(Ljavax/swing/LookAndFeel;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public static void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#installLookAndFeel(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public static void InstallLookAndFeel(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            SExecute(LocalBridgeClazz, "installLookAndFeel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#installLookAndFeel(javax.swing.UIManager.LookAndFeelInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.UIManager.LookAndFeelInfo"/></param>
        public static void InstallLookAndFeel(Javax.Swing.UIManager.LookAndFeelInfo arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "installLookAndFeel", "(Ljavax/swing/UIManager$LookAndFeelInfo;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public static void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#setLookAndFeel(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Lang.InstantiationException"/>
        /// <exception cref="Java.Lang.IllegalAccessException"/>
        /// <exception cref="Javax.Swing.UnsupportedLookAndFeelException"/>
        public static void SetLookAndFeel(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setLookAndFeel", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.html#setLookAndFeel(javax.swing.LookAndFeel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.LookAndFeel"/></param>
        /// <exception cref="Javax.Swing.UnsupportedLookAndFeelException"/>
        public static void SetLookAndFeel(Javax.Swing.LookAndFeel arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "setLookAndFeel", "(Ljavax/swing/LookAndFeel;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region LookAndFeelInfo
        public partial class LookAndFeelInfo
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.LookAndFeelInfo.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public LookAndFeelInfo(Java.Lang.String arg0, Java.Lang.String arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.LookAndFeelInfo.html#getClassName()"/> 
            /// </summary>
            public Java.Lang.String ClassName
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/UIManager.LookAndFeelInfo.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
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