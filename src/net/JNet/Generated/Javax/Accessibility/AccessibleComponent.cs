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

namespace Javax.Accessibility
{
    #region IAccessibleComponent
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IAccessibleComponent
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getBackground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setBackground(java.awt.Color)"/>
        /// </summary>
        Java.Awt.Color Background { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getBounds()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setBounds(java.awt.Rectangle)"/>
        /// </summary>
        Java.Awt.Rectangle Bounds { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setCursor(java.awt.Cursor)"/>
        /// </summary>
        Java.Awt.Cursor Cursor { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getFont()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setFont(java.awt.Font)"/>
        /// </summary>
        Java.Awt.Font Font { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getForeground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setForeground(java.awt.Color)"/>
        /// </summary>
        Java.Awt.Color Foreground { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getLocation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setLocation(java.awt.Point)"/>
        /// </summary>
        Java.Awt.Point Location { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getLocationOnScreen()"/> 
        /// </summary>
        Java.Awt.Point LocationOnScreen { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setSize(java.awt.Dimension)"/>
        /// </summary>
        Java.Awt.Dimension Size { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#contains(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Contains(Java.Awt.Point arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsEnabled();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isFocusTraversable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsFocusTraversable();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsShowing();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsVisible();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getFontMetrics(java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Font"/></param>
        /// <returns><see cref="Java.Awt.FontMetrics"/></returns>
        Java.Awt.FontMetrics GetFontMetrics(Java.Awt.Font arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getAccessibleAt(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        Javax.Accessibility.Accessible GetAccessibleAt(Java.Awt.Point arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#addFocusListener(java.awt.event.FocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusListener"/></param>
        void AddFocusListener(Java.Awt.EventNs.FocusListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#removeFocusListener(java.awt.event.FocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusListener"/></param>
        void RemoveFocusListener(Java.Awt.EventNs.FocusListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#requestFocus()"/>
        /// </summary>
        void RequestFocus();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetVisible(bool arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AccessibleComponent
    public partial class AccessibleComponent : Javax.Accessibility.IAccessibleComponent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getBackground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setBackground(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color Background
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getBackground", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setBackground", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getBounds()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setBounds(java.awt.Rectangle)"/>
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getBounds", "()Ljava/awt/Rectangle;"); } set { IExecuteWithSignature("setBounds", "(Ljava/awt/Rectangle;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setCursor(java.awt.Cursor)"/>
        /// </summary>
        public Java.Awt.Cursor Cursor
        {
            get { return IExecuteWithSignature<Java.Awt.Cursor>("getCursor", "()Ljava/awt/Cursor;"); } set { IExecuteWithSignature("setCursor", "(Ljava/awt/Cursor;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getFont()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setFont(java.awt.Font)"/>
        /// </summary>
        public Java.Awt.Font Font
        {
            get { return IExecuteWithSignature<Java.Awt.Font>("getFont", "()Ljava/awt/Font;"); } set { IExecuteWithSignature("setFont", "(Ljava/awt/Font;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getForeground()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setForeground(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color Foreground
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getForeground", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setForeground", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getLocation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setLocation(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point Location
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getLocation", "()Ljava/awt/Point;"); } set { IExecuteWithSignature("setLocation", "(Ljava/awt/Point;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getLocationOnScreen()"/> 
        /// </summary>
        public Java.Awt.Point LocationOnScreen
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getLocationOnScreen", "()Ljava/awt/Point;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension Size
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getSize", "()Ljava/awt/Dimension;"); } set { IExecuteWithSignature("setSize", "(Ljava/awt/Dimension;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#contains(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Point arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/awt/Point;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabled()
        {
            return IExecuteWithSignature<bool>("isEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isFocusTraversable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFocusTraversable()
        {
            return IExecuteWithSignature<bool>("isFocusTraversable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isShowing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShowing()
        {
            return IExecuteWithSignature<bool>("isShowing", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#isVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsVisible()
        {
            return IExecuteWithSignature<bool>("isVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getFontMetrics(java.awt.Font)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Font"/></param>
        /// <returns><see cref="Java.Awt.FontMetrics"/></returns>
        public Java.Awt.FontMetrics GetFontMetrics(Java.Awt.Font arg0)
        {
            return IExecuteWithSignature<Java.Awt.FontMetrics>("getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#getAccessibleAt(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public Javax.Accessibility.Accessible GetAccessibleAt(Java.Awt.Point arg0)
        {
            return IExecuteWithSignature<Javax.Accessibility.Accessible>("getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#addFocusListener(java.awt.event.FocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusListener"/></param>
        public void AddFocusListener(Java.Awt.EventNs.FocusListener arg0)
        {
            IExecuteWithSignature("addFocusListener", "(Ljava/awt/event/FocusListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#removeFocusListener(java.awt.event.FocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusListener"/></param>
        public void RemoveFocusListener(Java.Awt.EventNs.FocusListener arg0)
        {
            IExecuteWithSignature("removeFocusListener", "(Ljava/awt/event/FocusListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#requestFocus()"/>
        /// </summary>
        public void RequestFocus()
        {
            IExecuteWithSignature("requestFocus", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEnabled(bool arg0)
        {
            IExecuteWithSignature("setEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleComponent.html#setVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetVisible(bool arg0)
        {
            IExecuteWithSignature("setVisible", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}