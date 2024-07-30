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

namespace Java.Awt.Geom
{
    #region QuadCurve2D
    public partial class QuadCurve2D
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.QuadCurve2D"/> to <see cref="Java.Awt.Shape"/>
        /// </summary>
        public static implicit operator Java.Awt.Shape(Java.Awt.Geom.QuadCurve2D t) => t.Cast<Java.Awt.Shape>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.QuadCurve2D"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Geom.QuadCurve2D t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getFlatness(double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatness(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatness", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getFlatness(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatness(double[] arg0, int arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatness", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getFlatnessSq(double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatnessSq(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatnessSq", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getFlatnessSq(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public static double GetFlatnessSq(double[] arg0, int arg1)
        {
            return SExecute<double>(LocalBridgeClazz, "getFlatnessSq", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#solveQuadratic(double[],double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SolveQuadratic(double[] arg0, double[] arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "solveQuadratic", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#solveQuadratic(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public static int SolveQuadratic(double[] arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "solveQuadratic", "([D)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#subdivide(double[],int,double[],int,double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public static void Subdivide(double[] arg0, int arg1, double[] arg2, int arg3, double[] arg4, int arg5)
        {
            SExecute(LocalBridgeClazz, "subdivide", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#subdivide(java.awt.geom.QuadCurve2D,java.awt.geom.QuadCurve2D,java.awt.geom.QuadCurve2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.QuadCurve2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.QuadCurve2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.QuadCurve2D"/></param>
        public static void Subdivide(Java.Awt.Geom.QuadCurve2D arg0, Java.Awt.Geom.QuadCurve2D arg1, Java.Awt.Geom.QuadCurve2D arg2)
        {
            SExecute(LocalBridgeClazz, "subdivide", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getBounds", "()Ljava/awt/Rectangle;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getCtrlPt()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D CtrlPt
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getCtrlPt", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getCtrlX()"/> 
        /// </summary>
        public double CtrlX
        {
            get { return IExecuteWithSignature<double>("getCtrlX", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getCtrlY()"/> 
        /// </summary>
        public double CtrlY
        {
            get { return IExecuteWithSignature<double>("getCtrlY", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getFlatness()"/> 
        /// </summary>
        public double Flatness
        {
            get { return IExecuteWithSignature<double>("getFlatness", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getFlatnessSq()"/> 
        /// </summary>
        public double FlatnessSq
        {
            get { return IExecuteWithSignature<double>("getFlatnessSq", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getP1()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D P1
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getP1", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getP2()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D P2
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getP2", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getX1()"/> 
        /// </summary>
        public double X1
        {
            get { return IExecuteWithSignature<double>("getX1", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getX2()"/> 
        /// </summary>
        public double X2
        {
            get { return IExecuteWithSignature<double>("getX2", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getY1()"/> 
        /// </summary>
        public double Y1
        {
            get { return IExecuteWithSignature<double>("getY1", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getY2()"/> 
        /// </summary>
        public double Y2
        {
            get { return IExecuteWithSignature<double>("getY2", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#setCurve(double,double,double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        public void SetCurve(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
        {
            IExecute("setCurve", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#contains(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("contains", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#contains(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#contains(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Point2D arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/awt/geom/Point2D;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#contains(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecuteWithSignature<bool>("contains", "(Ljava/awt/geom/Rectangle2D;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#intersects(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("intersects", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#intersects(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecuteWithSignature<bool>("intersects", "(Ljava/awt/geom/Rectangle2D;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getPathIterator(java.awt.geom.AffineTransform,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0, double arg1)
        {
            return IExecute<Java.Awt.Geom.PathIterator>("getPathIterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#getPathIterator(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.PathIterator>("getPathIterator", "(Ljava/awt/geom/AffineTransform;)Ljava/awt/geom/PathIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#setCurve(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetCurve(double[] arg0, int arg1)
        {
            IExecute("setCurve", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#setCurve(java.awt.geom.Point2D,java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void SetCurve(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1, Java.Awt.Geom.Point2D arg2)
        {
            IExecute("setCurve", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#setCurve(java.awt.geom.Point2D[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetCurve(Java.Awt.Geom.Point2D[] arg0, int arg1)
        {
            IExecute("setCurve", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#setCurve(java.awt.geom.QuadCurve2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.QuadCurve2D"/></param>
        public void SetCurve(Java.Awt.Geom.QuadCurve2D arg0)
        {
            IExecuteWithSignature("setCurve", "(Ljava/awt/geom/QuadCurve2D;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.html#subdivide(java.awt.geom.QuadCurve2D,java.awt.geom.QuadCurve2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.QuadCurve2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.QuadCurve2D"/></param>
        public void Subdivide(Java.Awt.Geom.QuadCurve2D arg0, Java.Awt.Geom.QuadCurve2D arg1)
        {
            IExecute("subdivide", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Double
        public partial class Double
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Double.html#%3Cinit%3E(double,double,double,double,double,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            /// <param name="arg4"><see cref="double"/></param>
            /// <param name="arg5"><see cref="double"/></param>
            public Double(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.QuadCurve2D.Double"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.QuadCurve2D.Double t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Double.html#ctrlx"/>
            /// </summary>
            public double ctrlx { get { return IGetField<double>("ctrlx"); } set { ISetField("ctrlx", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Double.html#ctrly"/>
            /// </summary>
            public double ctrly { get { return IGetField<double>("ctrly"); } set { ISetField("ctrly", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Double.html#x1"/>
            /// </summary>
            public double x1 { get { return IGetField<double>("x1"); } set { ISetField("x1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Double.html#x2"/>
            /// </summary>
            public double x2 { get { return IGetField<double>("x2"); } set { ISetField("x2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Double.html#y1"/>
            /// </summary>
            public double y1 { get { return IGetField<double>("y1"); } set { ISetField("y1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Double.html#y2"/>
            /// </summary>
            public double y2 { get { return IGetField<double>("y2"); } set { ISetField("y2", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Float
        public partial class Float
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#%3Cinit%3E(float,float,float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            public Float(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.QuadCurve2D.Float"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.QuadCurve2D.Float t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#ctrlx"/>
            /// </summary>
            public float ctrlx { get { return IGetField<float>("ctrlx"); } set { ISetField("ctrlx", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#ctrly"/>
            /// </summary>
            public float ctrly { get { return IGetField<float>("ctrly"); } set { ISetField("ctrly", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#x1"/>
            /// </summary>
            public float x1 { get { return IGetField<float>("x1"); } set { ISetField("x1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#x2"/>
            /// </summary>
            public float x2 { get { return IGetField<float>("x2"); } set { ISetField("x2", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#y1"/>
            /// </summary>
            public float y1 { get { return IGetField<float>("y1"); } set { ISetField("y1", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#y2"/>
            /// </summary>
            public float y2 { get { return IGetField<float>("y2"); } set { ISetField("y2", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/QuadCurve2D.Float.html#setCurve(float,float,float,float,float,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            public void SetCurve(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
            {
                IExecute("setCurve", arg0, arg1, arg2, arg3, arg4, arg5);
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