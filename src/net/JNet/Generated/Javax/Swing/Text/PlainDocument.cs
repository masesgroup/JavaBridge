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
    #region PlainDocument
    public partial class PlainDocument
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/PlainDocument.html#%3Cinit%3E(javax.swing.text.AbstractDocument.Content)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AbstractDocument.Content"/></param>
        public PlainDocument(Javax.Swing.Text.AbstractDocument.Content arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/PlainDocument.html#lineLimitAttribute"/>
        /// </summary>
        public static Java.Lang.String lineLimitAttribute { get { if (!_lineLimitAttributeReady) { _lineLimitAttributeContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "lineLimitAttribute"); _lineLimitAttributeReady = true; } return _lineLimitAttributeContent; } }
        private static Java.Lang.String _lineLimitAttributeContent = default;
        private static bool _lineLimitAttributeReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/PlainDocument.html#tabSizeAttribute"/>
        /// </summary>
        public static Java.Lang.String tabSizeAttribute { get { if (!_tabSizeAttributeReady) { _tabSizeAttributeContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "tabSizeAttribute"); _tabSizeAttributeReady = true; } return _tabSizeAttributeContent; } }
        private static Java.Lang.String _tabSizeAttributeContent = default;
        private static bool _tabSizeAttributeReady = false; // this is used because in case of generics 

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
}