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

namespace Java.Awt.Geom
{
    #region RectangularShape
    public partial class RectangularShape
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.RectangularShape"/> to <see cref="Java.Awt.Shape"/>
        /// </summary>
        public static implicit operator Java.Awt.Shape(Java.Awt.Geom.RectangularShape t) => t.Cast<Java.Awt.Shape>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.RectangularShape"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Geom.RectangularShape t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getBounds", "()Ljava/awt/Rectangle;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getCenterX()"/> 
        /// </summary>
        public double CenterX
        {
            get { return IExecuteWithSignature<double>("getCenterX", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getCenterY()"/> 
        /// </summary>
        public double CenterY
        {
            get { return IExecuteWithSignature<double>("getCenterY", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getFrame()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#setFrame(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        public Java.Awt.Geom.Rectangle2D Frame
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getFrame", "()Ljava/awt/geom/Rectangle2D;"); } set { IExecuteWithSignature("setFrame", "(Ljava/awt/geom/Rectangle2D;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getHeight()"/> 
        /// </summary>
        public double Height
        {
            get { return IExecuteWithSignature<double>("getHeight", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getMaxX()"/> 
        /// </summary>
        public double MaxX
        {
            get { return IExecuteWithSignature<double>("getMaxX", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getMaxY()"/> 
        /// </summary>
        public double MaxY
        {
            get { return IExecuteWithSignature<double>("getMaxY", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getMinX()"/> 
        /// </summary>
        public double MinX
        {
            get { return IExecuteWithSignature<double>("getMinX", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getMinY()"/> 
        /// </summary>
        public double MinY
        {
            get { return IExecuteWithSignature<double>("getMinY", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getWidth()"/> 
        /// </summary>
        public double Width
        {
            get { return IExecuteWithSignature<double>("getWidth", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getX()"/> 
        /// </summary>
        public double X
        {
            get { return IExecuteWithSignature<double>("getX", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getY()"/> 
        /// </summary>
        public double Y
        {
            get { return IExecuteWithSignature<double>("getY", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#isEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#setFrame(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetFrame(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("setFrame", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#contains(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Point2D arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/awt/geom/Point2D;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#contains(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/awt/geom/Rectangle2D;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#intersects(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecuteWithSignature<bool>("intersects", "(Ljava/awt/geom/Rectangle2D;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#getPathIterator(java.awt.geom.AffineTransform,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0, double arg1)
        {
            return IExecute<Java.Awt.Geom.PathIterator>("getPathIterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#setFrame(java.awt.geom.Point2D,java.awt.geom.Dimension2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Dimension2D"/></param>
        public void SetFrame(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Dimension2D arg1)
        {
            IExecute("setFrame", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#setFrameFromCenter(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetFrameFromCenter(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("setFrameFromCenter", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#setFrameFromCenter(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void SetFrameFromCenter(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            IExecute("setFrameFromCenter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#setFrameFromDiagonal(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetFrameFromDiagonal(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("setFrameFromDiagonal", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/RectangularShape.html#setFrameFromDiagonal(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void SetFrameFromDiagonal(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            IExecute("setFrameFromDiagonal", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}