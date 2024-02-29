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
    #region GradientPaint
    public partial class GradientPaint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#%3Cinit%3E(float,float,java.awt.Color,float,float,java.awt.Color,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        public GradientPaint(float arg0, float arg1, Java.Awt.Color arg2, float arg3, float arg4, Java.Awt.Color arg5, bool arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#%3Cinit%3E(float,float,java.awt.Color,float,float,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        public GradientPaint(float arg0, float arg1, Java.Awt.Color arg2, float arg3, float arg4, Java.Awt.Color arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,java.awt.Color,java.awt.geom.Point2D,java.awt.Color,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public GradientPaint(Java.Awt.Geom.Point2D arg0, Java.Awt.Color arg1, Java.Awt.Geom.Point2D arg2, Java.Awt.Color arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,java.awt.Color,java.awt.geom.Point2D,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        public GradientPaint(Java.Awt.Geom.Point2D arg0, Java.Awt.Color arg1, Java.Awt.Geom.Point2D arg2, Java.Awt.Color arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#getColor1()"/> 
        /// </summary>
        public Java.Awt.Color Color1
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getColor1", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#getColor2()"/> 
        /// </summary>
        public Java.Awt.Color Color2
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getColor2", "()Ljava/awt/Color;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#getPoint1()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D Point1
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getPoint1", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#getPoint2()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D Point2
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getPoint2", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecuteWithSignature<int>("getTransparency", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#isCyclic()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCyclic()
        {
            return IExecuteWithSignature<bool>("isCyclic", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GradientPaint.html#createContext(java.awt.image.ColorModel,java.awt.Rectangle,java.awt.geom.Rectangle2D,java.awt.geom.AffineTransform,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg4"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.PaintContext"/></returns>
        public Java.Awt.PaintContext CreateContext(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.Rectangle arg1, Java.Awt.Geom.Rectangle2D arg2, Java.Awt.Geom.AffineTransform arg3, Java.Awt.RenderingHints arg4)
        {
            return IExecute<Java.Awt.PaintContext>("createContext", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}