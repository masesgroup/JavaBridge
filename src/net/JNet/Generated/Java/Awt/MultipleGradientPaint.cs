/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region MultipleGradientPaint
    public partial class MultipleGradientPaint
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getColors()"/> 
        /// </summary>
        public Java.Awt.Color[] Colors
        {
            get { return IExecuteArray<Java.Awt.Color>("getColors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getColorSpace()"/> 
        /// </summary>
        public Java.Awt.MultipleGradientPaint.ColorSpaceType ColorSpace
        {
            get { return IExecute<Java.Awt.MultipleGradientPaint.ColorSpaceType>("getColorSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getFractions()"/> 
        /// </summary>
        public float[] Fractions
        {
            get { return IExecuteArray<float>("getFractions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getCycleMethod()"/> 
        /// </summary>
        public Java.Awt.MultipleGradientPaint.CycleMethod GetCycleMethod
        {
            get { return IExecute<Java.Awt.MultipleGradientPaint.CycleMethod>("getCycleMethod"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecute<Java.Awt.Geom.AffineTransform>("getTransform"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecute<int>("getTransparency"); }
        }

        #endregion

        #region Nested classes
        #region ColorSpaceType
        public partial class ColorSpaceType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#LINEAR_RGB"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType LINEAR_RGB { get { return SGetField<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "LINEAR_RGB"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#SRGB"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType SRGB { get { return SGetField<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "SRGB"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.MultipleGradientPaint.ColorSpaceType"/></returns>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType ValueOf(string arg0)
            {
                return SExecute<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.ColorSpaceType.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Awt.MultipleGradientPaint.ColorSpaceType"/></returns>
            public static Java.Awt.MultipleGradientPaint.ColorSpaceType[] Values()
            {
                return SExecuteArray<Java.Awt.MultipleGradientPaint.ColorSpaceType>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CycleMethod
        public partial class CycleMethod
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#NO_CYCLE"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.CycleMethod NO_CYCLE { get { return SGetField<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "NO_CYCLE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#REFLECT"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.CycleMethod REFLECT { get { return SGetField<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "REFLECT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#REPEAT"/>
            /// </summary>
            public static Java.Awt.MultipleGradientPaint.CycleMethod REPEAT { get { return SGetField<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "REPEAT"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></returns>
            public static Java.Awt.MultipleGradientPaint.CycleMethod ValueOf(string arg0)
            {
                return SExecute<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MultipleGradientPaint.CycleMethod.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></returns>
            public static Java.Awt.MultipleGradientPaint.CycleMethod[] Values()
            {
                return SExecuteArray<Java.Awt.MultipleGradientPaint.CycleMethod>(LocalBridgeClazz, "values");
            }

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