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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region BufferedImageOp declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html"/>
    /// </summary>
    public partial class BufferedImageOp : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BufferedImageOp>
    {
        const string _bridgeClassName = "java.awt.image.BufferedImageOp";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BufferedImageOp class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BufferedImageOp() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BufferedImageOp class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BufferedImageOp(params object[] args) : base(args) { }

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

    #region IBufferedImageOp
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBufferedImageOp
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getRenderingHints()"/> 
        /// </summary>
        Java.Awt.RenderingHints RenderingHints { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BufferedImageOp implementation
    public partial class BufferedImageOp : Java.Awt.ImageNs.IBufferedImageOp
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getRenderingHints()"/> 
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecuteWithSignature<Java.Awt.RenderingHints>("getRenderingHints", "()Ljava/awt/RenderingHints;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("getPoint2D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds2D", "(Ljava/awt/image/BufferedImage;)Ljava/awt/geom/Rectangle2D;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createCompatibleDestImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("filter", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}