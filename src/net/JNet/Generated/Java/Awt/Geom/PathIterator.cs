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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region IPathIterator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPathIterator
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#getWindingRule()"/> 
        /// </summary>
        int WindingRule { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#isDone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsDone();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#currentSegment(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        int CurrentSegment(double[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#currentSegment(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        int CurrentSegment(float[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#next()"/>
        /// </summary>
        void Next();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PathIterator
    public partial class PathIterator : Java.Awt.Geom.IPathIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_CLOSE"/>
        /// </summary>
        public static int SEG_CLOSE { get { if (!_SEG_CLOSEReady) { _SEG_CLOSEContent = SGetField<int>(LocalBridgeClazz, "SEG_CLOSE"); _SEG_CLOSEReady = true; } return _SEG_CLOSEContent; } }
        private static int _SEG_CLOSEContent = default;
        private static bool _SEG_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_CUBICTO"/>
        /// </summary>
        public static int SEG_CUBICTO { get { if (!_SEG_CUBICTOReady) { _SEG_CUBICTOContent = SGetField<int>(LocalBridgeClazz, "SEG_CUBICTO"); _SEG_CUBICTOReady = true; } return _SEG_CUBICTOContent; } }
        private static int _SEG_CUBICTOContent = default;
        private static bool _SEG_CUBICTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_LINETO"/>
        /// </summary>
        public static int SEG_LINETO { get { if (!_SEG_LINETOReady) { _SEG_LINETOContent = SGetField<int>(LocalBridgeClazz, "SEG_LINETO"); _SEG_LINETOReady = true; } return _SEG_LINETOContent; } }
        private static int _SEG_LINETOContent = default;
        private static bool _SEG_LINETOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_MOVETO"/>
        /// </summary>
        public static int SEG_MOVETO { get { if (!_SEG_MOVETOReady) { _SEG_MOVETOContent = SGetField<int>(LocalBridgeClazz, "SEG_MOVETO"); _SEG_MOVETOReady = true; } return _SEG_MOVETOContent; } }
        private static int _SEG_MOVETOContent = default;
        private static bool _SEG_MOVETOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_QUADTO"/>
        /// </summary>
        public static int SEG_QUADTO { get { if (!_SEG_QUADTOReady) { _SEG_QUADTOContent = SGetField<int>(LocalBridgeClazz, "SEG_QUADTO"); _SEG_QUADTOReady = true; } return _SEG_QUADTOContent; } }
        private static int _SEG_QUADTOContent = default;
        private static bool _SEG_QUADTOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#WIND_EVEN_ODD"/>
        /// </summary>
        public static int WIND_EVEN_ODD { get { if (!_WIND_EVEN_ODDReady) { _WIND_EVEN_ODDContent = SGetField<int>(LocalBridgeClazz, "WIND_EVEN_ODD"); _WIND_EVEN_ODDReady = true; } return _WIND_EVEN_ODDContent; } }
        private static int _WIND_EVEN_ODDContent = default;
        private static bool _WIND_EVEN_ODDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#WIND_NON_ZERO"/>
        /// </summary>
        public static int WIND_NON_ZERO { get { if (!_WIND_NON_ZEROReady) { _WIND_NON_ZEROContent = SGetField<int>(LocalBridgeClazz, "WIND_NON_ZERO"); _WIND_NON_ZEROReady = true; } return _WIND_NON_ZEROContent; } }
        private static int _WIND_NON_ZEROContent = default;
        private static bool _WIND_NON_ZEROReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#getWindingRule()"/> 
        /// </summary>
        public int WindingRule
        {
            get { return IExecuteWithSignature<int>("getWindingRule", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#isDone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDone()
        {
            return IExecuteWithSignature<bool>("isDone", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#currentSegment(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public int CurrentSegment(double[] arg0)
        {
            return IExecuteWithSignature<int>("currentSegment", "([D)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#currentSegment(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int CurrentSegment(float[] arg0)
        {
            return IExecuteWithSignature<int>("currentSegment", "([F)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#next()"/>
        /// </summary>
        public void Next()
        {
            IExecuteWithSignature("next", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}