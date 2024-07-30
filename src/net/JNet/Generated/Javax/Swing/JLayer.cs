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

namespace Javax.Swing
{
    #region JLayer
    public partial class JLayer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#%3Cinit%3E(java.awt.Component,javax.swing.plaf.LayerUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.LayerUI"/></param>
        public JLayer(Java.Awt.Component arg0, Javax.Swing.Plaf.LayerUI arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#%3Cinit%3E(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public JLayer(Java.Awt.Component arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayer"/> to <see cref="Javax.Swing.Scrollable"/>
        /// </summary>
        public static implicit operator Javax.Swing.Scrollable(Javax.Swing.JLayer t) => t.Cast<Javax.Swing.Scrollable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayer"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.JLayer t) => t.Cast<Java.Beans.PropertyChangeListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayer"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JLayer t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setGlassPane(javax.swing.JPanel)"/>
        /// </summary>
        public Javax.Swing.JPanel GlassPane
        {
            get { return IExecuteWithSignature<Javax.Swing.JPanel>("getGlassPane", "()Ljavax/swing/JPanel;"); } set { IExecuteWithSignature("setGlassPane", "(Ljavax/swing/JPanel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getLayerEventMask()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setLayerEventMask(long)"/>
        /// </summary>
        public long LayerEventMask
        {
            get { return IExecuteWithSignature<long>("getLayerEventMask", "()J"); } set { IExecuteWithSignature("setLayerEventMask", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getPreferredScrollableViewportSize()"/> 
        /// </summary>
        public Java.Awt.Dimension PreferredScrollableViewportSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getPreferredScrollableViewportSize", "()Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableTracksViewportHeight()"/> 
        /// </summary>
        public bool ScrollableTracksViewportHeight
        {
            get { return IExecuteWithSignature<bool>("getScrollableTracksViewportHeight", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableTracksViewportWidth()"/> 
        /// </summary>
        public bool ScrollableTracksViewportWidth
        {
            get { return IExecuteWithSignature<bool>("getScrollableTracksViewportWidth", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getView()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setView(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component View
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getView", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setView", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableBlockIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScrollableBlockIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableBlockIncrement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableUnitIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScrollableUnitIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableUnitIncrement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#createGlassPane()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.JPanel"/></returns>
        public Javax.Swing.JPanel CreateGlassPane()
        {
            return IExecuteWithSignature<Javax.Swing.JPanel>("createGlassPane", "()Ljavax/swing/JPanel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setUI(javax.swing.plaf.LayerUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.LayerUI"/></param>
        public void SetUI(Javax.Swing.Plaf.LayerUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/LayerUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JLayer<V>
    public partial class JLayer<V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#%3Cinit%3E(java.awt.Component,javax.swing.plaf.LayerUI)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.LayerUI"/></param>
        public JLayer(V arg0, Javax.Swing.Plaf.LayerUI<V> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#%3Cinit%3E(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        public JLayer(V arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayer{V}"/> to <see cref="Javax.Swing.Scrollable"/>
        /// </summary>
        public static implicit operator Javax.Swing.Scrollable(Javax.Swing.JLayer<V> t) => t.Cast<Javax.Swing.Scrollable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayer{V}"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.JLayer<V> t) => t.Cast<Java.Beans.PropertyChangeListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayer{V}"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JLayer<V> t) => t.Cast<Javax.Accessibility.Accessible>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayer{V}"/> to <see cref="Javax.Swing.JLayer"/>
        /// </summary>
        public static implicit operator Javax.Swing.JLayer(Javax.Swing.JLayer<V> t) => t.Cast<Javax.Swing.JLayer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setGlassPane(javax.swing.JPanel)"/>
        /// </summary>
        public Javax.Swing.JPanel GlassPane
        {
            get { return IExecuteWithSignature<Javax.Swing.JPanel>("getGlassPane", "()Ljavax/swing/JPanel;"); } set { IExecuteWithSignature("setGlassPane", "(Ljavax/swing/JPanel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getLayerEventMask()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setLayerEventMask(long)"/>
        /// </summary>
        public long LayerEventMask
        {
            get { return IExecuteWithSignature<long>("getLayerEventMask", "()J"); } set { IExecuteWithSignature("setLayerEventMask", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getPreferredScrollableViewportSize()"/> 
        /// </summary>
        public Java.Awt.Dimension PreferredScrollableViewportSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getPreferredScrollableViewportSize", "()Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableTracksViewportHeight()"/> 
        /// </summary>
        public bool ScrollableTracksViewportHeight
        {
            get { return IExecuteWithSignature<bool>("getScrollableTracksViewportHeight", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableTracksViewportWidth()"/> 
        /// </summary>
        public bool ScrollableTracksViewportWidth
        {
            get { return IExecuteWithSignature<bool>("getScrollableTracksViewportWidth", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getView()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setView(java.awt.Component)"/>
        /// </summary>
        public V View
        {
            get { return IExecuteWithSignature<V>("getView", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setView", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableBlockIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScrollableBlockIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableBlockIncrement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#getScrollableUnitIncrement(java.awt.Rectangle,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetScrollableUnitIncrement(Java.Awt.Rectangle arg0, int arg1, int arg2)
        {
            return IExecute<int>("getScrollableUnitIncrement", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#createGlassPane()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.JPanel"/></returns>
        public Javax.Swing.JPanel CreateGlassPane()
        {
            return IExecuteWithSignature<Javax.Swing.JPanel>("createGlassPane", "()Ljavax/swing/JPanel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayer.html#setUI(javax.swing.plaf.LayerUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.LayerUI"/></param>
        public void SetUI(Javax.Swing.Plaf.LayerUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/LayerUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}