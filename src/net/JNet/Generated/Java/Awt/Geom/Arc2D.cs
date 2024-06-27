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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region Arc2D
    public partial class Arc2D
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#CHORD"/>
        /// </summary>
        public static int CHORD { get { if (!_CHORDReady) { _CHORDContent = SGetField<int>(LocalBridgeClazz, "CHORD"); _CHORDReady = true; } return _CHORDContent; } }
        private static int _CHORDContent = default;
        private static bool _CHORDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#OPEN"/>
        /// </summary>
        public static int OPEN { get { if (!_OPENReady) { _OPENContent = SGetField<int>(LocalBridgeClazz, "OPEN"); _OPENReady = true; } return _OPENContent; } }
        private static int _OPENContent = default;
        private static bool _OPENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#PIE"/>
        /// </summary>
        public static int PIE { get { if (!_PIEReady) { _PIEContent = SGetField<int>(LocalBridgeClazz, "PIE"); _PIEReady = true; } return _PIEContent; } }
        private static int _PIEContent = default;
        private static bool _PIEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getAngleExtent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngleExtent(double)"/>
        /// </summary>
        public double AngleExtent
        {
            get { return IExecuteWithSignature<double>("getAngleExtent", "()D"); } set { IExecuteWithSignature("setAngleExtent", "(D)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getAngleStart()"/> 
        /// </summary>
        public double AngleStart
        {
            get { return IExecuteWithSignature<double>("getAngleStart", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getArcType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArcType(int)"/>
        /// </summary>
        public int ArcType
        {
            get { return IExecuteWithSignature<int>("getArcType", "()I"); } set { IExecuteWithSignature("setArcType", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getEndPoint()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D EndPoint
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getEndPoint", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#getStartPoint()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D StartPoint
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Point2D>("getStartPoint", "()Ljava/awt/geom/Point2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngleStart(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public void SetAngleStart(double arg0)
        {
            IExecuteWithSignature("setAngleStart", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(double,double,double,double,double,double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public void SetArc(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6)
        {
            IExecute("setArc", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#containsAngle(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAngle(double arg0)
        {
            return IExecuteWithSignature<bool>("containsAngle", "(D)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngles(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetAngles(double arg0, double arg1, double arg2, double arg3)
        {
            IExecute("setAngles", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngles(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void SetAngles(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            IExecute("setAngles", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setAngleStart(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void SetAngleStart(Java.Awt.Geom.Point2D arg0)
        {
            IExecuteWithSignature("setAngleStart", "(Ljava/awt/geom/Point2D;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(java.awt.geom.Arc2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Arc2D"/></param>
        public void SetArc(Java.Awt.Geom.Arc2D arg0)
        {
            IExecuteWithSignature("setArc", "(Ljava/awt/geom/Arc2D;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(java.awt.geom.Point2D,java.awt.geom.Dimension2D,double,double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Dimension2D"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void SetArc(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Dimension2D arg1, double arg2, double arg3, int arg4)
        {
            IExecute("setArc", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArc(java.awt.geom.Rectangle2D,double,double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetArc(Java.Awt.Geom.Rectangle2D arg0, double arg1, double arg2, int arg3)
        {
            IExecute("setArc", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArcByCenter(double,double,double,double,double,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void SetArcByCenter(double arg0, double arg1, double arg2, double arg3, double arg4, int arg5)
        {
            IExecute("setArcByCenter", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.html#setArcByTangent(java.awt.geom.Point2D,java.awt.geom.Point2D,java.awt.geom.Point2D,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetArcByTangent(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1, Java.Awt.Geom.Point2D arg2, double arg3)
        {
            IExecute("setArcByTangent", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes
        #region Double
        public partial class Double
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#%3Cinit%3E(double,double,double,double,double,double,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="double"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            /// <param name="arg3"><see cref="double"/></param>
            /// <param name="arg4"><see cref="double"/></param>
            /// <param name="arg5"><see cref="double"/></param>
            /// <param name="arg6"><see cref="int"/></param>
            public Double(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, int arg6)
                : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Double(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#%3Cinit%3E(java.awt.geom.Rectangle2D,double,double,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            /// <param name="arg2"><see cref="double"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public Double(Java.Awt.Geom.Rectangle2D arg0, double arg1, double arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.Arc2D.Double"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Arc2D.Double t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#extent"/>
            /// </summary>
            public double extent { get { return IGetField<double>("extent"); } set { ISetField("extent", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#height"/>
            /// </summary>
            public double height { get { return IGetField<double>("height"); } set { ISetField("height", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#start"/>
            /// </summary>
            public double start { get { return IGetField<double>("start"); } set { ISetField("start", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#width"/>
            /// </summary>
            public double width { get { return IGetField<double>("width"); } set { ISetField("width", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#x"/>
            /// </summary>
            public double x { get { return IGetField<double>("x"); } set { ISetField("x", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Double.html#y"/>
            /// </summary>
            public double y { get { return IGetField<double>("y"); } set { ISetField("y", value); } }

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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#%3Cinit%3E(float,float,float,float,float,float,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="float"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="float"/></param>
            /// <param name="arg6"><see cref="int"/></param>
            public Float(float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, int arg6)
                : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public Float(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#%3Cinit%3E(java.awt.geom.Rectangle2D,float,float,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public Float(Java.Awt.Geom.Rectangle2D arg0, float arg1, float arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Awt.Geom.Arc2D.Float"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Awt.Geom.Arc2D.Float t) => t.Cast<Java.Io.Serializable>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#extent"/>
            /// </summary>
            public float extent { get { return IGetField<float>("extent"); } set { ISetField("extent", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#height"/>
            /// </summary>
            public float height { get { return IGetField<float>("height"); } set { ISetField("height", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#start"/>
            /// </summary>
            public float start { get { return IGetField<float>("start"); } set { ISetField("start", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#width"/>
            /// </summary>
            public float width { get { return IGetField<float>("width"); } set { ISetField("width", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#x"/>
            /// </summary>
            public float x { get { return IGetField<float>("x"); } set { ISetField("x", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Arc2D.Float.html#y"/>
            /// </summary>
            public float y { get { return IGetField<float>("y"); } set { ISetField("y", value); } }

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}