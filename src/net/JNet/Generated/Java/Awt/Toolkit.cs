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

namespace Java.Awt
{
    #region Toolkit
    public partial class Toolkit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getDefaultToolkit()"/> 
        /// </summary>
        public static Java.Awt.Toolkit DefaultToolkit
        {
            get { return SExecuteWithSignature<Java.Awt.Toolkit>(LocalBridgeClazz, "getDefaultToolkit", "()Ljava/awt/Toolkit;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetProperty(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getProperty", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getAWTEventListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.AWTEventListener[] AWTEventListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.AWTEventListener>("getAWTEventListeners", "()[Ljava/awt/event/AWTEventListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getColorModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.ColorModel>("getColorModel", "()Ljava/awt/image/ColorModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getMaximumCursorColors()"/> 
        /// </summary>
        public int MaximumCursorColors
        {
            get { return IExecuteWithSignature<int>("getMaximumCursorColors", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getMenuShortcutKeyMaskEx()"/> 
        /// </summary>
        public int MenuShortcutKeyMaskEx
        {
            get { return IExecuteWithSignature<int>("getMenuShortcutKeyMaskEx", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getScreenResolution()"/> 
        /// </summary>
        public int ScreenResolution
        {
            get { return IExecuteWithSignature<int>("getScreenResolution", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getScreenSize()"/> 
        /// </summary>
        public Java.Awt.Dimension ScreenSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getScreenSize", "()Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getSystemClipboard()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.Clipboard SystemClipboard
        {
            get { return IExecuteWithSignature<Java.Awt.Datatransfer.Clipboard>("getSystemClipboard", "()Ljava/awt/datatransfer/Clipboard;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getSystemEventQueue()"/> 
        /// </summary>
        public Java.Awt.EventQueue SystemEventQueue
        {
            get { return IExecuteWithSignature<Java.Awt.EventQueue>("getSystemEventQueue", "()Ljava/awt/EventQueue;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getSystemSelection()"/> 
        /// </summary>
        public Java.Awt.Datatransfer.Clipboard SystemSelection
        {
            get { return IExecuteWithSignature<Java.Awt.Datatransfer.Clipboard>("getSystemSelection", "()Ljava/awt/datatransfer/Clipboard;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createDragGestureRecognizer(java.lang.Class,java.awt.dnd.DragSource,java.awt.Component,int,java.awt.dnd.DragGestureListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Dnd.DragSource"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Dnd.DragGestureListener"/></param>
        /// <typeparam name="T"><see cref="Java.Awt.Dnd.DragGestureRecognizer"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T CreateDragGestureRecognizer<T>(Java.Lang.Class arg0, Java.Awt.Dnd.DragSource arg1, Java.Awt.Component arg2, int arg3, Java.Awt.Dnd.DragGestureListener arg4) where T : Java.Awt.Dnd.DragGestureRecognizer
        {
            return IExecute<T>("createDragGestureRecognizer", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isModalExclusionTypeSupported(java.awt.Dialog.ModalExclusionType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog.ModalExclusionType"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsModalExclusionTypeSupported(Java.Awt.Dialog.ModalExclusionType arg0)
        {
            return IExecuteWithSignature<bool>("isModalExclusionTypeSupported", "(Ljava/awt/Dialog$ModalExclusionType;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isModalityTypeSupported(java.awt.Dialog.ModalityType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsModalityTypeSupported(Java.Awt.Dialog.ModalityType arg0)
        {
            return IExecuteWithSignature<bool>("isModalityTypeSupported", "(Ljava/awt/Dialog$ModalityType;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#prepareImage(java.awt.Image,int,int,java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool PrepareImage(Java.Awt.Image arg0, int arg1, int arg2, Java.Awt.ImageNs.ImageObserver arg3)
        {
            return IExecute<bool>("prepareImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#checkImage(java.awt.Image,int,int,java.awt.image.ImageObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.ImageObserver"/></param>
        /// <returns><see cref="int"/></returns>
        public int CheckImage(Java.Awt.Image arg0, int arg1, int arg2, Java.Awt.ImageNs.ImageObserver arg3)
        {
            return IExecute<int>("checkImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image CreateImage(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.Image>("createImage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(java.awt.image.ImageProducer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageProducer"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image CreateImage(Java.Awt.ImageNs.ImageProducer arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("createImage", "(Ljava/awt/image/ImageProducer;)Ljava/awt/Image;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image CreateImage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("createImage", "(Ljava/lang/String;)Ljava/awt/Image;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image CreateImage(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("createImage", "(Ljava/net/URL;)Ljava/awt/Image;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getImage(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetImage(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("getImage", "(Ljava/lang/String;)Ljava/awt/Image;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getImage(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetImage(Java.Net.URL arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("getImage", "(Ljava/net/URL;)Ljava/awt/Image;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getPrintJob(java.awt.Frame,java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Awt.PrintJob"/></returns>
        public Java.Awt.PrintJob GetPrintJob(Java.Awt.Frame arg0, Java.Lang.String arg1, Java.Util.Properties arg2)
        {
            return IExecute<Java.Awt.PrintJob>("getPrintJob", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#mapInputMethodHighlight(java.awt.im.InputMethodHighlight)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Im.InputMethodHighlight"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Util.Map<Java.Awt.FontNs.TextAttribute, object> MapInputMethodHighlight(Java.Awt.Im.InputMethodHighlight arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Awt.FontNs.TextAttribute, object>>("mapInputMethodHighlight", "(Ljava/awt/im/InputMethodHighlight;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#beep()"/>
        /// </summary>
        public void Beep()
        {
            IExecuteWithSignature("beep", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#sync()"/>
        /// </summary>
        public void Sync()
        {
            IExecuteWithSignature("sync", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#areExtraMouseButtonsEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public bool AreExtraMouseButtonsEnabled()
        {
            return IExecuteWithSignature<bool>("areExtraMouseButtonsEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getLockingKeyState(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public bool GetLockingKeyState(int arg0)
        {
            return IExecuteWithSignature<bool>("getLockingKeyState", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isAlwaysOnTopSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlwaysOnTopSupported()
        {
            return IExecuteWithSignature<bool>("isAlwaysOnTopSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isDynamicLayoutActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public bool IsDynamicLayoutActive()
        {
            return IExecuteWithSignature<bool>("isDynamicLayoutActive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#isFrameStateSupported(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public bool IsFrameStateSupported(int arg0)
        {
            return IExecuteWithSignature<bool>("isFrameStateSupported", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getDesktopProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDesktopProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getDesktopProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createCustomCursor(java.awt.Image,java.awt.Point,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Cursor"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Cursor CreateCustomCursor(Java.Awt.Image arg0, Java.Awt.Point arg1, Java.Lang.String arg2)
        {
            return IExecute<Java.Awt.Cursor>("createCustomCursor", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getBestCursorSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Dimension GetBestCursorSize(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Dimension>("getBestCursorSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getAWTEventListeners(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Awt.EventNs.AWTEventListener"/></returns>
        public Java.Awt.EventNs.AWTEventListener[] GetAWTEventListeners(long arg0)
        {
            return IExecuteWithSignatureArray<Java.Awt.EventNs.AWTEventListener>("getAWTEventListeners", "(J)[Ljava/awt/event/AWTEventListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#createImage(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image CreateImage(byte[] arg0)
        {
            return IExecuteWithSignature<Java.Awt.Image>("createImage", "([B)Ljava/awt/Image;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getScreenInsets(java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Java.Awt.Insets GetScreenInsets(Java.Awt.GraphicsConfiguration arg0)
        {
            return IExecuteWithSignature<Java.Awt.Insets>("getScreenInsets", "(Ljava/awt/GraphicsConfiguration;)Ljava/awt/Insets;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getPrintJob(java.awt.Frame,java.lang.String,java.awt.JobAttributes,java.awt.PageAttributes)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Awt.JobAttributes"/></param>
        /// <param name="arg3"><see cref="Java.Awt.PageAttributes"/></param>
        /// <returns><see cref="Java.Awt.PrintJob"/></returns>
        public Java.Awt.PrintJob GetPrintJob(Java.Awt.Frame arg0, Java.Lang.String arg1, Java.Awt.JobAttributes arg2, Java.Awt.PageAttributes arg3)
        {
            return IExecute<Java.Awt.PrintJob>("getPrintJob", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#getPropertyChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#addAWTEventListener(java.awt.event.AWTEventListener,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AWTEventListener"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void AddAWTEventListener(Java.Awt.EventNs.AWTEventListener arg0, long arg1)
        {
            IExecute("addAWTEventListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#removeAWTEventListener(java.awt.event.AWTEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.AWTEventListener"/></param>
        public void RemoveAWTEventListener(Java.Awt.EventNs.AWTEventListener arg0)
        {
            IExecuteWithSignature("removeAWTEventListener", "(Ljava/awt/event/AWTEventListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#setDynamicLayout(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public void SetDynamicLayout(bool arg0)
        {
            IExecuteWithSignature("setDynamicLayout", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Toolkit.html#setLockingKeyState(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.UnsupportedOperationException"/>
        public void SetLockingKeyState(int arg0, bool arg1)
        {
            IExecute("setLockingKeyState", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}