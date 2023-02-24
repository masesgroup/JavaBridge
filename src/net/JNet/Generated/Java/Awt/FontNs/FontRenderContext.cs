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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region FontRenderContext
    public partial class FontRenderContext
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#%3Cinit%3E(java.awt.geom.AffineTransform,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see langword="bool"/></param>
        /// <param name="arg2"><see langword="bool"/></param>
        public FontRenderContext(Java.Awt.Geom.AffineTransform arg0, bool arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#%3Cinit%3E(java.awt.geom.AffineTransform,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <param name="arg2"><see langword="object"/></param>
        public FontRenderContext(Java.Awt.Geom.AffineTransform arg0, object arg1, object arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#getAntiAliasingHint()"/> 
        /// </summary>
        public object AntiAliasingHint
        {
            get { return IExecute("getAntiAliasingHint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#getFractionalMetricsHint()"/> 
        /// </summary>
        public object FractionalMetricsHint
        {
            get { return IExecute("getFractionalMetricsHint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#getTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform Transform
        {
            get { return IExecute<Java.Awt.Geom.AffineTransform>("getTransform"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#getTransformType()"/> 
        /// </summary>
        public int TransformType
        {
            get { return IExecute<int>("getTransformType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#isAntiAliased()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsAntiAliased()
        {
            return IExecute<bool>("isAntiAliased");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#isTransformed()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsTransformed()
        {
            return IExecute<bool>("isTransformed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/FontRenderContext.html#usesFractionalMetrics()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool UsesFractionalMetrics()
        {
            return IExecute<bool>("usesFractionalMetrics");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}