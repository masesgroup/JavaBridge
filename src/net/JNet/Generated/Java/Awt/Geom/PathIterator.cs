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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region PathIterator
    public partial class PathIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_CLOSE"/>
        /// </summary>
        public static int SEG_CLOSE => Clazz.GetField<int>("SEG_CLOSE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_CUBICTO"/>
        /// </summary>
        public static int SEG_CUBICTO => Clazz.GetField<int>("SEG_CUBICTO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_LINETO"/>
        /// </summary>
        public static int SEG_LINETO => Clazz.GetField<int>("SEG_LINETO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_MOVETO"/>
        /// </summary>
        public static int SEG_MOVETO => Clazz.GetField<int>("SEG_MOVETO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#SEG_QUADTO"/>
        /// </summary>
        public static int SEG_QUADTO => Clazz.GetField<int>("SEG_QUADTO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#WIND_EVEN_ODD"/>
        /// </summary>
        public static int WIND_EVEN_ODD => Clazz.GetField<int>("WIND_EVEN_ODD");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#WIND_NON_ZERO"/>
        /// </summary>
        public static int WIND_NON_ZERO => Clazz.GetField<int>("WIND_NON_ZERO");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#isDone()"/> 
        /// </summary>
        public bool IsDone
        {
            get { return IExecute<bool>("isDone"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#getWindingRule()"/> 
        /// </summary>
        public int WindingRule
        {
            get { return IExecute<int>("getWindingRule"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#currentSegment(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public int CurrentSegment(double[] arg0)
        {
            return IExecute<int>("currentSegment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#currentSegment(float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public int CurrentSegment(float[] arg0)
        {
            return IExecute<int>("currentSegment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/PathIterator.html#next()"/>
        /// </summary>
        public void Next()
        {
            IExecute("next");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}