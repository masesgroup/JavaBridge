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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs.Renderable
{
    #region RenderableImage declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html"/>
    /// </summary>
    public partial class RenderableImage : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RenderableImage>
    {
        const string _bridgeClassName = "java.awt.image.renderable.RenderableImage";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RenderableImage class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RenderableImage() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RenderableImage class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RenderableImage(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IRenderableImage
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRenderableImage
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getHeight()"/> 
        /// </summary>
        float Height { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinX()"/> 
        /// </summary>
        float MinX { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinY()"/> 
        /// </summary>
        float MinY { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getPropertyNames()"/> 
        /// </summary>
        Java.Lang.String[] PropertyNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getSources()"/> 
        /// </summary>
        Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage> Sources { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getWidth()"/> 
        /// </summary>
        float Width { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#isDynamic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsDynamic();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createDefaultRendering()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage CreateDefaultRendering();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createRendering(java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage CreateRendering(Java.Awt.ImageNs.Renderable.RenderContext arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createScaledRendering(int,int,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage CreateScaledRendering(int arg0, int arg1, Java.Awt.RenderingHints arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RenderableImage implementation
    public partial class RenderableImage : Java.Awt.ImageNs.Renderable.IRenderableImage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#HINTS_OBSERVED"/>
        /// </summary>
        public static Java.Lang.String HINTS_OBSERVED { get { if (!_HINTS_OBSERVEDReady) { _HINTS_OBSERVEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HINTS_OBSERVED"); _HINTS_OBSERVEDReady = true; } return _HINTS_OBSERVEDContent; } }
        private static Java.Lang.String _HINTS_OBSERVEDContent = default;
        private static bool _HINTS_OBSERVEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getHeight()"/> 
        /// </summary>
        public float Height
        {
            get { return IExecuteWithSignature<float>("getHeight", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinX()"/> 
        /// </summary>
        public float MinX
        {
            get { return IExecuteWithSignature<float>("getMinX", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getMinY()"/> 
        /// </summary>
        public float MinY
        {
            get { return IExecuteWithSignature<float>("getMinY", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getPropertyNames()"/> 
        /// </summary>
        public Java.Lang.String[] PropertyNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getPropertyNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage> Sources
        {
            get { return IExecuteWithSignature<Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage>>("getSources", "()Ljava/util/Vector;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getWidth()"/> 
        /// </summary>
        public float Width
        {
            get { return IExecuteWithSignature<float>("getWidth", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#isDynamic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDynamic()
        {
            return IExecuteWithSignature<bool>("isDynamic", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createDefaultRendering()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateDefaultRendering()
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("createDefaultRendering", "()Ljava/awt/image/RenderedImage;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createRendering(java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateRendering(Java.Awt.ImageNs.Renderable.RenderContext arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("createRendering", "(Ljava/awt/image/renderable/RenderContext;)Ljava/awt/image/RenderedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#createScaledRendering(int,int,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateScaledRendering(int arg0, int arg1, Java.Awt.RenderingHints arg2)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("createScaledRendering", "(IILjava/awt/RenderingHints;)Ljava/awt/image/RenderedImage;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}