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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs.Renderable
{
    #region ContextualRenderedImageFactory definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html"/>
    /// </summary>
    public partial class ContextualRenderedImageFactory : Java.Awt.ImageNs.Renderable.RenderedImageFactory
    {
        const string _bridgeClassName = "java.awt.image.renderable.ContextualRenderedImageFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ContextualRenderedImageFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ContextualRenderedImageFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ContextualRenderedImageFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ContextualRenderedImageFactory(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IContextualRenderedImageFactory
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IContextualRenderedImageFactory : Java.Awt.ImageNs.Renderable.IRenderedImageFactory
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getPropertyNames()"/> 
        /// </summary>
        Java.Lang.String[] PropertyNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#isDynamic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsDynamic();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getBounds2D(java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Renderable.ParameterBlock arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#mapRenderContext(int,java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock,java.awt.image.renderable.RenderableImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></returns>
        Java.Awt.ImageNs.Renderable.RenderContext MapRenderContext(int arg0, Java.Awt.ImageNs.Renderable.RenderContext arg1, Java.Awt.ImageNs.Renderable.ParameterBlock arg2, Java.Awt.ImageNs.Renderable.RenderableImage arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#create(java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        Java.Awt.ImageNs.RenderedImage Create(Java.Awt.ImageNs.Renderable.RenderContext arg0, Java.Awt.ImageNs.Renderable.ParameterBlock arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getProperty(java.awt.image.renderable.ParameterBlock,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(Java.Awt.ImageNs.Renderable.ParameterBlock arg0, Java.Lang.String arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ContextualRenderedImageFactory
    public partial class ContextualRenderedImageFactory : Java.Awt.ImageNs.Renderable.IContextualRenderedImageFactory
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getPropertyNames()"/> 
        /// </summary>
        public Java.Lang.String[] PropertyNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getPropertyNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#isDynamic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDynamic()
        {
            return IExecuteWithSignature<bool>("isDynamic", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getBounds2D(java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Renderable.ParameterBlock arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds2D", "(Ljava/awt/image/renderable/ParameterBlock;)Ljava/awt/geom/Rectangle2D;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#mapRenderContext(int,java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock,java.awt.image.renderable.RenderableImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></returns>
        public Java.Awt.ImageNs.Renderable.RenderContext MapRenderContext(int arg0, Java.Awt.ImageNs.Renderable.RenderContext arg1, Java.Awt.ImageNs.Renderable.ParameterBlock arg2, Java.Awt.ImageNs.Renderable.RenderableImage arg3)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.RenderContext>("mapRenderContext", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#create(java.awt.image.renderable.RenderContext,java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage Create(Java.Awt.ImageNs.Renderable.RenderContext arg0, Java.Awt.ImageNs.Renderable.ParameterBlock arg1)
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("create", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/ContextualRenderedImageFactory.html#getProperty(java.awt.image.renderable.ParameterBlock,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Awt.ImageNs.Renderable.ParameterBlock arg0, Java.Lang.String arg1)
        {
            return IExecute("getProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}