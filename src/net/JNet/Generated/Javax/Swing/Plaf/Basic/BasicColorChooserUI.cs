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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicColorChooserUI
    public partial class BasicColorChooserUI
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

        #endregion

        #region Nested classes
        #region PropertyHandler
        public partial class PropertyHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicColorChooserUI.PropertyHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicColorChooserUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicColorChooserUI"/></param>
            public PropertyHandler(Javax.Swing.Plaf.Basic.BasicColorChooserUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicColorChooserUI.PropertyHandler"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicColorChooserUI.PropertyHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicColorChooserUI.PropertyHandler.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecuteWithSignature("propertyChange", "(Ljava/beans/PropertyChangeEvent;)V", arg0);
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