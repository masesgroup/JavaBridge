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

namespace Javax.Swing.Border
{
    #region StrokeBorder
    public partial class StrokeBorder
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/StrokeBorder.html#%3Cinit%3E(java.awt.BasicStroke,java.awt.Paint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.BasicStroke"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Paint"/></param>
        public StrokeBorder(Java.Awt.BasicStroke arg0, Java.Awt.Paint arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/StrokeBorder.html#%3Cinit%3E(java.awt.BasicStroke)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.BasicStroke"/></param>
        public StrokeBorder(Java.Awt.BasicStroke arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/StrokeBorder.html#getPaint()"/> 
        /// </summary>
        public Java.Awt.Paint Paint
        {
            get { return IExecuteWithSignature<Java.Awt.Paint>("getPaint", "()Ljava/awt/Paint;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/StrokeBorder.html#getStroke()"/> 
        /// </summary>
        public Java.Awt.BasicStroke Stroke
        {
            get { return IExecuteWithSignature<Java.Awt.BasicStroke>("getStroke", "()Ljava/awt/BasicStroke;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}