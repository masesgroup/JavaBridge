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

namespace Javax.Swing.Text.Html
{
    #region HTMLWriter
    public partial class HTMLWriter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLWriter.html#%3Cinit%3E(java.io.Writer,javax.swing.text.html.HTMLDocument,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public HTMLWriter(Java.Io.Writer arg0, Javax.Swing.Text.Html.HTMLDocument arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLWriter.html#%3Cinit%3E(java.io.Writer,javax.swing.text.html.HTMLDocument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
        public HTMLWriter(Java.Io.Writer arg0, Javax.Swing.Text.Html.HTMLDocument arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLWriter.html#write()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Write()
        {
            IExecute("write");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}