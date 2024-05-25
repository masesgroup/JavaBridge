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

namespace Javax.Swing.Text
{
    #region IPosition
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPosition
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Position.html#getOffset()"/> 
        /// </summary>
        int Offset { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Position
    public partial class Position : Javax.Swing.Text.IPosition
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Position.html#getOffset()"/> 
        /// </summary>
        public int Offset
        {
            get { return IExecuteWithSignature<int>("getOffset", "()I"); }
        }

        #endregion

        #region Nested classes
        #region Bias
        public partial class Bias
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Position.Bias.html#Backward"/>
            /// </summary>
            public static Javax.Swing.Text.Position.Bias Backward { get { if (!_BackwardReady) { _BackwardContent = SGetField<Javax.Swing.Text.Position.Bias>(LocalBridgeClazz, "Backward"); _BackwardReady = true; } return _BackwardContent; } }
            private static Javax.Swing.Text.Position.Bias _BackwardContent = default;
            private static bool _BackwardReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Position.Bias.html#Forward"/>
            /// </summary>
            public static Javax.Swing.Text.Position.Bias Forward { get { if (!_ForwardReady) { _ForwardContent = SGetField<Javax.Swing.Text.Position.Bias>(LocalBridgeClazz, "Forward"); _ForwardReady = true; } return _ForwardContent; } }
            private static Javax.Swing.Text.Position.Bias _ForwardContent = default;
            private static bool _ForwardReady = false; // this is used because in case of generics 

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