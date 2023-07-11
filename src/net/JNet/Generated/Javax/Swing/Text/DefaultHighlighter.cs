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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region DefaultHighlighter
    public partial class DefaultHighlighter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultHighlighter.html#DefaultPainter"/>
        /// </summary>
        public static Javax.Swing.Text.LayeredHighlighter.LayerPainter DefaultPainter { get { return SGetField<Javax.Swing.Text.LayeredHighlighter.LayerPainter>(LocalBridgeClazz, "DefaultPainter"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultHighlighter.html#getDrawsLayeredHighlights()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultHighlighter.html#setDrawsLayeredHighlights(boolean)"/>
        /// </summary>
        public bool DrawsLayeredHighlights
        {
            get { return IExecute<bool>("getDrawsLayeredHighlights"); } set { IExecute("setDrawsLayeredHighlights", value); }
        }

        #endregion

        #region Nested classes
        #region DefaultHighlightPainter
        public partial class DefaultHighlightPainter
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultHighlighter.DefaultHighlightPainter.html#%3Cinit%3E(java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            public DefaultHighlightPainter(Java.Awt.Color arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/DefaultHighlighter.DefaultHighlightPainter.html#getColor()"/> 
            /// </summary>
            public Java.Awt.Color Color
            {
                get { return IExecute<Java.Awt.Color>("getColor"); }
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